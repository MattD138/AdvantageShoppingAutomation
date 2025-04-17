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

        [OneTimeTearDown]
        public void GlobalTearDown()
        {
            Driver.Dispose();
        }
    }
}