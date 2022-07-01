using OpenQA.Selenium;
using Sample.Mobile.Core.Logger;
using Sample.Mobile.Core.WebDriver;
using SampleMobileAutomationTests.CommonElements;

namespace SampleMobileAutomationTests.Methods
{
    public class UserGuidMethods
    {
        private readonly UserGuid _userGuid;

        public UserGuidMethods()
        {
            _userGuid = new UserGuid();
        }

        public void CloseHomeScreenGuid()
        {
            try
            {
                if (_userGuid.FirstLoginInfo.Element.Displayed)
                {
                    Driver.Instance.Navigate().Back();
                }
            }
            catch (NoSuchElementException)
            {
                LoggingHelper.LogInformation("There is no user guid for first login.");
            }
        }
        
        public void CloseSearchPackageScreenGuid()
        {
            try
            {
                if (_userGuid.SearchPackageScreenInfo.Element.Displayed)
                {
                    Driver.Instance.Navigate().Back();
                }
            }
            catch (NoSuchElementException)
            {
                LoggingHelper.LogInformation("There is no user guid for search package screen.");
            }
        }

        public void CloseRoomsScreenGuid()
        {
            try
            {
                if (_userGuid.RoomsScreenInfo.Element.Displayed)
                    Driver.Instance.Navigate().Back();
            }
            catch (NoSuchElementException)
            {
                LoggingHelper.LogInformation("User guid for rooms screen was not displayed.");
            }
        }

        public void CloseSelectRoomScreenGuid()
        {
            try
            {
                if (_userGuid.SelectRoomsScreenInfo.Element.Displayed)
                    Driver.Instance.Navigate().Back();
            }
            catch (NoSuchElementException)
            {
                LoggingHelper.LogInformation("User guid for select room screen was not displayed.");
            }
        }
        
        public void CloseSearchRoomScreenGuid()
        {
            try
            {
                if (_userGuid.SearchRoomsScreenInfo.Element.Displayed)
                    Driver.Instance.Navigate().Back();
            }
            catch (NoSuchElementException)
            {
                LoggingHelper.LogInformation("User guid for select room screen was not displayed.");
            }
        }

        public void CloseAdditionalServicesScreenGuid()
        {
            try
            {
                if (_userGuid.AdditionalServicesScreenInfo.Element.Displayed)
                    Driver.Instance.Navigate().Back();
            }
            catch (NoSuchElementException)
            {
                LoggingHelper.LogInformation("User guid for additional services screen was not displayed.");
            }
        }

        public void ClosePaymentScreenGuid()
        {
            try
            {
                if (_userGuid.PaymentMethodsScreenInfo.Element.Displayed)
                    Driver.Instance.Navigate().Back();
            }
            catch (NoSuchElementException)
            {
                LoggingHelper.LogInformation("User guid for payment screen was not displayed.");
            }
        }
    }
}