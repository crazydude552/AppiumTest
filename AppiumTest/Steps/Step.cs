using AppiumTest.Pages;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using TechTalk.SpecFlow;

namespace AppiumTest.Steps
{
    [Binding]
    public class Step
    {
        public AndroidDriver<AppiumWebElement> _driver;

        public Step(AndroidDriver<AppiumWebElement> driver) => _driver = driver;

        public HomePage HomePage => new HomePage(_driver);

        [Given(@"that user opens KTN web page")]
        public void GivenThatUsersOensKTNWebPage()
        {
            _driver.Navigate().GoToUrl("http://katoennatie.com");
        }

        [Then(@"user agrees to cookies")]
        public void UserAgreesToCookies()
        {
            HomePage.ClickContinuteToSiteButton();
        }

        [Then(@"user tries opens Get in touch page")]
        public void UserTriesOpensGetInTouchPage()
        {
            HomePage.ClickGetInTouchButton();
        }

        [Then(@"KTN contact page is displayed")]
        public void KTNContactPageIsDisplayed()
        {
            HomePage.ContactFormDisplayed();
        }

        [Then(@"add user details on contact form")]
        public void ThenAddUserDetailsOnContactForm()
        {
            HomePage.sendFirstName();
            HomePage.sendLastName();
        }

    }
}
