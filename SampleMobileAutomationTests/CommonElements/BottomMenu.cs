using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.CommonElements
{
    public class BottomMenu
    {
        public CustomWebElement RoomButton => new CustomWebElement(By.Id(BottomMenuSelectors.RoomButton));

    }
}