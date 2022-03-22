using System;
using Automation_Framework.Models;
using LLibrary;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace Automation_Framework.Helpers
{
    public class WebDriverFactory
    {
        public WebDriverListener GetWebDriver(WebDriverConfiguration driverConfig, L logger )
        { 

            switch (driverConfig.BrowserName)
            {
                case BrowserName.Chrome:
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    ChromeDriver chromeDriver = new ChromeDriver(WebDriverSettings.ChromeOptions(driverConfig));
                    return new WebDriverListener(chromeDriver, logger);
                case BrowserName.Firefox:
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    FirefoxDriver firefoxDriver = new FirefoxDriver();
                    return new WebDriverListener(firefoxDriver, logger);
               case BrowserName.InternetExplorer:
                   new DriverManager().SetUpDriver(new InternetExplorerConfig());
                    InternetExplorerDriver ieDriver = new InternetExplorerDriver(WebDriverSettings.InternetExplorerOptions());
                    return new WebDriverListener(ieDriver, logger);
                case BrowserName.Edge: 
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    EdgeDriver edgeDriver = new EdgeDriver(@"C:\Webdrivers");
                    return new WebDriverListener(edgeDriver, logger);
                case BrowserName.Opera:
                    new DriverManager().SetUpDriver(new OperaConfig());
                    OperaDriver operaDriver = new OperaDriver(WebDriverSettings.OperaOptions());
                    return new WebDriverListener(operaDriver, logger);
                case BrowserName.Safari:
                    
                    SafariDriver safariDriver = new SafariDriver(WebDriverSettings.SafariOptions(driverConfig));
                    return new WebDriverListener(safariDriver, logger);
                default:
                    throw new ArgumentOutOfRangeException(nameof(Configuration.WebDriver.BrowserName),
                        Configuration.WebDriver.BrowserName,
                        null);
            }
           
        }
       public AndroidDriver<AndroidElement> GetNativeAndroidDriver (NativeMobileDriverConfiguration driverConfig)
        {

            AndroidDriver<AndroidElement> androidDriver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), WebDriverSettings.NativeMobileOptions(driverConfig));
            return androidDriver;
        }
        public IOSDriver<IOSElement> GetNativeIOSDriver (NativeMobileDriverConfiguration driverConfig)
        {
            IOSDriver<IOSElement> iosDriver = new IOSDriver<IOSElement>(new Uri("http://localhost:4723/wd/hub"), WebDriverSettings.NativeMobileOptions(driverConfig));
            return iosDriver;
        }

        public AndroidDriver<AndroidElement> GetWebAndroidDriver(WebMobileDriverConfiguration driverConfig)
        {

            AndroidDriver<AndroidElement> androidDriver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), WebDriverSettings.WebMobileOptions(driverConfig));
            return androidDriver;
        }

        public IOSDriver<IOSElement> GetWebIOSDriver(WebMobileDriverConfiguration driverConfig)
        {
            IOSDriver<IOSElement> iosDriver = new IOSDriver<IOSElement>(new Uri("http://localhost:4723/wd/hub"), WebDriverSettings.WebMobileOptions(driverConfig));
            return iosDriver;
        }

    }
}
