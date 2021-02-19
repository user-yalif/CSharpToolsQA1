using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ToolsQA1.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(this.Driver, this);
        }
    }
}
