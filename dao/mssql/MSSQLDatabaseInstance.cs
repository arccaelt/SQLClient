using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SQLClientWPF.db
{
    public class MSSQLDatabaseInstance : DatabaseInstance
    {
        public MSSQLDatabaseInstance(SqlConnection connection) : base(connection, DatabaseSQLKeywords.MSSQL_KEYWORDS) { }

        public override List<Database> getAllDatabases()
        {
            List<Database> dbs = new List<Database>();

            DataTable dbSchema = connection.GetSchema("Databases");
            foreach (DataRow database in dbSchema.Rows)
            {
                String databaseName = (string)database[0];
                dbs.Add(new MSSQLDatabase(databaseName, (SqlConnection)connection));
            }

            return dbs;
        }

        public override string getFullName()
        {
            return "SQL Server";
        }
    }
}
