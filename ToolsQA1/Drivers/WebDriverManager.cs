using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Concurrent;

namespace ToolsQA1.Drivers
{
    public static class WebDriverManager
    {
        private static ConcurrentDictionary<string, IWebDriver> DriversInUse { get; set; } = new ConcurrentDictionary<string, IWebDriver>();

        private static string CurrentKey => TestContext.CurrentContext.Test.ID;

        public static IWebDriver Driver
        {
            get
            {
                return default;
            }
        }
    }
}
