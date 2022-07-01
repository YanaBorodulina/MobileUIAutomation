using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using Sample.Mobile.Core.Extensions;
using Sample.Mobile.Core.Logger;
using Sample.Mobile.Core.WebDriver;

namespace Sample.Mobile.Core.WebElement
{
    public class CustomWebElement
    {
        public CustomWebElement(By locator)
        {
            Locator = locator;
        }

        private By Locator { get; }

        public IReadOnlyCollection<AppiumWebElement> Elements
        {
            get
            {
                try
                {
                    return GetElements();
                }
                catch (StaleElementReferenceException)
                {
                    LoggingHelper.LogDebug("Re-initialize web elements since DOM has been refreshed");
                    return GetElements();
                }
            }
        }

        public AppiumWebElement Element
        {
            get
            {
                try
                {
                    return GetElement();
                }
                catch (StaleElementReferenceException)
                {
                    LoggingHelper.LogDebug("Re-initialize web element since DOM has been refreshed");
                    return GetElement();
                }
            }
        }

        private AppiumWebElement GetElement()
        {
            return Driver.Instance.WaitForElementPresent(Locator, TestConfig.DefaultTimeout);
        }

        private IReadOnlyCollection<AppiumWebElement> GetElements()
        {
            return Driver.Instance.WaitForElementsPresent(Locator, TestConfig.DefaultTimeout);
        }
    }
}