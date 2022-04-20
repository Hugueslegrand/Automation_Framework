using OpenQA.Selenium;

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
            return ((IJavaScriptExecutor)driver).ExecuteScript(script);
        }
    }
}