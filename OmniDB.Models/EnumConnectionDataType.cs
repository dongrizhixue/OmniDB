using System.ComponentModel;

namespace OmniDB.Models
{
    /// <summary>
    /// 数据库类型枚举
    /// </summary>
    public enum EnumConnectionDataType
    {
        /// <summary>
        /// SQL Server
        /// </summary>
        [Description("SQL Server")]
        SQLServer = 1,
        
        /// <summary>
        /// MySQL
        /// </summary>
        [Description("MySQL")]
        MySQL = 2,
        
        /// <summary>
        /// PostgreSQL
        /// </summary>
        [Description("PostgreSQL")]
        PostgreSQL = 3,
        
        /// <summary>
        /// Oracle
        /// </summary>
        [Description("Oracle")]
        Oracle = 4,
        
        /// <summary>
        /// SQLite
        /// </summary>
        [Description("SQLite")]
        SQLite = 5
    }
}