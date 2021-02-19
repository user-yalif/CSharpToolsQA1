using OpenQA.Selenium;

namespace ToolsQA1.Extentions
{
    public static class WebDriverExtentions
    {
        public static void GoToUrl(this IWebDriver driver, string url) =>
            driver.Navigate().GoToUrl(url);
    }
}
