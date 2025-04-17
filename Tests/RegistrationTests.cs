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

            // Navigate to /register via home page
            var homePage = new HomePage(Driver);
            homePage.ClickUserIcon();
            homePage.ClickCreateNewAccountLink();

            var registerPage = new RegistrationPage(Driver);
            registerPage.TriggerMandatoryFieldErrors();

            var registerFormErrors = registerPage.GetErrorMessages();

            Assert.IsTrue(registerFormErrors.Any(e => e.Contains("Username field is required")));
            Assert.IsTrue(registerFormErrors.Any(e => e.Contains("Email field is required")));
            Assert.IsTrue(registerFormErrors.Any(e => e.Contains("Password field is required")));
            Assert.IsTrue(registerFormErrors.Any(e => e.Contains("Confirm password field is required")));

            registerPage.EnterMandatoryData(
                userData.Username,
                userData.Email,
                userData.Password);

            Assert.IsTrue(registerPage.AreErrorsCleared());
        }
    }
}
