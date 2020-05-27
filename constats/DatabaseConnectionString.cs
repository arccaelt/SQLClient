using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLClientWPF
{
    class DatabaseConnectionString
    {
        public static readonly string MSSQL_CREDENTIALS = @"Server={0};Initial Catalog={1};User Id={2};Password={3}";
        public static readonly string MSSQL_TRUSTED_CONNECTION = @"Server={0};Initial Catalog={1};Trusted_Connection=True;";

        public static readonly string MYSQ_CREDENTIALS = @"Server={0};Database={1};Uid={2};Pwd={3}";
    }
}
