using Automation_Framework.Base;
using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Tests
{
    public class TestLogin:BaseTest
    {
        [Test]
        [Description("Login as administrator")]
        public void Test_LoginAsAdmin_POM()
        {
            Navigation navigation = new Navigation(Driver);
            navigation.surfToUrl();
          DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(Driver);
          fluentWait.Timeout = TimeSpan.FromSeconds(30);
          fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
          IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.XPath("//button[@id='SignInButton']")));
            //Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.Login("brent.dar@ap.be", "hond");

        }
    }
}
