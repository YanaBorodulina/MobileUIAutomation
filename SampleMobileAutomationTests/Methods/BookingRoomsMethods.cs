using System;
using System.Globalization;
using NUnit.Framework;
using OpenQA.Selenium;
using Sample.Mobile.Core.Extensions;
using Sample.Mobile.Core.Logger;
using Sample.Mobile.Core.WebDriver;
using SampleMobileAutomationTests.Enums;
using SampleMobileAutomationTests.Models;
using SampleMobileAutomationTests.Pages;

namespace SampleMobileAutomationTests.Methods
{
    public class BookingRoomsMethods
    {
        private readonly RoomsScreen _roomsScreen;
        private readonly Dialog _dialog;
        private readonly SearchRoomScreen _searchRoomScreen;
        private readonly YourDetailsScreen _yourDetailsScreen;
        private readonly AdditionalServicesScreen _additionalServicesScreen;
        private readonly TermAndConditions _termAndConditions;
        private readonly PaymentScreen _paymentScreen;
        private readonly SummaryScreen _summaryScreen;
        private readonly BookingConfirmationScreen _bookingConfirmationScreen;
        private readonly SearchPackageScreen _searchPackageScreen;
        private readonly UserGuidMethods _guid;

        public BookingRoomsMethods()
        {
            _roomsScreen = new RoomsScreen();
            _dialog = new Dialog();
            _searchRoomScreen = new SearchRoomScreen();
            _yourDetailsScreen = new YourDetailsScreen();
            _additionalServicesScreen = new AdditionalServicesScreen();
            _termAndConditions = new TermAndConditions();
            _paymentScreen = new PaymentScreen();
            _summaryScreen = new SummaryScreen();
            _bookingConfirmationScreen = new BookingConfirmationScreen();
            _searchPackageScreen = new SearchPackageScreen();
            _guid = new UserGuidMethods();
        }

        public void SelectCheckInDate(string date)
        {
            _roomsScreen.CheckInFiled.Element.Click();
            SelectDate(date);
        }

        public void SelectCheckOutDate(string date)
        {
            _roomsScreen.CheckOutFiled.Element.Click();
            SelectDate(date);
        }


        public void SelectNumberOfRooms(int roomsNumber)
        {
            _roomsScreen.RoomsFiled.Element.Click();
            SelectNumber(roomsNumber);
        }

        public void SelectNumberOfAdults(int adultsNumber)
        {
            _roomsScreen.AdultsFiled.Element.Click();
            SelectNumber(adultsNumber);
        }

        public void SelectNumberOfChildren(int childrenNumber)
        {
            _roomsScreen.ChildrenFiled.Element.Click();
            SelectNumber(childrenNumber);
        }

        public void SelectRoom(int numberOfSelectedRooms)
        {
            _roomsScreen.SearchRoomsButton.Element.Click();
            _guid.CloseSelectRoomScreenGuid();
            var isAllRoomsSelected = false;
            do
            {
                _searchRoomScreen.SelectRoomButton.Element.Click();
                if (numberOfSelectedRooms == int.Parse(_roomsScreen.NumberOfSelectedRooms.Element.Text))
                    isAllRoomsSelected = true;
            } while (!isAllRoomsSelected);
        }

        public void SelectAdditionalServicesAction(string action)
        {
            switch (action.ToLower())
            {
                case "skip":
                {
                    _additionalServicesScreen.SkipButton.Element.Click();
                    break;
                }
                case "add":
                {
                    _additionalServicesScreen.AddButton.Element.Click();
                    break;
                }
                default:
                {
                    LoggingHelper.LogError($"Action {action} is not supported.");
                    break;
                }
            }
        }

