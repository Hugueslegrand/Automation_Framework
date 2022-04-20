using System;
using OpenQA.Selenium;

namespace Automation_Framework.Extensions.WebDriver
{
    public static class SurfToURL
    {
        /// <summary>
        /// Navigates to an URI url
        /// </summary>
        /// <param name="driver">Containts the driver used to run the test in</param>
        /// <param name="url">THe url in Uri form to which should be navigated to</param>
        public static void OpenLink(this IWebDriver driver, Uri url)
        {
            driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Navigates to an string url
        /// </summary>
        /// <param name="driver">Containts the driver used to run the test in</param>
        /// <param name="url">THe url in string form to which should be navigated to</param>
        public static void OpenLink(this IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
