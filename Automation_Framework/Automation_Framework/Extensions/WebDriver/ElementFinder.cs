using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium; 

namespace Automation_Framework.Extensions.WebDriver
{
    public static class ElementFinder
    {
        public static IWebElement WaitThenFind(this IWebDriver driver, By by)
        {
            driver.WaitForClickable(by);
            return driver.FindElement(by);
        }

        public static IList<IWebElement> FindElementAboveZero(this IWebDriver driver, By by)
        {
            driver.Wait().Until(x => x.FindElements(by).Count > 0);
            return driver.FindElements(by);
        }

        public static IWebElement FindElementByText(this IWebDriver driver, By by, string text)
        {
            driver.Wait().Until(x => x.FindElements(by).First(y => y.Text == text));
            return driver.FindElements(by).First(x => x.Text == text);
        }
    }
}
