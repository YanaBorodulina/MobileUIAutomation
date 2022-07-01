using SampleMobileAutomationTests.Methods;
using TechTalk.SpecFlow;

namespace SampleMobileAutomationTests.Steps
{
    [Binding]
    public class PermissionsStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly PermissionsMethods _permissionsMethods;

        public PermissionsStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _permissionsMethods = new PermissionsMethods();
        }

        [Given(@"user select location permissions ""(.*)""")]
        public void GivenUserSelectLocationPermissions(string permissionType)
        {
            _permissionsMethods.SetUpLocationPermissions(permissionType);
        }
    }
}