        public void BookRooms()
        {
            _guid.CloseSearchRoomScreenGuid();
            var numberOfRooms = int.Parse(_roomsScreen.RoomsFiled.Element.Text);
            if (numberOfRooms > 1)
            {
                SelectRoom(numberOfRooms);
                _searchRoomScreen.BookNowButton.Element.Click();
            }
            else
            {
                _roomsScreen.SearchRoomsButton.Element.Click();
                _guid.CloseSelectRoomScreenGuid();
                _searchRoomScreen.BookButton.Element.Click();
            }
        }


        public void FillYourDetailsForm(UserDetailsModel detailsModel)
        {
            _yourDetailsScreen.EmailField.Element.TypeInto(detailsModel.Email);
            _yourDetailsScreen.PhoneNumberField.Element.TypeInto(detailsModel.PhoneNumber);
            _yourDetailsScreen.CountryOfResidenceDropDown.DropDownElement.Click();
            _yourDetailsScreen.CountryOfResidenceDropDown.GetDropDownValue(detailsModel.CountryOfResidence);
            _yourDetailsScreen.ProceedButton.Element.Click();
        }

        public void FillPaymentDetails(PaymentModel paymentModel)
        {
            Driver.Instance.Swipe(100, 300, 100, 1500);
            _paymentScreen.CardNumberFiled.Element.TypeInto(paymentModel.CardNumber);
            _paymentScreen.NameOnCardField.Element.TypeInto(paymentModel.NameOnCard);
            _paymentScreen.ExpirationMonthDropDown.DropDownElement.Click();
            _paymentScreen.ExpirationMonthDropDown.GetDropDownValue(paymentModel.ExpirationMonth).Click();
            _paymentScreen.ExpirationYearDropDown.DropDownElement.Click();
            _paymentScreen.ExpirationYearDropDown.GetDropDownValue(paymentModel.ExpirationYear).Click();
            Driver.Instance.Swipe();
            _paymentScreen.BillingAddressField.Element.TypeInto(paymentModel.BillingAddress);
            _paymentScreen.CityField.Element.TypeInto(paymentModel.City);
            _paymentScreen.StateProvinceField.Element.TypeInto(paymentModel.StateProvince);
            _paymentScreen.PostalZipCodeField.Element.TypeInto(paymentModel.PostalZipCode);
            _paymentScreen.CompleteReservationButton.Element.Click();
        }

        public void VerifyYourDetailsScreen()
        {
            Assert.IsTrue(_yourDetailsScreen.EmailField.Element.Displayed);
            Assert.IsTrue(_yourDetailsScreen.ProceedButton.Element.Displayed);
            Assert.IsTrue(_yourDetailsScreen.FirstNameField.Element.Displayed);
            Assert.IsTrue(_yourDetailsScreen.LastNameField.Element.Displayed);
            Assert.IsTrue(_yourDetailsScreen.PhoneNumberField.Element.Displayed);
            Assert.IsTrue(_yourDetailsScreen.TitleDropDown.DropDownElement.Displayed);
            Assert.IsTrue(_yourDetailsScreen.CountryOfResidenceDropDown.DropDownElement.Displayed);
        }

        public void VerifyScreenView()
        {
            Assert.IsTrue(_roomsScreen.CheckInFiled.Element.Displayed);
            Assert.IsTrue(_roomsScreen.CheckOutFiled.Element.Displayed);
            Assert.IsTrue(_roomsScreen.RoomsFiled.Element.Displayed);
            Assert.IsTrue(_roomsScreen.AdultsFiled.Element.Displayed);
            Assert.IsTrue(_roomsScreen.ChildrenFiled.Element.Displayed);
            Assert.IsTrue(_roomsScreen.SelectRatePreferenceFiled.Element.Displayed);
            Assert.IsTrue(_roomsScreen.EnterCodeFiled.Element.Displayed);
            Assert.IsTrue(_roomsScreen.SearchPackagesButton.Element.Displayed);
            Assert.IsTrue(_roomsScreen.SearchRoomsButton.Element.Displayed);
            Assert.IsTrue(_roomsScreen.ViewMyBookingHistoryButton.Element.Displayed);
        }

