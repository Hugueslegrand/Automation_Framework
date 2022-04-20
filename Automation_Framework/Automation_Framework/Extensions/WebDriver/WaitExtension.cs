using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Automation_Framework.Helpers;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Threading;

namespace Automation_Framework.Extensions.WebDriver
{
    public static class WaitExtension
    {
        /// <summary>
        /// Waits a specified amount of seconds
        /// </summary>
        /// <param name="seconds">Amount of seconds to wait</param>
        public static void WaitSeconds(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        /// <summary>
        /// Used for the defaultimeout wait specified in appSettings
        /// </summary>
        /// <param name="driver">Containts the driver used to run the test in</param>
        /// <returns>A WebDriverWait function</returns>
        public static WebDriverWait Wait(this IWebDriver driver)
        {
            return new WebDriverWait(driver,
                TimeSpan.FromSeconds(Configuration.WebDriver.DefaultTimeout));
        }

        /// <summary>
        /// Waits until an element is clickable
        /// </summary>
        /// <param name="driver">Containts the driver used to run the test in</param>
        /// <param name="by">Locator with OpenQA's By method which should become clickable</param>
        /// <returns>A WebDriverWait function expecting the element to be clickable</returns>
        public static void WaitForClickable(this IWebDriver driver, By by)
        {
            WebDriverWait waitFunc = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            waitFunc.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        /// <summary>
        /// Waits until an element is clickable
        /// </summary>
        /// <param name="driver">Containts the driver used to run the test in</param>
        /// <param name="element">Defiend WebElemnt in the Page Object which should become clickable</param>
        /// <returns>A WebDriverWait function expecting the element to be clickable</returns>
        public static void WaitForClickable(this IWebDriver driver, IWebElement element)
        {
            WebDriverWait waitFunc = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            waitFunc.Until(ExpectedConditions.ElementToBeClickable(element));
        }

    }
}
