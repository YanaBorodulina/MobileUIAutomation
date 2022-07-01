using SampleMobileAutomationTests.Methods;
using TechTalk.SpecFlow;

namespace SampleMobileAutomationTests.Steps
{
    [Binding]
    public class DataGenerationStepsDefinition
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly DateTimeMethods _timeMethods;


        public DataGenerationStepsDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _timeMethods = new DateTimeMethods();
        }

        [Given(@"user generates the date bigger than today on ""(.*)"" ""(.*)"" and save to ""(.*)""")]
        public void GivenUserGeneratesDate(int count, string timeUnit, string key)
        {
            _scenarioContext.Add(key, _timeMethods.GenerateDate(count, timeUnit));
        }
    }
}