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
        public Button(IWebDriver driver,IWebElement webElement)
        {
            WebElement = webElement;
            WebDriver = driver;
        }

       
   
        public Button(IWebDriver driver,By by)
        {
            WebDriver = driver;
            WebElement = driver.FindElement(by);
        }

        private IWebElement WebElement { get; }
 
        private IWebDriver WebDriver { get; }
       
        public void ClickOnElement()
        {

            WebDriver.ClickOnElement(WebElement);
        }

      

        public bool Displayed()
        {
            return WebElement.Displayed;
        }
    }
}
