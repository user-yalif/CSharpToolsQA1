using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ToolsQA1.Drivers.Interfaces;

namespace ToolsQA1.Drivers
{
    public class DriverChrome : IDriver
    {
        public IWebDriver Setup(string pathToDriver, string downloadPath)
        {
            // TODO: Check up download path
            return new ChromeDriver(pathToDriver, GetChromeOptions(downloadPath));
        }

        private ChromeOptions GetChromeOptions(string downloadPath)
        {
            ChromeOptions options = new ChromeOptions();

            //options.AddArgument("--headless");
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-infobars");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--no-sandbox");

            //To disable the popup for Password save
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddUserProfilePreference("profile.default_content_setting_values.automatic_downloads", 1);

            if (!string.IsNullOrEmpty(downloadPath))
            {
                options.AddUserProfilePreference("download.default_directory", downloadPath);
            }

            return options;
        }
    }
}
