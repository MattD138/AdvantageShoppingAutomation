using OpenQA.Selenium;

namespace AdvantageShoppingAutomation.Pages
{
    internal class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
            // RegistrationPage Constructor
        }
        // Registration form fields
        private By UsernameFieldLocator = By.Name("usernameRegisterPage");
        private By EmailFieldLocator = By.Name("emailRegisterPage");
        private By PasswordFieldLocator = By.Name("passwordRegisterPage");
        private By ConfirmPasswordFieldLocator = By.Name("confirm_passwordRegisterPage");
        // Static element outside fields used to defocus
        private By CreateAccountHeadingLocator = By.XPath("//div[@id='registerCover']//h3[text()='ACCOUNT DETAILS']");

        public void TriggerMandatoryFieldErrors()
        {
            SafeClick(UsernameFieldLocator);
            SafeClick(EmailFieldLocator);
            SafeClick(PasswordFieldLocator);
            SafeClick(ConfirmPasswordFieldLocator);
            // Click outside the fields to trigger validation
            SafeClick(CreateAccountHeadingLocator);
        }

        public void EnterMandatoryData(string username, string email, string password)
        {
            SafeSendKeys(UsernameFieldLocator, username);
            SafeSendKeys(EmailFieldLocator, email);
            SafeSendKeys(PasswordFieldLocator, password);
            SafeSendKeys(ConfirmPasswordFieldLocator, password);
        }

        private By registerFormErrorLabelLocator = By.XPath("//div[@id='registerCover']//label[@class='invalid']");
        private List<IWebElement> ErrorMessages => Driver.FindElements(registerFormErrorLabelLocator).ToList();
        public List<string> GetErrorMessages() => ErrorMessages.Select(e => e.Text).ToList();

        public bool AreErrorsCleared() => !ErrorMessages.Any();

    }
}
