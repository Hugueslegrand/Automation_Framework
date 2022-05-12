
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.Utilities;
using Automation_Framework.Extensions.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Automation_Framework.WebElementModels
{

    public class WebElement : IButton, IInputField, ITable, ILink, Ilabel, IParagraph
    {
        private readonly DriverBuilder _driverBuilder;
        private IWebElement _webElement;
        private IList<IWebElement> _webElements;
        private IWebDriver _webDriver;

        private AppiumDriver<AndroidElement> _androidDriver;

     

        public string TagName => _webElement.TagName;

        public string Text => _webElement.Text;

        public bool Enabled => _webElement.Enabled;

        public bool Selected => _webElement.Selected;

        public bool Displayed => _webElement.Displayed;

        public Size Size => _webElement.Size;

        public Point Location => _webElement.Location;

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


        public void OpenLinkInNewTab()
        {
            _webDriver.OpenLinkInNewTab(_webElement);
        }

        public IWebElement GetElement()
        {
            return _webElement;
        }

        public void ClickOnElement()
        {
            try
            {
                //Maybe put the scroll in screenshot extension
               // _webDriver.ExecuteJsObject("arguments[0].scrollIntoView(true);", _webElement);
                _webDriver.ClickOnElement(_webElement);
               
            }
            catch (Exception)
            {

                Log.Warn($"Failed to click on the {_webElement.TagName} `{_webElement.Text}` {_webElement}");
                throw;
            }
            

        }


        public IList<IWebElement> GetElements()
        {
            return _webElements;
        }
        public void SendKeys(string text)
        {
            try
            {
                _webElement.SendKeys(text);
            }
            catch (Exception)
            {
                Log.Warn($"Failed to send the text `{_webElement.Text}` in the {_webElement.TagName} ");
                throw;
            }
            
        }

        public string GetCssValue(string propertyName)
        {
            Log.Info($"Retrieving the css value with propertyName {propertyName}");
            return _webElement.GetCssValue(propertyName);
        }

        public string GetAttribute(string attributeName)
        {
            Log.Info($"Retrieving the attribute value with attribute name {attributeName}");
            return _webElement.GetAttribute(attributeName);
        }

        public string GetProperty(string propertyName)
        {
            Log.Info($"Retrieving the property value with propertyName {propertyName}");
            return _webElement.GetProperty(propertyName);
        }

        public void ClearInput()
        {
            try
            {
                _webElement.Clear();
                Log.Info($"Cleared the {_webElement.TagName}");
            }
            catch (Exception)
            {
                Log.Warn($"Unable to clear the {_webElement.TagName}");
                throw;
            }
            
        }

       
    }
}
