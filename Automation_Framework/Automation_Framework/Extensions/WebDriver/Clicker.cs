using System.Linq;
using Automation_Framework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Automation_Framework.Enums;
namespace Automation_Framework.Extensions.WebDriver
{
    /// <summary>
    /// A Click extension class for web
    /// </summary>
    public static class Clicker
    {

        /// <summary>
        /// Method used for clicking on an element, after waiting for it to be clickable
        /// </summary>
        /// <param name="driver">The web driver.</param>
        /// <param name="by">Locator with OpenQA's By method.</param>
        public static void ClickOnElement(this IWebDriver driver, By by)
        {
            driver.WaitForClickable(by);
            driver.FindElement(by).Click();
        }

        /// <summary>
        /// Method used for clicking on an element, after waiting for it to be clickable
        /// </summary>
        /// <param name="driver">The web driver.</param>
        /// <param name="element">A WebElement that has been defined in the Page Objects.</param>
        public static void ClickOnElement(this IWebDriver driver, IWebElement element)
        {
            driver.WaitForClickable(element);
            element.Click();
        }

        /// <summary>
        /// Method used to filter elements with the same class, id or path and clicks on the element containing the text input
        /// </summary>
        /// <param name="driver">The web driver.</param>
        /// <param name="by">Locator with OpenQA's By method.</param>
        /// <param name="text">The text that has to be selected.</param>
        public static void ClickOnTextFromList(this IWebDriver driver, By by, string text)
        {

            driver.Wait().Until(x => x.FindElements(by).First().Text.ToLower() == text.ToLower());
            driver.FindElements(by).First(x => x.Text.ToLower() == text.ToLower()).Click();
        }

        /// <summary>
        /// Keyboard key gets pressed on driver (page) as a whole instead on a WebElement
        /// </summary>
        /// <param name="driver">The web driver.</param>
        /// <param name="key">The Key from keyboard</param>
        public static void PressKey(this IWebDriver driver,string key)
        {
            new Actions(driver).SendKeys(key).Perform();
            Log.Info($"Pressed the {key} key");

        }

        /// <summary>
        /// Enter key gets pressed on driver (page) as a whole instead on a WebElement
        /// </summary>
        /// <param name="driver">The web driver.</param>
       /* public static void PressEnter(this IWebDriver driver)
        {
            new Actions(driver).SendKeys(Keys.Enter).Perform();
            Log.Info("Pressed the Enter key");

        }*/
    }
}
