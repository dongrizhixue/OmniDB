namespace OmniDB.WinForms
{
    /// <summary>
    /// 应用程序全局常量
    /// </summary>
    public class AppConstants
    {
        /// <summary>
        /// 配置文件名称
        /// </summary>
        private const string ConfigFileName = "connection_settings.json";
        public static string GetConfigFileName()
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(appPath, ConfigFileName);
        }
    }
}
