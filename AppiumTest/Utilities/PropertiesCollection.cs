using BoDi;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Policy;
using TechTalk.SpecFlow;


namespace AppiumTest.Utilities
{
    [Binding]
    public class PropertiesCollection
    {
        public AndroidDriver<AppiumWebElement> Driver;

        private IObjectContainer _objectContainer;

        public PropertiesCollection(IObjectContainer objectcontainer)
        {
            _objectContainer = objectcontainer;
        }

        [BeforeScenario]
        public void DriverSetup()
        {
            DriverSetupAppium();
        }

        public void DriverSetupAppium()
        {
            var Options = new AppiumOptions();
            Options.AddAdditionalCapability("deviceName", "Samsung Galaxy S8");
            Options.AddAdditionalCapability("chromedriverExecutable", "C:\\Users\\pathakor\\Downloads\\chromedriver_win32\\chromedriver.exe");
            Options.AddAdditionalCapability("browserName", "Chrome");
            Options.AddAdditionalCapability("automationName", "UiAutomator2");
            Options.AddAdditionalCapability("udid", "192.168.181.103:5555"); //if using Local need to provide udid of android device
            //Options.AddAdditionalCapability("UUID", "b7e38999-06f7-4e81-864c-0c32a9d1d0e4"); //if using cloud need to provide UUID of cloud device
            Options.AddAdditionalCapability("NoReset", "true");
            Options.AddAdditionalCapability("FullReset", "false");

            Driver = new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), Options); 
            _objectContainer.RegisterInstanceAs(Driver);
        }

        [AfterScenario]
        public void DisposeDriverAfterScenario()
        {
            Driver.Quit();
        }
    }
}
