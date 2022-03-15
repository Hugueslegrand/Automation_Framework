using Automation_Framework.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;


namespace Automation_Framework.Helpers
{
    public class WebDriverSettings
    {
        public static ChromeOptions ChromeOptions(WebDriverConfiguration config)
        {
            var options = new ChromeOptions();
          
            options.AddExcludedArgument("enable-automation");
            options.AddArgument("--disable-save-password-bubble");
            options.AddArgument("ignore-certificate-errors");
            options.AddArgument("start-maximized");
           
            options.AddArgument($"--lang={config.BrowserLanguage}");
            options.AddUserProfilePreference("intl.accept_languages", config.BrowserLanguage);
          
            return options;
        }
        public static FirefoxOptions FirefoxOptions(WebDriverConfiguration config)
        {
            var options = new FirefoxOptions { AcceptInsecureCertificates = true };
            options.AddArgument("start-maximized");
            options.SetPreference("intl.accept_languages", config.BrowserLanguage);
            
            return options;
        }

        public static InternetExplorerOptions InternetExplorerOptions()
        {

            return new InternetExplorerOptions
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                IgnoreZoomLevel = true,
                EnsureCleanSession = true
            };
        }

        public static EdgeOptions EdgeOptions()
        {
            var options = new EdgeOptions();
            options.AddArgument("start-maximized");

            options.PageLoadStrategy = PageLoadStrategy.Normal;


            return options;
        }
        public static OperaOptions OperaOptions()
        {
            var options = new OperaOptions();
            options.AddArgument("start-maximized");

            options.PageLoadStrategy = PageLoadStrategy.Normal;


            return options;
        }
        public static AppiumOptions AndroidOptions(AndroidDriverConfiguration config)
        {
            var options = new AppiumOptions();
            options.AddAdditionalCapability(MobileCapabilityType.PlatformName, config.PlatformName);
            options.AddAdditionalCapability(MobileCapabilityType.DeviceName, config.DeviceName);
            options.AddAdditionalCapability(MobileCapabilityType.App, config.App);
            return options;
        }
    }


}