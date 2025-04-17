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

        // Global selector for loader spinners
        protected By loaderLocator => By.ClassName("loader");

        public void SafeClick(By locator)
        {
            // Verify that no loaders are on screen
            WaitHelper.WaitUntilAllInvisible(Driver, loaderLocator);

            IWebElement element = WaitHelper.WaitUntilClickable(Driver, locator);
            element.Click();
        }

        public void SafeSendKeys(By locator, string value)
        {
            // Verify that no loaders are on screen
            WaitHelper.WaitUntilAllInvisible(Driver, loaderLocator);

            IWebElement element = WaitHelper.WaitUntilVisible(Driver, locator);
            element.Clear();
            element.SendKeys(value);
        }

        public bool ElementExists(By locator)
        {
            try { return Driver.FindElement(locator).Displayed; }
            catch (NoSuchElementException) { return false; }
        }

        // Website header is common to all pages
        protected By UserIcon = By.Id("menuUser");
        public void ClickUserIcon() => SafeClick(UserIcon);

        // Login modal
        protected By LoginModal = By.XPath("//login-modal/div[@class='PopUp']");
        protected By CreateNewAccountLink = By.ClassName("create-new-account");
        public void ClickCreateNewAccountLink()
        {
            // Wait for the login modal to be fully revealed
            WaitHelper.WaitUntilVisible(Driver, LoginModal);
            Thread.Sleep(1000);

            WaitHelper.WaitUntilClickable(Driver, CreateNewAccountLink);
            SafeClick(CreateNewAccountLink);
        }

        public void Log(String message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss} - {message}");
        }

    }
}
