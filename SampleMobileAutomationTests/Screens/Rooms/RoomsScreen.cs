using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using Sample.Mobile.Core.WebDriver;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.Pages
{
    public class RoomsScreen
    {
        public CustomWebElement CheckInFiled => new(By.Id(RoomsScreenSelectors.CheckInFiled));
        public CustomWebElement CheckOutFiled => new(By.Id(RoomsScreenSelectors.CheckOutFiled));
        public CustomWebElement AdultsFiled => new(By.Id(RoomsScreenSelectors.AdultsFiled));
        public CustomWebElement ChildrenFiled => new(By.Id(RoomsScreenSelectors.ChildrenFiled));
        public CustomWebElement SelectRatePreferenceFiled => new(By.Id(RoomsScreenSelectors.SelectRatePreferenceFiled));
        public CustomWebElement EnterCodeFiled => new(By.Id(RoomsScreenSelectors.EnterCodeFiled));
        public CustomWebElement NumberOfSelectedRooms => new(By.Id(RoomsScreenSelectors.NumberOfSelectedRooms));
        public CustomWebElement RoomsFiled => new(By.Id(RoomsScreenSelectors.RoomsFiled));
        public CustomWebElement MonthName => new(By.Id(RoomsScreenSelectors.MonthName));
        public CustomWebElement NextMonth => new(By.Id(RoomsScreenSelectors.NextMonth));
        public CustomWebElement SearchRoomsButton => new(By.Id(RoomsScreenSelectors.SearchRoomsButton));
        public CustomWebElement SearchPackagesButton => new(By.Id(RoomsScreenSelectors.SearchPackagesButton));
        public CustomWebElement ViewMyBookingHistoryButton => new(By.Id(RoomsScreenSelectors.ViewMyBookingHistoryButton));


        public AppiumWebElement GetDay(string day)
        {
            return Driver.Instance.FindElement(By.XPath($"//android.widget.CheckedTextView[@content-desc='{day}']"));
        }
    }
}