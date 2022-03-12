using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Extensions.WebDriver
{
    public class InputField
    {
        public InputField(IWebDriver driver, IWebElement webElement)
        {
            WebElement = webElement;
            WebDriver = driver;
        }



        public InputField(IWebDriver driver, By by)
        {
            WebDriver = driver;
            WebElement = driver.FindElement(by);
        }

        private IWebElement WebElement { get; }

        private IWebDriver WebDriver { get; }

        public void SendKeys(string text)
        {
            WebDriver.SendKeys(text);
        }
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
