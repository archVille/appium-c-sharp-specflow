using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

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
            dynamic data = table.CreateDynamicInstance();

            _scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
                .FindElementByAccessibilityId("email")
                .SendKeys("myemail@test.co.uk");
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
