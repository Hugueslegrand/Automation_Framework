using System;
using Automation_Framework.Models;
using LLibrary;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
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
                    var chromeDriver = new ChromeDriver(WebDriverSettings.ChromeOptions(driverConfig));
                    return new WebDriverListener(chromeDriver, logger);
                case BrowserName.Firefox:
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    var firefoxDriver = new FirefoxDriver(WebDriverSettings.FirefoxOptions(driverConfig));
                    return new WebDriverListener(firefoxDriver, logger);
                case BrowserName.InternetExplorer:
                    new DriverManager().SetUpDriver(new InternetExplorerConfig());
                    var ieDriver = new InternetExplorerDriver(WebDriverSettings.InternetExplorerOptions());
                    return new WebDriverListener(ieDriver, logger);
                case BrowserName.Edge:
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    var edgeDriver = new EdgeDriver(WebDriverSettings.EdgeOptions());
                    return new WebDriverListener(edgeDriver, logger);
                case BrowserName.Opera:
                    new DriverManager().SetUpDriver(new OperaConfig());
                    var operaDriver = new OperaDriver(WebDriverSettings.OperaOptions());
                    return new WebDriverListener(operaDriver, logger);
                default:
                    throw new ArgumentOutOfRangeException(nameof(Configuration.WebDriver.BrowserName),
                        Configuration.WebDriver.BrowserName,
                        null);
            }
        }
        public AndroidDriver<AndroidElement> GetAndroidDriver (AndroidDriverConfiguration driverconfig, L logger)
        {
          
            var androidDriver = new AndroidDriver<AndroidElement>(WebDriverSettings.AndroidOptions(driverconfig));
            return androidDriver;
        }
    }
}
