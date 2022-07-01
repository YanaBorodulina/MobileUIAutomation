using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using Sample.Mobile.Core.WebDriver;

namespace SampleMobileAutomationTests.CommonElements
{
    public class DropDown
    {
        private By _locator { get; }

        public DropDown(By locator)
        {
            _locator = locator;
        }

        public AppiumWebElement DropDownElement => Driver.Instance.FindElement(_locator);


        public AppiumWebElement GetDropDownValue(string value)
        {
            return Driver.Instance.FindElement(By.XPath($"//android.widget.TextView[contains(@text,'{value}')]"));
        }
    }
}