using System.Collections.Generic;
using Sample.Mobile.Core.Logger;
using SampleMobileAutomationTests.Methods;
using SampleMobileAutomationTests.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SampleMobileAutomationTests.Steps
{
    [Binding]
    public class BookingRoomsStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly BookingRoomsMethods _bookingRoomsMethods;

        public BookingRoomsStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _bookingRoomsMethods = new BookingRoomsMethods();
        }

        [Given(@"user select check-in date ""(.*)""")]
        public void GivenUserSelectCheckInDate(string dateKey)
        {
            _bookingRoomsMethods.SelectCheckInDate(_scenarioContext[dateKey].ToString());
        }

        [Given(@"user select check-out date ""(.*)""")]
        public void GivenUserSelectCheckOutDate(string dateKey)
        {
            _bookingRoomsMethods.SelectCheckOutDate(_scenarioContext[dateKey].ToString());
        }

        [Given(@"user selects the number of rooms ""(.*)""")]
        public void GivenUserSelectsTheNumberOfRooms(int roomsNumber)
        {
            _bookingRoomsMethods.SelectNumberOfRooms(roomsNumber);
        }

        [Given(@"user selects the number of adults ""(.*)""")]
        public void GivenUserSelectsTheNumberOfAdults(int adultsNumber)
        {
            _bookingRoomsMethods.SelectNumberOfAdults(adultsNumber);
        }

        [Given(@"user selects the number of children ""(.*)""")]
        public void GivenUserSelectsTheNumberOfChildren(int childrenNumber)
        {
            _bookingRoomsMethods.SelectNumberOfChildren(childrenNumber);
        }

        [Given(@"user selects ""(.*)"" rooms")]
        public void GivenUserSelectsRooms(int numberOfRooms)
        {
            _bookingRoomsMethods.SelectRoom(numberOfRooms);
        }

        [Given(@"user fill Your details form with following data:")]
        public void GivenUserFillYourDetailsForm(Table userDetails)
        {
            _bookingRoomsMethods.FillYourDetailsForm(userDetails.CreateInstance<UserDetailsModel>());
        }

        [Given(@"user fill payment form with following data:")]
        public void GivenUserFillPaymentFormWithFollowingData(Table paymentsDetails)
        {
            _bookingRoomsMethods.FillPaymentDetails(paymentsDetails.CreateInstance<PaymentModel>());
        }

        [When(@"user search rooms and click book")]
        public void GivenUserClickBookRooms()
        {
            _bookingRoomsMethods.BookRooms();
        }

        [Then(@"user verifies rooms screen view")]
        public void ThenUserVerifiesRoomsScreenView()
        {
            _bookingRoomsMethods.VerifyScreenView();
        }

        [Then(@"user verifies Your details screen")]
        public void ThenUserVerifiesYourDetailsScreen()
        {
            _bookingRoomsMethods.VerifyYourDetailsScreen();
        }

        [Then(@"user verifies term and condition header ""(.*)""")]
        public void ThenUserVerifiesTermAndCondition(string header)
        {
            _bookingRoomsMethods.VerifyTermAndCondition(header);
        }

        [Then(@"user verifies additional services screen")]
        public void ThenUserVerifiesAdditionalServicesScreen()
        {
            _bookingRoomsMethods.VerifyAdditionalServicesScreen();
        }

        [Then(@"user ""(.*)"" additional services")]
        public void ThenUserSelectAdditionalServicesAction(string action)
        {
            _bookingRoomsMethods.SelectAdditionalServicesAction(action);
        }
        
        [Then(@"user verifies that screen title is ""(.*)""")]
        public void ThenUserVerifiesThatScreenTitleIs(string title)
        {
            _bookingRoomsMethods.VerifyThatScreenTitle(title);
        }
        
        [Then(@"user verifies confirmation message with ""(.*)""")]
        public void ThenUserVerifiesConfirmationMessageWith(string message)
        {
            _bookingRoomsMethods.VerifyConfirmationMessage(message);
        }
        
        [Then(@"user verifies error message ""(.*)""")]
        public void ThenUserVerifiesErrorMessage(string message)
        {
            _bookingRoomsMethods.VerifyErrorMessage(message);
        } 
        
        [Then(@"user verifies dialog message ""(.*)""")]
        public void ThenUserVerifiesDialogMessage(string message)
        {
            _bookingRoomsMethods.VerifyDialogMessage(message);
        }

        [Then(@"user verifies summary screen with following data:")]
        public void ThenUserVerifiesSummaryScreenWithFollowingData(Table summaryData)
        {
            var summary = summaryData.CreateInstance<SummaryModel>();
            try
            {
                summary.CheckInDate = _scenarioContext[summary.CheckInDate].ToString();
                summary.CheckOutDate = _scenarioContext[summary.CheckOutDate].ToString();
            }
            catch (KeyNotFoundException)
            {
                LoggingHelper.LogInformation("The value is taken from the feature file.");
            }

            _bookingRoomsMethods.VerifySummaryScreen(summary);
        }
    }
}