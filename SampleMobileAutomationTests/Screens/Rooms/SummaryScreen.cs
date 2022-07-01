using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.Pages
{
    public class SummaryScreen
    {
        public CustomWebElement CheckInOutDate => new(By.Id(SummarySelectors.CheckInOutDate));
        public CustomWebElement NumberOfGuests => new(By.Id(SummarySelectors.NumberOfGuests));
        public CustomWebElement ConfirmButton => new(By.Id(SummarySelectors.ConfirmButton));
        public CustomWebElement DataPrivacyAndSecurityPolicy => new(By.Id(SummarySelectors.ConfirmButton));
    }
}