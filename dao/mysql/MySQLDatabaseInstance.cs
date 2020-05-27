using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SQLClientWPF.db
{
    class MySQLDatabaseInstance : DatabaseInstance
    {
        public MySQLDatabaseInstance(DbConnection connection) : base(connection, DatabaseSQLKeywords.MYSQL_KEYWORDS)
        {
        }

        public override List<Database> getAllDatabases()
        {
            // Because MySQL doesn't suppor schemas(a database in itself is a schema)
            // we have to use raw query processing to get all the databases from the db itself
            DbCommand command = connection.CreateCommand();
            command.CommandText = "SHOW DATABASES;";
            var reader = command.ExecuteReader();

            List<Database> foundDbs = new List<Database>();
            while (reader.Read())
            {
                Database foundDatabase = new MySQLDatabase(reader.GetString(0), connection);
                foundDbs.Add(foundDatabase);
            }
            reader.Close();

            return foundDbs;
        }

        public override string getFullName()
        {
            return "MySQL";
        }
    }
}
