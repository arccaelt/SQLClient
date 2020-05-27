using System;
using static ProiectSQLClient.DatabaseVendor;
using ProiectSQLClient.db;
using ProiectSQLClient.exceptions;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ProiectSQLClient
{
    // The main responsability of this class is to facilitate the creation of
    // database objects and thus it will free us from knowing the inner workings
    // needed to create a database object from a connection strings and some credentials
    class DriverManager
    {
        public static DatabaseInstance getDatabaseInstance(DatabaseVendor databaseType, 
                                    string serverName=null, string instanceName=null,
                                    string username=null, string password=null)
        {
            DatabaseInstance database = null;
            switch(databaseType)
            {
                case MS_SQL:
                    database = createMSSQLDatabaseInstance(serverName, instanceName, username, password);
                    break;
                case MYSQL:
                    database = createMysqlDatabaseInstace(serverName, username, password);
                    break;
            }

            return database;
        }

        private static string getMSSQLConnectionString(string username, string password, string serverName, string instanceName)
        {
            string connectionString = null;

            if (username == null && password == null)
            {
                connectionString = string.Format(DatabaseConnectionString.MSSQL_TRUSTED_CONNECTION, serverName, instanceName);
            }
            else
            {
                connectionString = string.Format(DatabaseConnectionString.MSSQL_CREDENTIALS, serverName, instanceName, username, password);
            }

            return connectionString;
        }

        // NOTE: For MySQL we don't have support for instance(an database is considered an instance in MySQL)
        // therefor, when we connect to a mysql database we need to choose which database we want to connect to(inside the mysql database)
        // this being similar to make an 'use' command after the connection is established
        // For SQL Server, instanceName is fine since there we can have multiple instances each of with it's own databases
        private static string getMysqlConnectionString(string username, string password, string serverName, string databaseName)
        {
            // dont connect to any database instance
            return String.Format(DatabaseConnectionString.MSSQL_CREDENTIALS, serverName, databaseName, username, password);
        }

        private static MySQLDatabaseInstance createMysqlDatabaseInstace(string serverName,string username, string password)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();

                // hard code it to "" hence don't use any database
                connection.ConnectionString = getMysqlConnectionString(username, password, serverName, "");
                connection.Open();
                return new MySQLDatabaseInstance(connection);
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw new DatabaseConnectionException("Failed to connect to the MySQL Server database!\nCheck your configuratio and/or username/password and try again");
            }
        }

        private static MSSQLDatabaseInstance createMSSQLDatabaseInstance(string serverName, string instanceName, string username, string password)
        {
            // By default, we have a database instance called 'master' in SQL Server
            if (instanceName == null)
            {
                instanceName = "master";
            }

            string connectionString = getMSSQLConnectionString(username, password, serverName, instanceName);
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                return new MSSQLDatabaseInstance(connection);
            }
            catch (SqlException ex)
            {
                throw new DatabaseConnectionException("Failed to connect to the SQL Server database!\nCheck your configuratio and/or username/password and try again");
            }
        }
    }
}
