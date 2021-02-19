using OpenQA.Selenium;
using ToolsQA1.Extentions;
using ToolsQA1.Pages;
using static ToolsQA1.Utils.Logger;

namespace ToolsQA1.Framework
{
    public class SiteNavigator
    {
        public static StartPage NavigateToStartPage(IWebDriver driver)
        {
            Log.Info($"Navigate to {Settings.BaseUrl}");

            driver.GoToUrl(Settings.BaseUrl);

            return new StartPage(driver);
        }
    }
}
