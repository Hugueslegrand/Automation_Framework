using System;
using System.Linq;
using Automation_Framework.WebElementModels;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Automation_Framework.Extensions.WebDriver
{
    public static class Scroller
    {
        public static void GetElementAndScrollTo(this IWebDriver driver, string element, int moveLength)
        {
            var js = driver as IJavaScriptExecutor;
            js.ExecuteScript($"document.querySelector({element}).scrollLeft = {moveLength}");
        }
    }
}