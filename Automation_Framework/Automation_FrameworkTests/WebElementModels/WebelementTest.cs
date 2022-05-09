/*using Microsoft.VisualStudio.TestTools.UnitTesting;
using Automation_Framework.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Moq;
using NUnit.Framework;
using Automation_Framework.Extensions.WebDriver;
using FluentAssertions;
using OpenQA.Selenium.Support.UI;

namespace Automation_FrameworkTests.WebElementModels
{
    
    [TestClass()]
    public class WebelementTest
    {
  
        private IList<IWebElement> _webElements;


        [TestMethod()]
        public void getElementTest()
        {
            DriverBuilder driverBuilder = new DriverBuilder();
            driverBuilder.BuildDriver(Automation_Framework.Enums.PlatformType.Desktop);
            var runningDriver = driverBuilder._webDriver;
            IWebElement loginElement = runningDriver.FindElement(By.XPath("//button[@id='SignInButton']"));

            WebDriverWait waitFunc = new WebDriverWait(runningDriver, TimeSpan.FromSeconds(100));
            waitFunc.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@id='SignInButton']")));

            loginElement.Should();

            driverBuilder.CloseDriver(Automation_Framework.Enums.PlatformType.Desktop);
        }


        [TestMethod()]
        public void getElementsTest()
        {
            DriverBuilder driverBuilder = new DriverBuilder();
            driverBuilder.BuildDriver(Automation_Framework.Enums.PlatformType.Desktop);
            var runningDriver = driverBuilder._webDriver;

            IWebElement loginElement = runningDriver.FindElement(By.XPath("//button[@id='SignInButton']"));
            IWebElement SignInEmail = runningDriver.FindElement(By.XPath("//input[@id='SignInEmail']"));
            IWebElement SignInPassword = runningDriver.FindElement(By.XPath("//input[@id='SignInPassword']"));
            IWebElement SignInButtonComplete = runningDriver.FindElement(By.XPath("//button[@id='SignInButtonComplete']"));

            WebDriverWait waitFunc = new WebDriverWait(runningDriver, TimeSpan.FromSeconds(100));
            waitFunc.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@id='SignInButton']")));


            loginElement.Click();


            waitFunc.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("css-12m1kat")));

          
            _webElements = runningDriver.FindElementAboveZero(By.ClassName("css-12m1kat"));
        }

        [TestMethod()]
        public void ClickOnElementTest()
        {

        }

        [TestMethod()]
        public void GetCssValueTest()
        {

        }

        [TestMethod()]
        public void GetAttributeTest()
        {

        }

        [TestMethod()]
        public void GetPropertyTest()
        {

        }

        [TestMethod()]
        public void ClearInputTest()
        {

        }
    }
}
*/