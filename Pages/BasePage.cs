using AdvantageShoppingAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AdvantageShoppingAutomation.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver Driver;
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void SafeClick(By locator)
        {
            var element = WaitHelper.WaitUntilClickable(Driver, locator);
            element.Click();
        }

        public void SafeSendKeys(By locator, string value)
        {
            var element = WaitHelper.WaitUntilVisible(Driver, locator);
            element.Clear();
            element.SendKeys(value);
        }

        public bool ElementExists(By locator)
        {
            try { return Driver.FindElement(locator).Displayed; }
            catch (NoSuchElementException) { return false; }
        }

        // Icon buttons in the website header, common to all pages
        protected By UserIcon = By.Id("menuUser");
        public void ClickUserIcon() => SafeClick(UserIcon);

        // Login modal
        protected By CreateNewAccountLink = By.ClassName("create-new-account");
        public void ClickCreateNewAccountLink() => SafeClick(CreateNewAccountLink);


        public void Log(String message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss} - {message}");
        }
    }
}
