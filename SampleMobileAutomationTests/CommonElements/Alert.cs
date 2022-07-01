using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.CommonElements
{
    public class Alert
    {
        public readonly CustomWebElement DialogOkButton = new(By.Id(AlertSelectors.DialogOkButton));
    }
}