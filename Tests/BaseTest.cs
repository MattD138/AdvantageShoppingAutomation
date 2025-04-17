using NUnit.Framework;
using OpenQA.Selenium;
using AdvantageShoppingAutomation.Utilities;

namespace AdvantageShoppingAutomation.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        [OneTimeSetUp]
        public void GlobalSetup()
        {
            Driver = WebDriverFactory.CreateDriver("chrome");
        }

        [SetUp]
        public void NavigateToSite()
        {
            Driver.Navigate().GoToUrl("https://www.advantageonlineshopping.com/");
        }

        [OneTimeTearDown]
        public void GlobalTearDown()
        {
            Driver.Quit();
        }
    }
}