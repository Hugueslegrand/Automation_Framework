using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Automation_Framework.Base
{
    public abstract class BasePage
    {
            protected readonly IWebDriver Driver;
          //  protected readonly AppiumDriver<AndroidElement> AndroidDriver;
           protected BasePage(IWebDriver driver)
            {
                Driver = driver;
            }
        /*   protected BasePage(AppiumDriver<AndroidElement> driver)
            {
             AndroidDriver = driver;
            }*/

    }
}
