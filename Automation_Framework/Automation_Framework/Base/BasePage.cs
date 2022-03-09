using OpenQA.Selenium;

namespace Automation_Framework.Base
{
    public abstract class BasePage
    {
            protected readonly IWebDriver Driver;

            protected BasePage(IWebDriver driver)
            {
                Driver = driver;
            }
    }
}
