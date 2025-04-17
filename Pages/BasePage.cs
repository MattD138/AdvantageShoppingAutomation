using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AdvantageShoppingAutomation.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver Driver;
        protected WebDriverWait Wait;
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void Log(String message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss} - {message}");
        }
    }
}
