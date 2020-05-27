using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectSQLClient
{
    // Implementation for the concept of a table from a relational database
    // Should hold basic information for a table and the field from this class will be
    // filled by different implementation classes of super class 'Database'
    public class Table
    {
        public string tableName { get; }

        public Table(string tableName)
        {
            this.tableName = tableName;
        }
    }
}
