using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.Pages
{
    public class SearchRoomScreen
    {
        public CustomWebElement SelectRoomButton => new(By.Id(SearchRoomSelectors.SelectRoomButton));
        public CustomWebElement BookButton => new(By.Id(SearchRoomSelectors.BookButton));
        public CustomWebElement BookNowButton => new(By.Id(SearchRoomSelectors.BookNowButton));
    }
}