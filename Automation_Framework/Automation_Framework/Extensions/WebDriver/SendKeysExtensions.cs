using OpenQA.Selenium;


namespace Automation_Framework.Extensions.WebDriver
{
    public static class SendKeysExtensions
    {
        public static void WaitAndSendKeys(this IWebDriver driver, By by, string text)
        {
            driver.WaitForClickable(by);
            driver.FindElement(by).Clear();
            driver.FindElement(by).SendKeys(text);
        }

        public static void WaitAndSendKeys(this IWebDriver driver, IWebElement element, string text)
        {
            driver.WaitForClickable(element);
            element.Clear();
            element.SendKeys(text);
        }
    }
}
