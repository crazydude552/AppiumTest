using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;

namespace TestAppium
{
    public class TestWebbrowser
    {
        public AndroidDriver<AndroidElement> Driver;
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var Options = new AppiumOptions();
            Options.AddAdditionalCapability("deviceName", "Samsung Galaxy S8");
            Options.AddAdditionalCapability("platformName", "Android");
            Options.AddAdditionalCapability("chromedriverExecutable", "C:\\Users\\pathakor\\Downloads\\chromedriver_win32\\chromedriver.exe");
            Options.AddAdditionalCapability("browserName", "Chrome");
            Options.AddAdditionalCapability("automationName", "UiAutomator2");
            //Options.AddAdditionalCapability("UUID", "b7e38999-06f7-4e81-864c-0c32a9d1d0e4"); //if using cloud need to provide UUID of cloud device
            Options.AddAdditionalCapability("udid", "192.168.181.103:5555"); //if using Local need to provide udid of android device


            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), Options);

        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://applitools.com/helloworld";
            driver.FindElement(By.XPath("/html/body/div/div[3]/button")).Click();
            var val = driver.FindElement(By.XPath("/html/body/div/div[4]/p")).Text;
            Assert.That(val.Equals("You successfully clicked the button!"));
            Assert.Pass();
        }

        [TearDown]

        public void closeDriver()
        {
            driver.Quit();
        }
    }
}