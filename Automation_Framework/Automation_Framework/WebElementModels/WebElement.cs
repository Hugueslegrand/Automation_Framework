﻿using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.Extensions.WebDriver;
using Automation_Framework.Helpers;
using LLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.WebElementModels
{

    public class WebElement :  IButton, IInputField
    {
        private readonly DriverBuilder _driverBuilder;
        private  IWebElement _webElement;
        private  IWebDriver _webDriver;
        private  AppiumDriver<AndroidElement> _androidDriver;
    

   
        public WebElement(IWebDriver driver, string element, Selector selector)
        {
            _webDriver = driver;
            switch (selector)
            {
                case Selector.Name:
                    _webDriver.WaitForClickable(By.Name(element));
                    _webElement = _webDriver.FindElement(By.Name(element));
                    break;
                case Selector.Id:
                    _webDriver.WaitForClickable(By.Id(element));
                    _webElement = _webDriver.FindElement(By.Id(element));
                    break;
                case Selector.Css:
                    _webDriver.WaitForClickable(By.CssSelector(element));
                    _webElement = _webDriver.FindElement(By.CssSelector(element));
                    break;

                case Selector.Xpath:
                    _webDriver.WaitForClickable(By.XPath(element));
                    _webElement = _webDriver.FindElement(By.XPath(element));
                    break;

                case Selector.LinkText:
                    _webDriver.WaitForClickable(By.LinkText(element));
                    _webElement = _webDriver.FindElement(By.LinkText(element));
                    break;
                case Selector.ClassName:
                    _webDriver.WaitForClickable(By.ClassName(element));
                    _webElement = _webDriver.FindElement(By.ClassName(element));
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

        public string GetInnerHTML()
        {
            return _webElement.Text;
        }

        public string GetAttribute(string attribute)
        {
            return _webElement.GetAttribute(attribute);
        }
        public bool ElementIsVisible()
        {
            return _webElement.Displayed;
        }

    }
}
