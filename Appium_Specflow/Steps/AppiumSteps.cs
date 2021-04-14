using TechTalk.SpecFlow;

namespace Appium_Specflow.Steps
{
    [Binding]
    public sealed class AppiumSteps
    {

        private readonly ScenarioContext _scenarioContext;

        public AppiumSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I enter email and password")]
        public void EnterEmailAndPassword(Table table)
        {
        }

        [Given(@"I select the currency drop down")]
        public void SelectTheCurrencyDropDown()
        {
        }

        [Then(@"I verify the currency type")]
        public void VerifyTheCurrencyType()
        {
        }

    }
}
