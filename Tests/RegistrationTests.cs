using AdvantageShoppingAutomation.Pages;
using AdvantageShoppingAutomation.Utilities;

namespace AdvantageShoppingAutomation.Tests
{
    public class RegistrationTests : BaseTest
    {
        [Test]
        public void LOG001_MandatoryFieldValidation_ShowsAndClearsErrors()
        {
            UserData userData = TestDataLoader.LoadUserData();

            // Navigate to the home page
            Driver.Navigate().GoToUrl(TestDataLoader.LoadBaseUrl());
            var homePage = new HomePage(Driver);

            // Navigate to /register via login modal on the home page
            homePage.ClickUserIcon();
            homePage.ClickCreateNewAccountLink();

            // Click into and out of the Username, Email, Password and Confirm Password fields
            var registerPage = new RegistrationPage(Driver);
            registerPage.TriggerMandatoryFieldErrors();

            var registerFormErrors = registerPage.GetErrorMessages();

            // Verify that errors display and contain the correct content
            Assert.That(registerFormErrors, Has.Some.Contain("Username field is required"));
            Assert.That(registerFormErrors, Has.Some.Contain("Email field is required"));
            Assert.That(registerFormErrors, Has.Some.Contain("Password field is required"));
            Assert.That(registerFormErrors, Has.Some.Contain("Confirm password field is required"));

            // Enter valid data for Username, Email, Password and Confirm Password fields
            registerPage.EnterMandatoryData(
                userData.Username,
                userData.Email,
                userData.Password);

            // Verify that all errors are cleared
            Assert.That(registerPage.AreErrorsCleared(), Is.True);
        }
    }
}
