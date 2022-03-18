using Automation_Framework.Enums;
using Automation_Framework.Helpers;
using Automation_Framework.WebElementModels;
using LLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Builders
{
    public class DriverBuilder
    {
        
        public IWebDriver _webDriver;
        public AppiumDriver<AndroidElement> _androidDriver;
        

        public IWebDriver BuildDesktopDriver()
        {
            var driverConfig = Configuration.WebDriver;
            var androidConfig = Configuration.AndroidDriver;
            var iosConfig = Configuration.IOSDriver;
            var url = Configuration.Environment.ApplicationUrl;

            var logger = new L(directory: @"C:\LogsTest");

            //_androidDriver = new WebDriverFactory().GetAndroidDriver(androidConfig);
            
            _webDriver = new WebDriverFactory().GetWebDriver(driverConfig, logger);
  
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(url);

            return _webDriver;
        }
      
        public void CloseDriver()
        {
            _webDriver.Quit();
        } 
        public IWebDriver GetWebDriver()
        {
            return _webDriver;
        }
    }
}
