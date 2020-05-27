using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLClientWPF.db
{
    public class MySQLDatabase : Database
    {
        public MySQLDatabase(string dbName, DbConnection connection) : base(dbName, connection)
        {
        }

        public override List<Table> getAllTables()
        {
            selectCurrentDatabase();

            // Some thing: we have to use raw query processing due to the mysql lack of schemas
            List<Table> tables = new List<Table>();
            DbCommand command = connection.CreateCommand();
            command.CommandText = "show tables;";
            var reader = command.ExecuteReader();
            while(reader.Read())
            {
                Table foundTable = new Table(reader.GetString(0));
                tables.Add(foundTable);
            }
            reader.Close();

            return tables;
        }
    }
}
