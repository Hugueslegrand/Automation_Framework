using Automation_Framework.Helpers;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using LLibrary;

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
            var logger = new L();
            Driver = new WebDriverFactory().GetWebDriver(driverConfig, logger);
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        protected IWebDriver Driver { get; set; }
    }

}
