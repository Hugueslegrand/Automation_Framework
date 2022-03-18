

//Can be deleted

/*using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Extensions.WebDriver
{
    public class InputField
    {
        private readonly IWebElement _webElement;
        private readonly IWebDriver _webDriver;
        public InputField(IWebDriver driver, IWebElement webElement)
        {
            _webElement = webElement;
            _webDriver = driver;
        }



        public InputField(IWebDriver driver, By by)
        {
            _webDriver = driver;
            _webElement = driver.FindElement(by);
        }

        



        public void SendKeys(string text)
        {
            _webElement.SendKeys(text);
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
*/