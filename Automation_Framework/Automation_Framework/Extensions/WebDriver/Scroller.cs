using System;
using System.Linq;
using Automation_Framework.WebElementModels;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Automation_Framework.Extensions.WebDriver
{
    public static class Scroller
    {
        public static void GetElementAndScrollTo(this IWebDriver driver, IWebElement element)
        {
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"document.querySelector({element}).scrollLeft = 900");
        }
    }
}