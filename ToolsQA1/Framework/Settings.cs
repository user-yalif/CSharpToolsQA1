using System.Configuration;

namespace ToolsQA1.Framework
{
    public static class Settings
    {
        public static string BrowserType { get; }

        public static string BaseUrl { get; }

        static Settings()
        {
            BrowserType = ConfigurationManager.AppSettings["BrowserType"];
            BaseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        }
    }
}
