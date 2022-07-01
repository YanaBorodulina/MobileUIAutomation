using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.Pages
{
    public class LoginScreen
    {
        public CustomWebElement UserNumberFiled => new(By.Id(LoginSelectors.UserNumberFiled));
        public CustomWebElement PinField => new(By.Id(LoginSelectors.PinField));
        public CustomWebElement LoginButton => new(By.Id(LoginSelectors.LoginButton));
        public CustomWebElement ForgotAccountNumber => new(By.Id(LoginSelectors.ForgotAccountNumber));
        public CustomWebElement ForgotPin => new(By.Id(LoginSelectors.ForgotPin));
    }
}