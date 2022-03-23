using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Automation_Framework.Helpers;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Threading;
using Automation_Framework.WebElementModels;

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

        public static void WaitForClickable(this IWebDriver driver, IWebElement element)
        {
            //Thread.Sleep(5000);
            WebDriverWait waitFunc = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            waitFunc.Until(ExpectedConditions.ElementToBeClickable(element));
        }
        public static void GetElementAndScrollTo(this IWebDriver driver, string element,int moveLength)
        {
            var js = driver as IJavaScriptExecutor;
            js.ExecuteScript($"document.querySelector({element}).scrollLeft = {moveLength}");
        }

    }
}
