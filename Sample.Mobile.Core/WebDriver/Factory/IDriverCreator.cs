using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Sample.Mobile.Core.WebDriver
{
    public interface IDriverCreator
    {
        AppiumDriver<AppiumWebElement> GetWebDriver();
    }
}