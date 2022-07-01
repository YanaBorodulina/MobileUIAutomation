using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.Pages
{
    public class RestoreAccountScreen
    {
        public CustomWebElement LastNameField => new(By.Id(RestoreAccountSelectors.LastNameField));
        public CustomWebElement FirstNameField => new(By.Id(RestoreAccountSelectors.FirstNameField));
        public CustomWebElement DateOfBirthField => new(By.Id(RestoreAccountSelectors.DateOfBirthField));
        public CustomWebElement MobileNumberField => new(By.Id(RestoreAccountSelectors.MobileNumberField));
        public CustomWebElement AccountNumberField => new(By.Id(RestoreAccountSelectors.AccountNumberField));
        public CustomWebElement ResetPinButton => new(By.Id(RestoreAccountSelectors.ResetPinButton));
        public CustomWebElement RetrievalAccountButton => new(By.Id(RestoreAccountSelectors.RetrievalAccountButton));
    }
}