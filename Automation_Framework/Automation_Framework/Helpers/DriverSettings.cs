using Automation_Framework.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;

using OpenQA.Selenium.Safari;

namespace Automation_Framework.Helpers
{
    public class DriverSettings
    {
        public static ChromeOptions ChromeOptions(WebDriverConfiguration config)
        {
            ChromeOptions options = new ChromeOptions();

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
            FirefoxOptions options = new FirefoxOptions { AcceptInsecureCertificates = true };
            options.AddArgument("start-maximized");
            options.SetPreference("intl.accept_languages", config.BrowserLanguage);

            return options;
        }

        public static InternetExplorerOptions InternetExplorerOptions()
        {

            return new InternetExplorerOptions
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                IgnoreZoomLevel = false,

            };
        }
        public static SafariOptions SafariOptions(WebDriverConfiguration config)
        {
            SafariOptions options = new SafariOptions();


            return options;
        }
        public static EdgeOptions EdgeOptions()
        {
            EdgeOptions options = new EdgeOptions();


            options.PageLoadStrategy = PageLoadStrategy.Normal;


            return options;
        }
        public static OperaOptions OperaOptions()
        {
            OperaOptions options = new OperaOptions();
            options.AddArgument("start-maximized");

            options.PageLoadStrategy = PageLoadStrategy.Normal;


            return options;
        }


        public static AppiumOptions NativeMobileOptions(NativeMobileDriverConfiguration config)
        {
            AppiumOptions options = new AppiumOptions();

            options.AddAdditionalCapability(MobileCapabilityType.PlatformName, config.PlatformName);
            options.AddAdditionalCapability(MobileCapabilityType.AutomationName, config.AutomationName);
            options.AddAdditionalCapability(MobileCapabilityType.DeviceName, config.DeviceName);
            options.AddAdditionalCapability(MobileCapabilityType.App, config.App);
            options.AddAdditionalCapability(MobileCapabilityType.NoReset, true);
            return options;
        }

        public static AppiumOptions WebMobileOptions(WebMobileDriverConfiguration config)
        {
            AppiumOptions options = new AppiumOptions();

            options.AddAdditionalCapability(MobileCapabilityType.PlatformName, config.PlatformName);
            options.AddAdditionalCapability(MobileCapabilityType.AutomationName, config.AutomationName);
            options.AddAdditionalCapability(MobileCapabilityType.DeviceName, config.DeviceName);
            options.AddAdditionalCapability(MobileCapabilityType.BrowserName, config.BrowserName);
            return options;
        }
    }


}