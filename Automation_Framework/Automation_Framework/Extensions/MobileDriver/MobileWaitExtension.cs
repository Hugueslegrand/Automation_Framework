using Automation_Framework.Helpers;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Extensions.MobileDriver
{
    public static class MobileWaitExtension
    {
        public static WebDriverWait AndroidWait(this AppiumDriver<AndroidElement> driver)
        {
            return new WebDriverWait(driver,
                TimeSpan.FromSeconds(Configuration.NativeMobileDriver.DefaultTimeout));
        }
        public static WebDriverWait IOSWait(this AppiumDriver<IOSElement> driver)
        {
            return new WebDriverWait(driver,
                TimeSpan.FromSeconds(Configuration.NativeMobileDriver.DefaultTimeout));
        }
        public static void WaitForClickableIOS(this AppiumDriver<IOSElement> driver, IOSElement element)
        {
           
            driver.IOSWait().Until(ExpectedConditions.ElementToBeClickable(element));

        }

        public static void WaitForClickableAndroid(this AppiumDriver<AndroidElement> driver, AndroidElement element)
        {
         
            driver.AndroidWait().Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
