using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Concurrent;
using ToolsQA1.Framework;
using static ToolsQA1.Utils.Logger;

namespace ToolsQA1.Drivers
{
    public static class WebDriverManager
    {
        private static string PathToDriver => AppDomain.CurrentDomain.BaseDirectory;
        private static ConcurrentDictionary<string, IWebDriver> DriversInUse { get; set; } = new ConcurrentDictionary<string, IWebDriver>();
        private static string CurrentKey => TestContext.CurrentContext.Test.ID;

        public static IWebDriver Driver
        {
            get
            {
                if (DriversInUse.ContainsKey(CurrentKey))
                {
                    return DriversInUse[CurrentKey];
                }
                else
                {
                    var testId = TestContext.CurrentContext.Test.ID;
                    var driver = new DriverFactory().GetDriver(Settings.BrowserType).Setup(PathToDriver);

                    if (driver == null)
                    {
                        Log.Error("WebDriver instance was not initialized.");
                        throw new NullReferenceException("WebDriver instance was not initialized.");
                    }

                    return DriversInUse[testId] = driver;
                }
            }
        }

        public static void ReleaseDriver()
        {
            var driver = DriversInUse[CurrentKey];

            driver.Quit();

            if (!DriversInUse.TryRemove(CurrentKey, out _))
            {
                Log.Warn($"WebDriver instance with Id {CurrentKey} could not be removed!");
            }
        }
    }
}
