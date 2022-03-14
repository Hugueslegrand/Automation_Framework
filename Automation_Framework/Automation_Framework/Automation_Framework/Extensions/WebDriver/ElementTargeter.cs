using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Automation_Framework.Extensions.WebDriver
{
    public static class ElementTargeter
    {
        public static void MoveToLocator(this IWebDriver driver, By by)
        {
            var actions = new Actions(driver);
            driver.WaitForClickable(by);
            actions.MoveToElement(driver.FindElement(by)).Build().Perform();
        }

        public static void MoveToElement(this IWebDriver driver, IWebElement element)
        {
            var actions = new Actions(driver);
            driver.WaitForClickable(element);
            actions.MoveToElement(element).Build().Perform();
        }

        public static void ClickLocator(this IWebDriver driver, IWebElement element)
        {
            driver.MoveToElement(element);
            driver.ClickOnElement(element);
        }
    }
}