        public void VerifyTermAndCondition(string header)
        {
            Assert.IsTrue(_termAndConditions.GetHeader(header).Displayed);
            _termAndConditions.XButton.Element.Click();
        }

        public void VerifyAdditionalServicesScreen()
        {
            _guid.CloseAdditionalServicesScreenGuid();
            Assert.IsTrue(_additionalServicesScreen.AdditionalServicesHeader.Element.Displayed);
            Assert.IsTrue(_additionalServicesScreen.AddButton.Element.Displayed);
            Assert.IsTrue(_additionalServicesScreen.SkipButton.Element.Displayed);
        }

        public void VerifySummaryScreen(SummaryModel summary)
        {
            var checkInOutDates = _summaryScreen.CheckInOutDate.Element.Text.Split('-');
            var expectedCheckInData = DateTime.ParseExact(summary.CheckInDate, "MMMM/d/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
            var expectedCheckOutData = DateTime.ParseExact(summary.CheckOutDate, "MMMM/d/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
            var numberOfGuests = _summaryScreen.NumberOfGuests.Element.Text.Split(',');
            Assert.AreEqual(expectedCheckInData, checkInOutDates[0].Split(' ')[3]);
            Assert.AreEqual(expectedCheckOutData, checkInOutDates[1].Trim());
            Assert.IsTrue(numberOfGuests[0].Contains(summary.Adults), $"Incorrect number of adults. Expected {summary.Adults}, but was {numberOfGuests[0]}");
            Assert.IsTrue(numberOfGuests[1].Contains(summary.Children), $"Incorrect number of children. Expected {summary.Children}, but was {numberOfGuests[1]}");
        }

        public void VerifyConfirmationMessage(string message)
        {
            var actualMessage = _bookingConfirmationScreen.UserMessage.Element.Text;
            Assert.IsTrue(_bookingConfirmationScreen.ImageOk.Element.Displayed);
            Assert.IsTrue(actualMessage.Contains(message), "Incorrect confirmation message.");
            _bookingConfirmationScreen.YesButton.Element.Click();
        }

        public void VerifyErrorMessage(string message)
        {
            Assert.AreEqual(message, _dialog.ErrorMessage.Element.Text);
            try
            {
                _dialog.DialogButtonOk.Element.Click();
            }
            catch (NoSuchElementException)
            {
                LoggingHelper.LogInformation("Inline message appeared.");
            }
        }

        public void VerifyDialogMessage(string message)
        {
            Driver.Instance.WaitForElementPresent(By.Id(DialogSelectors.DialogMessage), 30);
            Assert.AreEqual(message, _dialog.DialogMessage.Element.Text);
        }

        public void VerifyThatScreenTitle(string title)
        {
            var actualTitle = _searchPackageScreen.Title.Element.Text;
            Assert.AreEqual(title, actualTitle);
        }

        private void SelectNumber(int itemsNumber)
        {
            var isCorrectNumber = false;
            var i = 0;
            do
            {
                if (int.Parse(_dialog.DialogNumberOfSelectedItems.Element.Text) != itemsNumber)
                {
                    _dialog.DialogButtonAdd.Element.Click();
                }

                i++;
                if (i == itemsNumber)
                {
                    isCorrectNumber = true;
                }
            } while (!isCorrectNumber);
        }

        private void SelectDate(string date)
        {
            var dateArray = date.Split('/');
            var isCorrectDate = false;
            do
            {
                if (_roomsScreen.MonthName.Element.Text.Contains(dateArray[(int)DateEnum.Year]) && _roomsScreen.MonthName.Element.Text.Contains(dateArray[(int)DateEnum.Month]))
                {
                    _roomsScreen.GetDay(dateArray[(int)DateEnum.Day]).Click();
                    isCorrectDate = true;
                }
                else
                {
                    _roomsScreen.NextMonth.Element.Click();
                }
            } while (!isCorrectDate);
        }
    }
}