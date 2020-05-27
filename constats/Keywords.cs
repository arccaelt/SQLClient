using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLClientWPF
{
    // Here we'll hold the needed information to do syntax highlighting for SQL Server
    class DatabaseSQLKeywords
    {
        public static readonly string[] MYSQL_KEYWORDS = {
            "SELECT", "FROM", "WHERE", "ORDER", "BY", "GROUP",
            "JOIN", "INNER", "LEFT", "RIGHT", "INSERT", "DELETE", "UPDATE",
            "DROP", "CREATE", "ALTER", "PRIMARY", "KEY", "AUTO_INCREMENT", "TABLE",
            "DATABASE", "VARCHAR", "CHAR", "IF", "AND", "OR", "NOT", "DEFAULT",
            "PROCEDURE", "USE", "INT", "FLOAT", "DOUBLE", "BLOB"
        };

        public static readonly string[] MSSQL_KEYWORDS = {
                "ADD", "EXTERNAL", "PROCEDURE", "USE",
                "ALL", "FETCH", "PUBLIC",
                "ALTER", "FILE", "RAISERROR",
                "AND", "FILLFACTOR", "READ",
                "ANY", "FOR", "READTEXT",
                "AS", "FOREIGN", "RECONFIGURE",
                "ASC", "FREETEXT", "REFERENCES",
                "AUTHORIZATION", "FREETEXTTABLE", "REPLICATION",
                "BACKUP", "FROM", "RESTORE",
                "BEGIN", "FULL", "RESTRICT",
                "BETWEEN", "FUNCTION", "RETURN",
                "BREAK", "GOTO", "REVERT",
                "BROWSE", "GRANT", "REVOKE",
                "BULK", "GROUP", "RIGHT",
                "BY", "HAVING", "ROLLBACK",
                "CASCADE", "HOLDLOCK", "ROWCOUNT",
                "CASE", "IDENTITY", "ROWGUIDCOL",
                "CHECK", "IDENTITY_INSERT", "RULE",
                "CHECKPOINT", "IDENTITYCOL", "SAVE",
                "CLOSE", "IF", "SCHEMA",
                "CLUSTERED", "IN", "SECURITYAUDIT",
                "COALESCE", "INDEX", "SELECT",
                "COLLATE", "INNER", "SEMANTICKEYPHRASETABLE",
                "COLUMN", "INSERT", "SEMANTICSIMILARITYDETAILSTABLE",
                "COMMIT", "INTERSECT", "SEMANTICSIMILARITYTABLE",
                "COMPUTE", "INTO", "SESSION_USER",
                "CONSTRAINT", "IS", "SET",
                "CONTAINS", "JOIN", "SETUSER",
                "CONTAINSTABLE", "KEY", "SHUTDOWN",
                "CONTINUE", "KILL", "SOME",
                "CONVERT", "LEFT", "STATISTICS",
                "CREATE", "LIKE", "SYSTEM_USER",
                "CROSS", "LINENO", "TABLE",
                "CURRENT", "LOAD", "TABLESAMPLE",
                "CURRENT_DATE", "MERGE", "TEXTSIZE",
                "CURRENT_TIME", "NATIONAL", "THEN",
                "CURRENT_TIMESTAMP", "NOCHECK", "TO",
                "CURRENT_USER", "NONCLUSTERED", "TOP",
                "CURSOR", "NOT", "TRAN",
                "DATABASE", "NULL", "TRANSACTION",
                "DBCC", "NULLIF", "TRIGGER",
                "DEALLOCATE", "OF", "TRUNCATE",
                "DECLARE", "OFF", "TRY_CONVERT",
                "DEFAULT", "OFFSETS", "TSEQUAL",
                "DELETE", "ON", "UNION",
                "DENY", "OPEN", "UNIQUE",
                "DESC", "OPENDATASOURCE", "UNPIVOT",
                "DISK", "OPENQUERY", "UPDATE",
                "DISTINCT", "OPENROWSET", "UPDATETEXT",
                "DISTRIBUTED", "OPENXML", "USE",
                "DOUBLE", "OPTION", "USER",
                "DROP", "OR", "VALUES",
                "DUMP", "ORDER", "VARYING",
                "ELSE", "OUTER", "VIEW",
                "END", "OVER", "WAITFOR",
                "ERRLVL", "PERCENT", "WHEN",
                "ESCAPE", "PIVOT", "WHERE",
                "EXCEPT", "PLAN", "WHILE",
                "EXEC", "PRECISION", "WITH",
                "EXECUTE", "PRIMARY", "WITHIN GROUP",
                "EXISTS", "PRINT", "WRITETEXT",
                "EXIT", "PROC"
        };
    }
}
