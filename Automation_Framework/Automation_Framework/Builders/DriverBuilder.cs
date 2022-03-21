using Automation_Framework.Enums;
using Automation_Framework.Helpers;
using Automation_Framework.Models;
using Automation_Framework.WebElementModels;
using LLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
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
        public AndroidDriver<AndroidElement> _androidDriver;
        public IOSDriver<IOSElement> _iosDriver;

        private WebDriverConfiguration driverConfig = Configuration.WebDriver;
        private NativeMobileDriverConfiguration nativeMobileConfig = Configuration.NativeMobileDriver;
        private WebMobileDriverConfiguration webMobileConfig = Configuration.WebMobileDriver;
        private string url = Configuration.Environment.ApplicationUrl;

        public IWebDriver BuildDriver(Enums.PlatformType platformType)
        {
            L logger = new L(directory: @"C:\LogsTest");
            switch (platformType)
            {
                case Enums.PlatformType.Desktop:
                    _webDriver = new WebDriverFactory().GetWebDriver(driverConfig, logger);

                    _webDriver.Manage().Window.Maximize();
                    _webDriver.Navigate().GoToUrl(url);

                    return _webDriver;
                  
                case Enums.PlatformType.Android:
                    _androidDriver = new WebDriverFactory().GetNativeAndroidDriver(nativeMobileConfig);

                    return _androidDriver;
                  
                case Enums.PlatformType.IOS:
                    _iosDriver = new WebDriverFactory().GetNativeIOSDriver(nativeMobileConfig);

                    return _iosDriver;
                   
                case Enums.PlatformType.WebAndroid:
                    _androidDriver = new WebDriverFactory().GetWebAndroidDriver(webMobileConfig);

                  
                    _androidDriver.Navigate().GoToUrl(url);

                    return _webDriver;
                   
                case Enums.PlatformType.WebIOS:
                    _iosDriver = new WebDriverFactory().GetWebIOSDriver(webMobileConfig);

                 
                    _iosDriver.Navigate().GoToUrl(url);

                    return _webDriver;

                default:
                    throw new ArgumentOutOfRangeException(nameof(Enums.PlatformType),
                        $"No valid PlatformType given. Platform must be of either types PlatformType.Android, PlaformType.IOS, PlatformType.WebAndroid, PlatformType.WebIOS.",
                        null);
            }     
        }
      
        public void CloseDriver(Enums.PlatformType platformType)
        {
            switch (platformType)
            {
                case Enums.PlatformType.Desktop:
                    _webDriver.Quit();
                    break;
                case Enums.PlatformType.Android:
                    _androidDriver.Quit();
                    break;
                case Enums.PlatformType.IOS:
                    _iosDriver.Quit();
                    break;
                case Enums.PlatformType.WebAndroid:
                    _androidDriver.Quit();
                    break;
                case Enums.PlatformType.WebIOS:
                    _iosDriver.Quit();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Enums.PlatformType),
                        $"No valid PlatformType given. Platform must be of either types PlatformType.Android, PlaformType.IOS, PlatformType.WebAndroid, PlatformType.WebIOS.",
                        null);
            }
        } 

        public void CloseAllDrivers()
        {
            _webDriver.Quit();
            _androidDriver.Quit();
            _iosDriver.Quit();
        }
       
    }
}
