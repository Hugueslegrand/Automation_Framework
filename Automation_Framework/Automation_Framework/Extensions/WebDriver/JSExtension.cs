using OpenQA.Selenium;

namespace Automation_Framework.Extensions.WebDriver
{
    public static class JSExtension
    {
        public static object ExecuteJs(this IWebDriver driver, string script)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(script);
        }
    }
}