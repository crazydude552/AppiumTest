using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;

namespace TestAppium
{
    public class TestCalculator
    {
        public AndroidDriver<AndroidElement> Driver;
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var Options = new AppiumOptions();
            Options.AddAdditionalCapability("deviceName", "Samsung Galaxy S8");
            Options.AddAdditionalCapability("platformName", "Android");
            Options.AddAdditionalCapability("appPackage", "com.google.android.calculator");
            Options.AddAdditionalCapability("appActivity", "com.android.calculator2.Calculator");

            //Options.AddAdditionalCapability("UUID", "b7e38999-06f7-4e81-864c-0c32a9d1d0e4"); //if using cloud need to provide UUID of cloud device
            Options.AddAdditionalCapability("udid", "192.168.181.103:5555"); //if using Local need to provide udid of android device

            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), Options);

        }

        [Test]
        public void Test2()
        {

            driver.FindElement(
                    By.XPath("//android.widget.ImageButton[@content-desc=\"7\"]"))
                    .Click();
            Thread.Sleep(2000);
            driver.FindElement(
                    By.Id("com.google.android.calculator:id/op_add"))
                    .Click();
            Thread.Sleep(2000);
            driver.FindElement(
                    By.XPath("//android.widget.ImageButton[@content-desc=\"8\"]"))
                    .Click();
            driver.FindElement(
                    By.XPath("//android.widget.ImageButton[@content-desc=\"equals\"]"))
                    .Click();

        }

        [TearDown]

        public void closeDriver()
        {
            driver.Quit();
        }
    }
}