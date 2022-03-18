using Automation_Framework.Builders;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Automation_Framework.Base
{
    public abstract class BasePage
    {
            protected readonly IWebDriver Driver;
             protected readonly AppiumDriver<AndroidElement> AndroidDriver;
           protected BasePage(DriverBuilder driver)
            {
            Driver = driver._webDriver;
            AndroidDriver = driver._androidDriver;
              }
    

   }
}
