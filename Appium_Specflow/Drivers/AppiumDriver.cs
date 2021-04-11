using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appium_Specflow.Drivers
{
    public class AppiumDriver
    {
        public AppiumDriver<AppiumWebElement> Driver { get; set; }

        public AndroidDriver<AppiumWebElement> InitAppium()
        {
            var options = new AppiumOptions();
            options.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            options.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-name"); //TODO: this is the name of the device we are going to test
            options.AddAdditionalCapability(MobileCapabilityType.App, @"c:\demofolderForApp\");

            return new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4713/wd/hub"), options);
        }
    }
}
