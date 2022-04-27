using System;
using Automation_Framework.Models;
using LLibrary;

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
    /// <summary>
    /// A helper class for creating WebDriver for various browsers, native- and webAndroidDriver and native- and webiOSDriver
    /// </summary>
    public class DriverFactory
    {
        /// <summary>
        /// Initializes WebDriver based on the given WebBrowser name.
        /// </summary>
        /// <param name="driverConfig">Contains configuration for creating a WebDriver instance</param>
        /// <param name="logger">LLibrary class for logging actions made on the web driver</param>
        /// <returns>Returns a WebDriverListener which initializes and logs actions on the WebDriver based on the given browser name</returns>
        public DriverListener GetWebDriver(WebDriverConfiguration driverConfig, L logger)
        {

            switch (driverConfig.BrowserName)
            {
                case BrowserName.Chrome:
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    ChromeDriver chromeDriver = new ChromeDriver(DriverSettings.ChromeOptions(driverConfig));
                    return new DriverListener(chromeDriver, logger);
                case BrowserName.Firefox:
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    FirefoxDriver firefoxDriver = new FirefoxDriver();
                    return new DriverListener(firefoxDriver, logger);
                case BrowserName.InternetExplorer:
                    new DriverManager().SetUpDriver(new InternetExplorerConfig());
                    InternetExplorerDriver ieDriver = new InternetExplorerDriver(DriverSettings.InternetExplorerOptions());
                    return new DriverListener(ieDriver, logger);
                case BrowserName.Edge:
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    EdgeDriver edgeDriver = new EdgeDriver(@"C:\Webdrivers");
                    return new DriverListener(edgeDriver, logger);
                case BrowserName.Opera:
                    new DriverManager().SetUpDriver(new OperaConfig());
                    OperaDriver operaDriver = new OperaDriver(DriverSettings.OperaOptions());
                    return new DriverListener(operaDriver, logger);
                case BrowserName.Safari:
                    new DriverManager().SetUpDriver(new OperaConfig());
                    SafariDriver safariDriver = new SafariDriver(DriverSettings.SafariOptions(driverConfig));
                    return new DriverListener(safariDriver, logger);
                default:
                    throw new ArgumentOutOfRangeException(nameof(Configuration.WebDriver.BrowserName),
                        Configuration.WebDriver.BrowserName,
                        null);
            }

        }

        /// <summary>
        /// Initializes an androidDriver
        /// </summary>
        /// <param name="driverConfig">Contains model for native mobile driver configuration</param>
        /// <returns>Returns a new AndroidDriver with native options</returns>
        public AndroidDriver<AndroidElement> GetNativeAndroidDriver(NativeMobileDriverConfiguration driverConfig)
        {

            AndroidDriver<AndroidElement> androidDriver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), DriverSettings.NativeMobileOptions(driverConfig));
            return androidDriver;
        }

        /// <summary>
        /// Initializes an IOSDriver
        /// </summary>
        /// <param name="driverConfig">Contains model for native mobile driver configuration</param>
        /// <returns>Returns a new IOSDriver with native options</returns>
        public IOSDriver<IOSElement> GetNativeIOSDriver(NativeMobileDriverConfiguration driverConfig)
        {
            IOSDriver<IOSElement> iosDriver = new IOSDriver<IOSElement>(new Uri("http://localhost:4723/wd/hub"), DriverSettings.NativeMobileOptions(driverConfig));
            return iosDriver;
        }

        /// <summary>
        /// Initializes an androidDriver
        /// </summary>
        /// <param name="driverConfig">Contains model for native mobile driver configuration</param>
        /// <returns>Returns a new AndroidDriver with web browser options</returns>
        public AndroidDriver<AndroidElement> GetWebAndroidDriver(WebMobileDriverConfiguration driverConfig)
        {

            AndroidDriver<AndroidElement> androidDriver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), DriverSettings.WebMobileOptions(driverConfig));
            return androidDriver;
        }

        /// <summary>
        /// Initializes an IOSDriver
        /// </summary>
        /// <param name="driverConfig">Contains model for native mobile driver configuration</param>
        /// <returns>Returns a new IOSDriver with web browser options</returns>
        public IOSDriver<IOSElement> GetWebIOSDriver(WebMobileDriverConfiguration driverConfig)
        {
            IOSDriver<IOSElement> iosDriver = new IOSDriver<IOSElement>(new Uri("http://localhost:4723/wd/hub"), DriverSettings.WebMobileOptions(driverConfig));
            return iosDriver;
        }

    }
}
