using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using static NUnit.Framework.TestContext;

namespace Sample.Mobile.Core.WebDriver
{
    public class AndroidDriverCreator : IDriverCreator
    {
        public AppiumDriver<AppiumWebElement> GetWebDriver()
        {
            return TestConfig.Local ? GetLocalWebDriver() : GetRemoteWebDriver();
        }

        private AppiumDriver<AppiumWebElement> GetRemoteWebDriver()
        {
            var driver = new AndroidDriver<AppiumWebElement>(new Uri(TestConfig.RemoteDriver), GetOptions());
            return driver;
        }

        private AppiumDriver<AppiumWebElement> GetLocalWebDriver()
        {
            var driver = new AndroidDriver<AppiumWebElement>(new Uri(TestConfig.LocalDriver), GetLocalOption());
            return driver;
        }

        private static AppiumOptions GetLocalOption()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("autoGrantPermissions", "true");
            //appiumOptions.AddAdditionalCapability("appPackage", TestConfig.AppPackage);
            //appiumOptions.AddAdditionalCapability("appActivity", TestConfig.AppActivity);
            appiumOptions.AddAdditionalCapability("device", TestConfig.LocalDevice);
            appiumOptions.AddAdditionalCapability("os_version", TestConfig.OsVersion);
            appiumOptions.AddAdditionalCapability("autoAcceptAlerts", true);
            appiumOptions.AddAdditionalCapability("unicodeKeyboard", false);
            appiumOptions.AddAdditionalCapability("resetKeyboard", false);
            appiumOptions.PlatformName = TestConfig.PlatformName;
            return appiumOptions;
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
            appiumOptions.AddAdditionalCapability("autoGrantPermissions", "true");

            // Set URL of the application under test
            appiumOptions.AddAdditionalCapability("app", TestConfig.BrowserstackAppLink);
            appiumOptions.AddAdditionalCapability("appPackage", TestConfig.AppPackage);
            //appiumOptions.AddAdditionalCapability("appActivity", TestConfig.AppActivity);

            appiumOptions.AddAdditionalCapability("device", TestConfig.Device);
            appiumOptions.AddAdditionalCapability("os_version", TestConfig.OsVersion);
            appiumOptions.AddAdditionalCapability("autoAcceptAlerts", true);
            appiumOptions.AddAdditionalCapability("unicodeKeyboard", false);
            appiumOptions.AddAdditionalCapability("resetKeyboard", false);
            appiumOptions.PlatformName = TestConfig.PlatformName;
            appiumOptions.AddAdditionalCapability("name", CurrentContext.Test.Name);
            return appiumOptions;
        }
    }
}