using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Automation_Framework.Extensions.WebDriver
{
    public static class ElementFinder
    {
        /// <summary>
        /// Method used to find elements with the same locator and put them in a List
        /// </summary>
        /// <param name="driver">The web driver.</param>
        /// <param name="by">Locator with OpenQA's By method.</param>
        /// <returns>Returns a List with WebElements</returns>
        public static IList<IWebElement> FindElementAboveZero(this IWebDriver driver, By by)
        {

            driver.Wait().Until(x => x.FindElements(by).Count > 0);
            return driver.FindElements(by);
        }

        /// <summary>
        /// Method used to filter elements with the same class, id or path and to return the element containing the text input
        /// </summary>
        /// <param name="driver">The web driver</param>
        /// <param name="by">Locator with OpenQA's By method</param>
        /// <param name="text">The text that has to be selected</param>
        /// <returns>Returns the first element contataining the input text</returns>
        public static IWebElement FindElementByText(this IWebDriver driver, By by, string text)
        {
            driver.Wait().Until(x => x.FindElements(by).First(y => y.Text == text));
            return driver.FindElements(by).First(x => x.Text == text);
        }

        /// <summary>
        /// Method used to move to an element based on By Locator
        /// </summary>
        /// <param name="driver">The web driver</param>
        /// <param name="by">Locator with OpenQA's By method</param>
        public static void MoveToElement(this IWebDriver driver, By by)
        {
            var actions = new Actions(driver);
            driver.WaitForClickable(by);
            actions.MoveToElement(driver.FindElement(by)).Build().Perform();
        }

        /// <summary>
        /// Method used to move to an element based on WebElement defined in Page Object
        /// </summary>
        /// <param name="driver">The web driver</param>
        /// <param name="element">WebElement defined in Page Object</param>
        public static void MoveToElement(this IWebDriver driver, IWebElement element)
        {
            var actions = new Actions(driver);
            driver.WaitForClickable(element);
            actions.MoveToElement(element).Build().Perform();
        }

        /// <summary>
        /// Method to select an option from a <Select>List</Select> containing the input text
        /// </summary>
        /// <param name="driver">The web driver</param>
        /// <param name="by">Locator of the select element where the option is expected to reside</param>
        /// <param name="text">The text in the option that needs to be selected</param>
        public static void SelectElementByText(this IWebDriver driver, By by, string text)
        {
            driver.WaitForClickable(by);
            var selectElement = new SelectElement(driver.FindElement(by));
            selectElement.SelectByText(text);
        }

        /// <summary>
        /// Method to select an option from a <Select>List</Select> containing the input text
        /// </summary>
        /// <param name="driver">The web driver</param>
        /// <param name="element">WebElement containing the select list defined in Page Object</param>
        /// <param name="text">The text in the option that needs to be selected</param>
        public static void SelectElementByText(this IWebDriver driver, IWebElement element, string text)
        {
            driver.WaitForClickable(element);
            var selectElement = new SelectElement(element);
            selectElement.SelectByText(text);
        }
    }
}
