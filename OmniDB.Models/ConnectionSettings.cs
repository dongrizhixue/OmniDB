namespace OmniDB.Models
{
    /// <summary>
    /// 连接设置类
    /// </summary>
    public class ConnectionSettings
    {
        /// <summary>
        /// 连接名称
        /// </summary>
        public string? Name { get; set; }
        
        /// <summary>
        /// 连接类型
        /// </summary>
        public string? ConnectionType { get; set; }
        
        /// <summary>
        /// 连接字符串
        /// </summary>
        public string? ConnectionString { get; set; }
    }
}