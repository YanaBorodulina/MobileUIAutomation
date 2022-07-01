using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using Sample.Mobile.Core.WebDriver;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.Pages
{
    public class TermAndConditions
    {
        public CustomWebElement XButton => new(By.Id(TermAndConditionsSelectors.XButton));

        public AppiumWebElement GetHeader(string header)
        {
            return Driver.Instance.FindElement(By.XPath($"//android.view.View[contains(@text,'{header}')]"));
        }
    }
}