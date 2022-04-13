using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.Extensions.WebDriver;
using Automation_Framework.Helpers;
using LLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.WebElementModels
{

    public class WebElement : IButton, IInputField
    {
        private readonly DriverBuilder _driverBuilder;
        private  IWebElement _webElement;
        private IList<IWebElement> _webElements;
        private  IWebDriver _webDriver;

        private  AppiumDriver<AndroidElement> _androidDriver;

        public SelectElement SearchBarSelect => new SelectElement(_webElement);



        public string TagName => _webElement.TagName;

        public string Text => _webElement.Text;

        public bool Enabled => _webElement.Enabled;

        public bool Selected => _webElement.Selected;

        public bool Displayed => _webElement.Displayed;

        public WebElement(IWebDriver driver, string element, Selector selector)
        {
            _webDriver = driver;
            switch (selector)
            {
                case Selector.Name:
                    _webDriver.WaitForClickable(By.Name(element));
                    _webElement = _webDriver.FindElement(By.Name(element));
                    _webElements = _webDriver.FindElementAboveZero(By.Name(element));
                    break;
                case Selector.Id:
                    _webDriver.WaitForClickable(By.Id(element));
                    _webElement = _webDriver.FindElement(By.Id(element));
                    _webElements = _webDriver.FindElementAboveZero(By.Id(element));
                    break;
                case Selector.Css:
                    _webDriver.WaitForClickable(By.CssSelector(element));
                    _webElement = _webDriver.FindElement(By.CssSelector(element));
                    _webElements = _webDriver.FindElementAboveZero(By.CssSelector(element));
                    break;

                case Selector.Xpath:
                    _webDriver.WaitForClickable(By.XPath(element));
                    _webElement = _webDriver.FindElement(By.XPath(element));
                    _webElements = _webDriver.FindElementAboveZero(By.XPath(element));
                    break;

                case Selector.LinkText:
                    _webDriver.WaitForClickable(By.LinkText(element));
                    _webElement = _webDriver.FindElement(By.LinkText(element));
                    _webElements = _webDriver.FindElementAboveZero(By.LinkText(element));
                    break;

                case Selector.ClassName:
                    _webDriver.WaitForClickable(By.ClassName(element));
                    _webElement = _webDriver.FindElement(By.ClassName(element));
                    _webElements = _webDriver.FindElementAboveZero(By.ClassName(element));
                    break;
                case Selector.TagName:
                    _webDriver.WaitForClickable(By.TagName(element));
                    _webElement = _webDriver.FindElement(By.TagName(element));
                    _webElements = _webDriver.FindElementAboveZero(By.TagName(element));
                    break;
                default:
                    new ArgumentOutOfRangeException(nameof(Selector),
                       $"No valid SelectorType given. Selector must be of either types {Selector.LinkText}, {Selector.ClassName}, {Selector.Css}, {Selector.Id}, {Selector.Name}, {Selector.Xpath}.",
                       null);
                    break;
            }

        }

        public IWebElement getElement()
        {
            return _webElement;
        }
        public void ClickOnElement()
        {
            _webDriver.ClickOnElement(_webElement);
        }


        public IList<IWebElement> getElements()
        {
            return _webElements;
        }
        public void SendKeys(string text)
        {
            _webElement.SendKeys(text);
        }

        public string GetCssValue(string propertyName)
        {
           return _webElement.GetCssValue(propertyName);
        }

        public string GetAttribute(string attributeName)
        {
            return _webElement.GetAttribute(attributeName);
        }

        public string GetProperty(string propertyName)
        {
            return _webElement.GetProperty(propertyName);
        }

        public void ClearInput()
        {
            _webElement.Clear();
        }


     


        public void GetElementAndScrollTo()
        {
            _webDriver.GetElementAndScrollTo(_webElement);
        }


   
        public bool ElementIsVisible()
        {
            return _webElement.Displayed;
        }
    }
}
