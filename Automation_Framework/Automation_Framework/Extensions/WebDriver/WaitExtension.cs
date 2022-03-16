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
        public static void WaitTemp(this IWebDriver driver)
        {
            Thread.Sleep(6000);
        }
        public static WebDriverWait Wait(this IWebDriver driver)
        {
            return new WebDriverWait(driver,
                TimeSpan.FromSeconds(Configuration.WebDriver.DefaultTimeout));
        }
        public static void WaitForClickable(this IWebDriver driver, By by)
        {
            //Thread.Sleep(5000);
            WebDriverWait waitFunc = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            waitFunc.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public static IWebElement WaitForClickable(this IWebDriver driver, IWebElement element)
        {
            //Thread.Sleep(5000);
            WebDriverWait waitFunc = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement el = driver.Wait().Until(ExpectedConditions.ElementToBeClickable(element));
            return el;
        }

    }
}
