using Automation_Framework.Helpers;
using Automation_Framework.Base;
using LLibrary;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Extensions.WebDriver
{
    public class Button
    {
        private readonly IWebElement _webElement;
        private readonly IWebDriver _webDriver;
        public Button(IWebDriver driver,IWebElement webElement)
        {
           _webElement = webElement;
           _webDriver = driver;
        }

        public Button(IWebDriver driver,By by)
        {
            _webDriver = driver;
            driver.WaitForClickable(by);
            _webElement = driver.FindElement(by);
        }


       
        public void ClickOnElement()
        {
            _webDriver.ClickOnElement(_webElement);
        }

      

        public bool Displayed()
        {
            return _webElement.Displayed;
        }
    }
}
