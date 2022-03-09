using System;
using OpenQA.Selenium;

namespace Automation_Framework.Extensions.WebDriver
{
    public static class SurfToURL
    {
        public static void OpenLink(this IWebDriver driver, Uri url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void OpenLink(this IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
