using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.Pages
{
    public class BookingConfirmationScreen
    {
        public CustomWebElement ImageOk => new(By.Id(BookingConfirmationSelectors.ImageOk));
        public CustomWebElement UserMessage => new(By.Id(BookingConfirmationSelectors.UserMessage));
        public CustomWebElement YesButton => new(By.Id(BookingConfirmationSelectors.YesButton));
    }
}