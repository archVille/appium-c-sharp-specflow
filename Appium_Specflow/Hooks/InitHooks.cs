using Appium_Specflow.Drivers;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Appium_Specflow.Hooks
{
    [Binding]
    class InitHooks
    {
        private readonly ScenarioContext _scenarioContext;

        public InitHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void Init()
        {
            AppiumDriver driver = new AppiumDriver();
            //driver.InitAppium();

            _scenarioContext.Set(driver.InitAppium());
        }
    }
}
