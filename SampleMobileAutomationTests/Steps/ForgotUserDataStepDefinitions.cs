using SampleMobileAutomationTests.Methods;
using TechTalk.SpecFlow;

namespace SampleMobileAutomationTests.Steps
{
    [Binding]
    public class ForgotUserDataStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly ForgotUserDataMethods _forgotUserDataMethods;

        public ForgotUserDataStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _forgotUserDataMethods = new ForgotUserDataMethods();
        }
        
        [Then(@"user verifies Account retrieval screen")]
        public void ThenUserVerifiesAccountRetrievalScreen()
        {
            _forgotUserDataMethods.VerifyAccountRetrievalScreen();
        }
        
        [Then(@"user verifies Pin reset screen")]
        public void ThenUserVerifiesPinResetScreen()
        {
            _forgotUserDataMethods.VerifyPinResetScreen();
        }
    }
}