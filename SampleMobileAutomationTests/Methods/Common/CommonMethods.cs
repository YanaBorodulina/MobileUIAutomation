using NUnit.Framework;
using OpenQA.Selenium;
using Sample.Mobile.Core.Extensions;
using Sample.Mobile.Core.Logger;
using Sample.Mobile.Core.WebDriver;
using Sample.Mobile.Core.WebElement;
using SampleMobileAutomationTests.CommonElements;
using SampleMobileAutomationTests.Pages;

namespace SampleMobileAutomationTests.Methods
{
    public class CommonMethods
    {
        private readonly Alert _alert;
        private readonly InlineMessage _inlineMessage;
        private readonly BottomMenu _bottomMenu;
        private readonly Dialog _dialog;
        private readonly UserGuidMethods _userGuidMethods;

        public CommonMethods()
        {
            _alert = new Alert();
            _inlineMessage = new InlineMessage();
            _bottomMenu = new BottomMenu();
            _dialog = new Dialog();
            _userGuidMethods = new UserGuidMethods();
        }

        public void ConfirmAlert()
        {
            _alert.DialogOkButton.Element.Click();
        }

        public void EnterValueToTheField(string value, string fieldName, string screenName)
        {
            switch (screenName)
            {
                case "LoginScreen":
                {
                    var loginScreen = new LoginScreen();
                    var field = (CustomWebElement)loginScreen.GetType().GetProperty(fieldName).GetValue(loginScreen, null);
                    field.Element.TypeInto($" {value}");
                    break;
                }
                default:
                {
                    LoggingHelper.LogInformation($"Screen with name {screenName} not found.");
                    break;
                }
            }
        }

        public void VerifyInlineMessage(string message)
        {
            Assert.AreEqual(message, _inlineMessage.GetErrorText());
        }

        public void VerifyFieldLength(int expectedLength, string fieldName, string screenName)
        {
            switch (screenName)
            {
                case "LoginScreen":
                {
                    var loginScreen = new LoginScreen();
                    var field = (CustomWebElement)loginScreen.GetType().GetProperty(fieldName).GetValue(loginScreen, null);
                    Assert.AreEqual(expectedLength, field.Element.Text.Length);
                    break;
                }
                default:
                {
                    LoggingHelper.LogInformation($"Screen with name {screenName} not found.");
                    break;
                }
            }
        }

        public void ClickOnTheElement(string elementName, string screenName)
        {
            switch (screenName)
            {
                case "LoginScreen":
                {
                    var loginScreen = new LoginScreen();
                    var element = (CustomWebElement)loginScreen.GetType().GetProperty(elementName).GetValue(loginScreen, null);
                    element.Element.Click();
                    break;
                }
                case "SummaryScreen":
                {
                    var summaryScreen = new SummaryScreen();
                    var element = (CustomWebElement)summaryScreen.GetType().GetProperty(elementName).GetValue(summaryScreen, null);
                    element.Element.Click();
                    break;
                }
                case "PaymentScreen":
                {
                    var paymentScreen = new PaymentScreen();
                    var element = (CustomWebElement)paymentScreen.GetType().GetProperty(elementName).GetValue(paymentScreen, null);
                    element.Element.Click();
                    break;
                }
                case "RoomsScreen":
                {
                    var bookingRoomsScreen = new RoomsScreen();
                    var element = (CustomWebElement)bookingRoomsScreen.GetType().GetProperty(elementName).GetValue(bookingRoomsScreen, null);
                    element.Element.Click();
                    break;
                }
                case "YourDetailsScreen":
                {
                    var yourDetailsScreen = new YourDetailsScreen();
                    var element = (CustomWebElement)yourDetailsScreen.GetType().GetProperty(elementName).GetValue(yourDetailsScreen, null);
                    element.Element.Click();
                    break;
                }
                case "Dialog":
                {
                    var detailsScreen = new Dialog();
                    var element = (CustomWebElement)detailsScreen.GetType().GetProperty(elementName).GetValue(detailsScreen, null);
                    element.Element.Click();
                    break;
                }
                case "SearchPackageScreen":
                {
                    var searchPackageScreen = new SearchPackageScreen();
                    var element = (CustomWebElement)searchPackageScreen.GetType().GetProperty(elementName).GetValue(searchPackageScreen, null);
                    element.Element.Click();
                    break;
                }
                default:
                {
                    LoggingHelper.LogInformation($"Screen with name {screenName} not found.");
                    break;
                }
            }
        }

        public void ClickOnTheBottomMenu(string menuItem)
        {
            var item = (CustomWebElement)_bottomMenu.GetType().GetProperty(menuItem).GetValue(_bottomMenu, null);
            var isDisplayed = false;
            while (!isDisplayed)
            {
                try
                {
                    item.Element.Click();
                    isDisplayed = true;
                }
                catch (NoSuchElementException)
                {
                    try
                    {
                        _dialog.DialogButtonOk.Element.Click();
                    }
                    catch (NoSuchElementException)
                    {
                        Driver.Instance.Navigate().Back();
                    }
                }
            }
        }

        public void SkipUserGuid(string screenName)
        {
            switch (screenName)
            {
                case "Home":
                {
                    _userGuidMethods.CloseHomeScreenGuid();
                    break;
                }
                case "Rooms":
                {
                    _userGuidMethods.CloseRoomsScreenGuid();
                    break;
                }
                case "Select Room":
                {
                    _userGuidMethods.CloseSelectRoomScreenGuid();
                    break;
                }

                case "Additional Services":
                {
                    _userGuidMethods.CloseAdditionalServicesScreenGuid();
                    break;
                }
                case "Payment":
                {
                    _userGuidMethods.ClosePaymentScreenGuid();
                    break;
                }
                case "Search Package":
                {
                    _userGuidMethods.CloseSearchPackageScreenGuid();
                    break;
                }
                default:
                {
                    LoggingHelper.LogError($"{screenName} not found");
                    break;
                }
            }
        }
    }
}