using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Automation_Framework.Extensions.WebDriver
{
    public static class FormFiller
    {
        public static void FillFormByLocator(this IWebDriver driver, By by, string text)
        {
            driver.WaitForClickable(by);
            driver.FindElement(by).Clear();
            driver.FindElement(by).SendKeys(text);
        }

        public static void FillFormByElement(this IWebDriver driver, IWebElement element, string text)
        {
            driver.WaitForClickable(element);
            element.Clear();
            element.SendKeys(text);
        }
    }
}
