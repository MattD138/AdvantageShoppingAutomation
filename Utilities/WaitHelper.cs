using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AdvantageShoppingAutomation.Utilities
{
    public static class WaitHelper
    {
        public static IWebElement WaitUntilVisible(IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static bool WaitUntilInvisible(IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
        }

        public static bool WaitUntilAllInvisible(IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(driver =>
            {
                var elements = driver.FindElements(locator);
                return elements.All(e => !e.Displayed);
            });
        }

        public static IWebElement WaitUntilClickable(IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

    }

}