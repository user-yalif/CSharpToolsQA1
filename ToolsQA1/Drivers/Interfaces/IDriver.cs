using OpenQA.Selenium;

namespace ToolsQA1.Drivers.Interfaces
{
    public interface IDriver
    {
        IWebDriver Setup(string pathToDriver, string downloadPath = null);
    }
}
