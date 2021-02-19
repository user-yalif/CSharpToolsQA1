using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using ToolsQA1.Drivers;
using ToolsQA1.Framework;
using static ToolsQA1.Utils.Logger;

namespace ToolsQA1.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver;

        [SetUp]
        public virtual void Init()
        {
            Log.Info("Driver initialization");
            Driver = WebDriverManager.Driver;

            Log.Info($"Test {TestContext.CurrentContext.Test.Name} started");

            SiteNavigator.NavigateToStartPage(Driver);
        }

        [TearDown]
        public virtual void Cleanup()
        {
            var testName = TestContext.CurrentContext.Test.Name;
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;

            Log.Info($"{testName} finished with status: {testStatus.ToString().ToUpper()}");

            if (testStatus == TestStatus.Failed)
            {
                // TODO: Add implementation
                // var screenshotName = Screenshoter.TakeScreenshotWithDate(Driver);
                //Log.Info($"Screenshot {screenshotName} was taken");
            }

            Log.Info("Driver release started.");
            WebDriverManager.ReleaseDriver();
            Log.Info("Driver was closed successfully.");
        }
    }
}
