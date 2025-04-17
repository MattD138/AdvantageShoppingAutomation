using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AdvantageShoppingAutomation.Utilities
{
    public class WebDriverFactory
    {
        public static IWebDriver CreateDriver(string browser)
        {
            IWebDriver driver;
            switch (browser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                // TODO: Add other browsers
                default:
                    throw new ArgumentException($"Browser '{browser}' is not supported.");
            }
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
