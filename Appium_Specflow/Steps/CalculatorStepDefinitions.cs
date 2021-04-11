using TechTalk.SpecFlow;

namespace Appium_Specflow.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I enter email and password")]
        public void GivenIEnterEmailAndPassword(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I select the currency drop down")]
        public void GivenISelectTheCurrencyDropDown()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I verify the currency type")]
        public void ThenIVerifyTheCurrencyType()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
