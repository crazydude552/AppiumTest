using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AppiumTest.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(AndroidDriver<AppiumWebElement> driver) : base(driver) {}

        public IWebElement ContinueToSite => Driver.FindElementByXPath("//*[@id='cookiescript_accept']");
        public IWebElement GetInTouchButton => Driver.FindElementByXPath("/html/body/div[2]/div[1]/div/div/a[2]");

        public const string ContactFormXpath = "//h1[text()='Contact form']";
        public IWebElement ContactForm => Driver.FindElementByXPath(ContactFormXpath);

        public IWebElement FirstName => Driver.FindElementByXPath("//input[@name='firstname']");

        public IWebElement LastName => Driver.FindElementByXPath("//input[@name='lastname']");

        public IWebElement KTNLogo => Driver.FindElementByClassName("logo");

        public void ClickContinuteToSiteButton()
        {
            ContinueToSite.Click();
        }
        public bool VerifyLogo()
        {
            return KTNLogo.Displayed;
        }
        public void ClickGetInTouchButton()
        {
            Thread.Sleep(5000);
            GetInTouchButton.Click();
        }
        public void ContactFormDisplayed()
        {
            Assert.That(ContactForm.Displayed);
        }

        public void sendFirstName()
        {
            FirstName.SendKeys("Ram");
        }

        public void sendLastName()
        {
            LastName.SendKeys("Pathakota");
        }
    }
}
