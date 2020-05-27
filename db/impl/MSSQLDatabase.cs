using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectSQLClient.db
{
    class MSSQLDatabase : Database
    {
        public MSSQLDatabase(string dbName, DbConnection connection) : base(dbName, connection)
        {
        }

        private List<Table> getChildTables()
        {
            return null;
        }

        public override List<Table> getAllTables()
        {
            selectCurrentDatabase();
            List<Table> tables = new List<Table>();
            DataTable tablesSchema = ((SqlConnection)connection).GetSchema("Tables");

            foreach(DataRow tableMetadata in tablesSchema.Rows)
            {
                Table table = new Table((string)tableMetadata[2]);
                tables.Add(table);
            }

            return tables;
        }
    }
}
