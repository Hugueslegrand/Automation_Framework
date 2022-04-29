using OpenQA.Selenium;
using Automation_Framework.Utility;

namespace Automation_Framework.Extensions.WebDriver
{
    public static class JavaScriptExecutor
    {
        /// <summary>
        /// Method that allows to run a JS script in the driver
        /// </summary>
        /// <param name="driver">The web driver</param>
        /// <param name="script">The script that has to be executed</param>
        /// <returns>Returns an object after script execution</returns>
        public static object ExecuteJs(this IWebDriver driver, string script)
        {
            if (driver is null) Log.Warn("The driver has not been build");
            return ((IJavaScriptExecutor)driver).ExecuteScript(script);
        }

        public static object ExecuteJsObject(this IWebDriver driver, string script,object element)
        {
            if (driver is null) Log.Warn("The driver has not been build");
            return ((IJavaScriptExecutor)driver).ExecuteScript(script,element);
        }

    }
}