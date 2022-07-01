using NUnit.Framework;
using Sample.Mobile.Core.WebDriver;
using SampleMobileAutomationTests.CommonElements;
using SampleMobileAutomationTests.Methods;
using SampleMobileAutomationTests.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SampleMobileAutomationTests.Steps
{
    [Binding]
    public class CommonStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly LoginMethods _loginMethods;
        private readonly HomeScreenMethods _homeScreenMethods;
        private readonly CommonMethods _commonMethods;
        private readonly LanguageSelector _languageSelector;

        public CommonStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _loginMethods = new LoginMethods();
            _homeScreenMethods = new HomeScreenMethods();
            _commonMethods = new CommonMethods();
            _languageSelector = new LanguageSelector();
        }

        [Given(@"user login to app with following data:")]
        public void GivenUserLoginToAppWithFollowingData(Table userData)
        {
            var user = userData.CreateInstance<LoginUserModel>();
            _loginMethods.Login(user);
        }

        [Given(@"user select app language ""(.*)""")]
        public void GivenUserSelectAppLanguage(string language)
        {
            _languageSelector.GetLanguage(language).Click();
        }

        [Given(@"user click Back button")]
        public void GivenUserClickBackButton()
        {
            Driver.Instance.Navigate().Back();
        }

        [Given(@"user click on ""(.*)"" at the bottom menu")]
        public void GivenUserClickOnAtTheBottomMenu(string menuItem)
        {
            _commonMethods.ClickOnTheBottomMenu(menuItem);
        }

        [Given(@"user enters ""(.*)"" to the ""(.*)"" field on the ""(.*)"" screen")]
        public void GivenUserEnterToTheFieldOnTheScreen(string value, string fieldName, string screenName)
        {
            _commonMethods.EnterValueToTheField(value, fieldName, screenName);
        }

        [Given(@"user clicks on the ""(.*)"" in the ""(.*)"" screen")]
        public void GivenUserClicksOnTheInTheScreen(string elementName, string screenName)
        {
            _commonMethods.ClickOnTheElement(elementName, screenName);
        }

        [Given(@"user skip user guid for ""(.*)"" screen")]
        public void GivenUserSkipUserGuidForScreen(string screenName)
        {
            _commonMethods.SkipUserGuid(screenName);
        }

        [Given(@"user receive the SMS ")]
        public void GivenUserReceiveTheSms()
        {
        }

        [Then(@"user verifies that ""(.*)"" characters are in the field ""(.*)"" on the ""(.*)"" screen")]
        public void ThenUserVerifiesThatCharactersAreInTheFieldOnTheScreen(int expectedLength, string fieldName, string screenName)
        {
            _commonMethods.VerifyFieldLength(expectedLength, fieldName, screenName);
        }

        [Then(@"user verifies that home screen opened")]
        public void ThenUserVerifiesThatHomePageOpened()
        {
            //Should be removed when last version of app will be use 
            _commonMethods.ConfirmAlert();
            Driver.Instance.Navigate().Back();
            Assert.IsTrue(_homeScreenMethods.IsHomeScreenOpened());
        }

        [Then(@"user verifies inline message ""(.*)""")]
        public void ThenUserVerifiesInlineMessage(string message)
        {
            _commonMethods.VerifyInlineMessage(message);
        }
    }
}