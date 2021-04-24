using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
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

            var appiumService = new AppiumServiceBuilder()
                .WithIPAddress("127.0.0.1")
                //.UsingPort(4723)
                .UsingAnyFreePort()
                .Build();

            appiumService.Start();

            //return new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4713/wd/hub"), options);
            return new AndroidDriver<AppiumWebElement>(appiumService, options);
        }
    }
}
