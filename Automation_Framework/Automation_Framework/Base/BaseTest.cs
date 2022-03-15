﻿using Automation_Framework.Helpers;
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
            var androidConfig = Configuration.AndroidDriver;
            var iosConfig = Configuration.IOSDriver;
            var url = Configuration.Environment;
           
            var logger = new L(directory: @"C:\LogsTest");
            Driver = new WebDriverFactory().GetWebDriver(driverConfig, logger);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(url.ApplicationUrl);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        protected IWebDriver Driver { get; set; }
    }

}
