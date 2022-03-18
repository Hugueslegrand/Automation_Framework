using Automation_Framework.Enums;
using Automation_Framework.Extensions.WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.WebElementModels
{

    public class WebElement : IButton, IInputField
    {
        private readonly IWebElement _webElement;
        private readonly IWebDriver _webDriver;

        public WebElement(IWebDriver driver, string element, Selector selector)
        {
            _webDriver = driver;
            switch (selector)
            {
                case Selector.Name:
                    driver.WaitForClickable(By.Name(element));
                    _webElement = driver.FindElement(By.Name(element));
                    break;
                case Selector.Id:
                    driver.WaitForClickable(By.Id(element));
                    _webElement = driver.FindElement(By.Id(element));
                    break;
                case Selector.Css:
                    driver.WaitForClickable(By.CssSelector(element));
                    _webElement = driver.FindElement(By.CssSelector(element));
                    break;

                case Selector.Xpath:
                    driver.WaitForClickable(By.XPath(element));
                    _webElement = driver.FindElement(By.XPath(element));
                    break;

                case Selector.LinkText:
                    driver.WaitForClickable(By.LinkText(element));
                    _webElement = driver.FindElement(By.LinkText(element));
                    break;
                default:
                    break;
            }

        }

        public void ClickOnElement()
        {
            _webDriver.ClickOnElement(_webElement);
        }

      

        public void SendKeys(string text)
        {
            _webElement.SendKeys(text);
        }
    }
}
