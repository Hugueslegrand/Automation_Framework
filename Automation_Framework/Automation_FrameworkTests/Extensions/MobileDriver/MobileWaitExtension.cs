using Automation_Framework.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Android;
using System.Threading;
using Automation_Framework.Extensions.MobileDriver;

namespace Automation_FrameworkTests.Extensions.MobileDriver
{
    [TestClass()]
    public class MobileWaitExtension
    {
        private AppiumDriver<AndroidElement> _driver;

        [SetUp]
        public void Setup()
        {
            var appPath = @"C:\\APKFiles\\B-Tube.apk";

            //Platform , Device , Application
            var driverOption = new AppiumOptions();

            driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Android 30");
            driverOption.AddAdditionalCapability(MobileCapabilityType.App, appPath);

            // driverOption.AddAdditionalCapability(); 

            _driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), driverOption);

            //_driver.FindElementByXPath("//android.widget.EditText[@content-desc=\"searchInput\"]").Click();



        }

        [Test]
        public void WaitForClickableAndroidTest()
        {
            Thread.Sleep(20000);

            AndroidElement search = _driver.FindElementByXPath("//android.widget.Button[@content-desc=\"searchTab\"]");
            _driver.WaitForClickableAndroid(search);
            search.Click();
            AndroidElement input = _driver.FindElementByXPath("//android.widget.EditText[@content-desc=\"searchInput\"]");
            _driver.WaitForClickableAndroid(input);
            input.SendKeys("a whisker away");
            AndroidElement moreInfo = _driver.FindElementByXPath("//android.view.ViewGroup[@content-desc=\"moreInfoBtn\"]/android.widget.TextView");
            _driver.WaitForClickableAndroid(moreInfo);
            moreInfo.Click();
        }

    }
}
