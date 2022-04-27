﻿using Automation_Framework.Utility;
using Automation_Framework.Helpers;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Support.UI;
using System;


namespace Automation_Framework.Extensions.MobileDriver
{
    public static class MobileWaitExtension
    {
        /// <summary>
        /// Used for the defaultimeout wait specified in appSettings
        /// </summary>
        /// <param name="driver">Containts the mobile driver used to run the test in</param>
        /// <returns>A WebDriverWait function</returns>
        public static WebDriverWait AndroidWait(this AppiumDriver<AndroidElement> driver)
        {
            if (driver is null) Log.Warn("The driver has not been build");
            return new WebDriverWait(driver,
                TimeSpan.FromSeconds(Configuration.NativeMobileDriver.DefaultTimeout));
        }

        /// <summary>
        /// Used for the defaultimeout wait specified in appSettings
        /// </summary>
        /// <param name="driver">Containts the mobile driver used to run the test in</param>
        /// <returns>A WebDriverWait function</returns>
        public static WebDriverWait IOSWait(this AppiumDriver<IOSElement> driver)
        {
            if (driver is null) Log.Warn("The driver has not been build");
            return new WebDriverWait(driver,
                TimeSpan.FromSeconds(Configuration.NativeMobileDriver.DefaultTimeout));
        }

        /// <summary>
        /// Waits until an element is clickable
        /// </summary>
        /// <param name="driver">Containts the driver used to run the test in</param>
        /// <param name="element">IOSElement defined in Page Object which should become clickable</param>
        /// <returns>A WebDriverWait function expecting the element to be clickable</returns>
        public static void WaitForClickableIOS(this AppiumDriver<IOSElement> driver, IOSElement element)
        {
            try
            {

                driver.IOSWait().Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (Exception)
            {
                Log.Warn($"failed to locate {element} within {Configuration.WebDriver.DefaultTimeout} seconds");
                throw;
            }

        }

        /// <summary>
        /// Waits until an element is clickable
        /// </summary>
        /// <param name="driver">Containts the driver used to run the test in</param>
        /// <param name="by">AndroidElement defined in Page Object which should become clickable</param>
        /// <returns>A WebDriverWait function expecting the element to be clickable</returns>
        public static void WaitForClickableAndroid(this AppiumDriver<AndroidElement> driver, AndroidElement element)
        {
            try
            {
                driver.AndroidWait().Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (Exception)
            {
                Log.Warn($"failed to locate {element} within {Configuration.WebDriver.DefaultTimeout} seconds");
                throw;
            }

          
        }
    }
}
