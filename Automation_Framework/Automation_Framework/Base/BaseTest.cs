using Automation_Framework.Helpers;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using LLibrary;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;

namespace Automation_Framework.Base
{
    [TestFixture]
    [AllureNUnit]
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            var driverConfig = Configuration.WebDriver;
            var androidConfig = Configuration.AndroidDriver;
            var iosConfig = Configuration.IOSDriver;
          
           
            var logger = new L(directory: @"C:\LogsTest");
            AndroidDriver = new WebDriverFactory().GetAndroidDriver(androidConfig);
            Driver = new WebDriverFactory().GetWebDriver(driverConfig, logger);
            Driver.Manage().Window.Maximize();
           
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
            AndroidDriver.Quit();
        }

        protected IWebDriver Driver { get; set; }
        protected AppiumDriver<AndroidElement> AndroidDriver { get; set; }
    }

}
