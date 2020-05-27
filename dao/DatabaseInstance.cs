using System.Collections.Generic;
using System.Data.Common;

namespace SQLClientWPF.db
{
    public abstract class DatabaseInstance
    {
        protected DbConnection connection;
        public string[] supportedKeywords;

        public DatabaseInstance(DbConnection connection, string[] keywords)
        {
            this.connection = connection;
            this.supportedKeywords = keywords;
        }

        public DbCommand getDbCommand()
        {
            return connection.CreateCommand();
        }

        // Because this connection is shared by all Database objects
        // destroying it here is enough
        public void destroyConnection()
        {
            connection.Dispose();
        }

        public abstract string getFullName();
        public abstract List<Database> getAllDatabases();
    }
}