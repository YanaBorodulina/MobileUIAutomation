using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;
using SampleMobileAutomationTests.CommonElements;

namespace SampleMobileAutomationTests.Pages
{
    public class YourDetailsScreen
    {
        public CustomWebElement FirstNameField => new(By.Id(YourDetailsSelectors.FirstNameField));
        public CustomWebElement LastNameField => new(By.Id(YourDetailsSelectors.LastNameField));
        public CustomWebElement PhoneNumberField => new(By.Id(YourDetailsSelectors.PhoneNumberField));
        public CustomWebElement EmailField => new(By.Id(YourDetailsSelectors.EmailField));
        public DropDown TitleDropDown => new(By.Id(YourDetailsSelectors.TitleDropDown));
        public DropDown CountryOfResidenceDropDown => new(By.Id(YourDetailsSelectors.CountryOfResidenceDropDown));
        public CustomWebElement ProceedButton => new(By.Id(YourDetailsSelectors.ProceedButton));
        public CustomWebElement TermAndConditionLink => new(By.Id(YourDetailsSelectors.TermAndConditionLink));
        public CustomWebElement ErrorMessage => new(By.Id(YourDetailsSelectors.ErrorMessage));
    }
}