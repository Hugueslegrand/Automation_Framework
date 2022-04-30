using Automation_Framework.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Extensions.WebDriver
{
    public static class TabsHandler
    {


        public static void SwitchToASpecificTab(this IWebDriver driver,int tabIndex)
        {
            driver.SwitchTo().Window(driver.WindowHandles[tabIndex]);
            Log.Info($"Switched to tab number {tabIndex+1}");
        }

        

        public static void OpenLinkInNewTab(this IWebDriver driver,IWebElement element)
        {
            new Actions(driver).KeyDown(Keys.Control).MoveToElement(element).Click().Perform();
            Log.Info("Opened link in a new tab");
        }
    }
}
