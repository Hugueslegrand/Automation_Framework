using OpenQA.Selenium;

namespace Automation_Framework.Extensions.Generators
{
    public static class ValueScanner
    {
        public static string GetValue(this IWebElement element)
        {
            return element.GetAttribute("value");
        }
    }
}
