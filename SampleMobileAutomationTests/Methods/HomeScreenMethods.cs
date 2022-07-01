using OpenQA.Selenium;
using Sample.Mobile.Core.Extensions;
using Sample.Mobile.Core.Logger;
using Sample.Mobile.Core.WebDriver;
using SampleMobileAutomationTests.CommonElements;
using SampleMobileAutomationTests.Pages;

namespace SampleMobileAutomationTests.Methods
{
    public class HomeScreenMethods
    {
        public bool IsHomeScreenOpened()
        {
            Driver.Instance.WaitForElementPresent(By.Id(HomeSelectors.PlayNowButton), 15);
            Driver.Instance.Navigate().Back();
            try
            {
                Driver.Instance.WaitForElementPresent(By.Id(UserGuidSelectors.FirstLoginInfo), 15);
                return true;
            }
            //TODO change exception type
            catch (NoSuchElementException)
            {
                LoggingHelper.LogInformation("Home screen wasn`t opened. ");
                return false;
            }
        }
    }
}