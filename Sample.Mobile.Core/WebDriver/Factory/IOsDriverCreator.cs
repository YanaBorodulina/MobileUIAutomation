using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using static NUnit.Framework.TestContext;


namespace Sample.Mobile.Core.WebDriver
{
    public class IOsDriverCreator : IDriverCreator
    {
        public AppiumDriver<AppiumWebElement> GetWebDriver()
        {
            return TestConfig.Local ? GetLocalWebDriver() : GetRemoteWebDriver();
        }

        private AppiumDriver<AppiumWebElement> GetLocalWebDriver()
        {
            throw new NotImplementedException();
        }

        private AppiumDriver<AppiumWebElement> GetRemoteWebDriver()
        {
            var driver = new IOSDriver<AppiumWebElement>(new Uri(TestConfig.RemoteDriver), GetOptions());
            return driver;
        }

        private static AppiumOptions GetOptions()
        {
            var appiumOptions = new AppiumOptions();

            // Set your BrowserStack 
            appiumOptions.AddAdditionalCapability("browserstack.user", TestConfig.BrowserstackUser);
            appiumOptions.AddAdditionalCapability("browserstack.key", TestConfig.BrowserstackKey);
            appiumOptions.AddAdditionalCapability("browserstack.networkLogs", true);
            appiumOptions.AddAdditionalCapability("browserstack.debug", true);
            appiumOptions.AddAdditionalCapability("browserstack.console errors", true);

            // Set URL of the application under test
            appiumOptions.AddAdditionalCapability("app", TestConfig.BrowserstackAppLink);

            appiumOptions.AddAdditionalCapability("device", TestConfig.Device);
            appiumOptions.AddAdditionalCapability("os_version", TestConfig.OsVersion);
            appiumOptions.AddAdditionalCapability("autoAcceptAlerts", "true");
            appiumOptions.PlatformName = TestConfig.PlatformName;
            appiumOptions.AddAdditionalCapability("name", CurrentContext.Test.Name);
            return appiumOptions;
        }
    }
}