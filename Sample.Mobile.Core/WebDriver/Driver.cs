using System;
using System.Threading;
using OpenQA.Selenium.Appium;
using Sample.Mobile.Core.Extensions;
using Sample.Mobile.Core.Logger;

namespace Sample.Mobile.Core.WebDriver
{
    public static class Driver
    {
        private static readonly ThreadLocal<AppiumDriver<AppiumWebElement>> ThreadLocalContext = new();

        public static AppiumDriver<AppiumWebElement> Instance =>
            ThreadLocalContext.Value.CheckNotNull(nameof(Driver), "Driver = null. Probably driver was not initialized - use InitWebDriver() method first");

        public static void InitWebDriver(string driverType)
        {
            var driverCreator = DriverFactory.GetDriverCreator(driverType);
            LoggingHelper.LogInformation($"Initialization of the driver ({driverType}) has been started for thread {Thread.CurrentThread.ManagedThreadId}");
            ThreadLocalContext.Value = driverCreator.GetWebDriver();
        }

        public static void Close()
        {
            try
            {
                LoggingHelper.LogInformation("Try to close driver");
                ThreadLocalContext.Value.Quit();
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(ex.StackTrace);
            }
            finally
            {
                ThreadLocalContext.Value = null;
                LoggingHelper.LogInformation("Driver should be closed");
            }
        }
    }
}