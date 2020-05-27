using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectSQLClient
{
    // Encapsulate the concept of a 'database instance' we'll be working with from now on in our code.
    // NOTE: Using IDbConnection we can have flexibility as this interface will be impleneted for all conections classes
    // for all db providers is constructed in such a manner
    // to allow manipulation of any database(SqlConnection is tailored for Sql Server and thus has better
    // performance but limited flexibility)
    public abstract class Database
    {
        protected string dbName;
        protected DbConnection connection;

        public Database(string dbName, DbConnection connection)
        {
            this.dbName = dbName;
            this.connection = connection;
        }

        public string getDbName()
        {
            return dbName;
        }

        public DbConnection getConnection()
        {
            return connection;
        }

        // NOTE: For MySQL and SQL Server the following method will work but for other databases it might not
        // TODO: Find a generic way of handling this
        protected void selectCurrentDatabase()
        {
            // Select the database before attempting to select the tables from it
            DbCommand query = connection.CreateCommand();
            query.CommandText = "use " + dbName;
            Console.WriteLine(query.CommandText);
            query.ExecuteNonQuery();
            query.Dispose();
        }

        // Even if we're using OleDbConnection which, at least in theory, be able
        // to connect to any database if we have a provider for it, for every database
        // exists a specific way to get all the tables from it, so, we'll make this method
        // abstract and let concrete implementation do it!
        public abstract List<Table> getAllTables();
    }
}
