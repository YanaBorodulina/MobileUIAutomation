using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;

namespace Sample.Mobile.Core.Extensions
{
    public static class WaitExtensions
    {
        public const int MediumTimeout = 4;

        public static AppiumWebElement WaitForElementPresent(this AppiumDriver<AppiumWebElement> driver, By locator, int? timeoutInSec = null)
        {
            var wait = new DefaultWait<AppiumDriver<AppiumWebElement>>(driver)
            {
                Timeout = TimeSpan.FromSeconds((double)timeoutInSec)
            };

            return wait.Until(_ => _.FindElement(locator));
        }


        public static IReadOnlyCollection<AppiumWebElement> WaitForElementsPresent(this AppiumDriver<AppiumWebElement> driver, By locator, int? timeoutInSec = null)
        {
            var wait = new DefaultWait<AppiumDriver<AppiumWebElement>>(driver)
            {
                Timeout = TimeSpan.FromSeconds((double)timeoutInSec)
            };

            return wait.Until(_ => _.FindElements(locator));
        }
    }
}