using System;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using TechTalk.SpecFlow;

namespace AppiumTest.Pages
{
    [Binding]
    public class BasePage
    {
        internal AndroidDriver<AppiumWebElement> Driver;

        public BasePage(AndroidDriver<AppiumWebElement> driver)
        {
            Driver = driver;
        }
    }
}
