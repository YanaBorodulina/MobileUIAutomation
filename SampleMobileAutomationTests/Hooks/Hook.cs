using System;
using OpenQA.Selenium;
using Sample.Mobile.Core;
using Sample.Mobile.Core.Extensions;
using Sample.Mobile.Core.WebDriver;
using SampleMobileAutomationTests.CommonElements;
using SampleMobileAutomationTests.Methods;
using SampleMobileAutomationTests.Models;
using SampleMobileAutomationTests.Pages;
using TechTalk.SpecFlow;

namespace SampleMobileAutomationTests.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
            var commonMethods = new CommonMethods();
            Driver.InitWebDriver(TestConfig.PlatformName);
            Driver.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TestConfig.DefaultTimeout);
            //TODO add app check and upload in remote run
            commonMethods.ConfirmAlert();
            SelectLanguage();
            Login();
            commonMethods.SkipUserGuid("Home");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Driver.Close();
        }

        private static void SelectLanguage()
        {
            var languageSelector = new LanguageSelector();
            const string language = "English";
            languageSelector.GetLanguage(language).Click();
        }

        private static void Login()
        {
            var user = new LoginUserModel()
            {
                UserNumber = TestConfig.UserNumber,
                Pin = TestConfig.Pin
            };
            if (FeatureContext.Current.FeatureInfo.Title is "Login" or "Forgot_User_Data") return;
            var login = new LoginMethods();

            login.Login(user);
            Driver.Instance.WaitForElementPresent(By.Id(HomeSelectors.PlayNowButton), 15);
            Driver.Instance.Navigate().Back();
        }
    }
}