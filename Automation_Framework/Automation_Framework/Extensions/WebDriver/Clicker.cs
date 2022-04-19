using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;

namespace Automation_Framework.Extensions.WebDriver
{
    public static class Clicker
    {
     
        public static void ClickOnElement(this IWebDriver driver, By by)
        {
            driver.WaitForClickable(by);
            driver.FindElement(by).Click();
        }

        public static void ClickOnElement(this IWebDriver driver, IWebElement element)
        {
            driver.WaitForClickable(element);
            element.Click();
        }


        public static void ClickOnTextFromList(this IWebDriver driver, By by, string text)
        {
            
            driver.Wait().Until(x => x.FindElements(by).First().Text.ToLower() == text.ToLower());
            driver.FindElements(by).First(x => x.Text.ToLower() == text.ToLower()).Click();
        }

        public static void PressTab(this IWebDriver driver)
        {
            new Actions(driver).SendKeys(OpenQA.Selenium.Keys.Tab).Perform();

        }

        public static void PressSpace(this IWebDriver driver)
        {
            new Actions(driver).SendKeys(OpenQA.Selenium.Keys.Space).Perform();

        }
        public static void PressEnter(this IWebDriver driver)
        {
            new Actions(driver).SendKeys(OpenQA.Selenium.Keys.Enter).Perform();

        }
    }
}
