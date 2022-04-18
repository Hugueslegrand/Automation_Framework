using System;
using System.Linq;
using Automation_Framework.WebElementModels;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;

namespace Automation_Framework.Extensions.WebDriver
{
    public static class Scroller
    {
        public static void GetElementAndScrollTo(this IWebDriver driver, string element, int moveLength)
        {
            var js = driver as IJavaScriptExecutor;
            js.ExecuteScript($"document.querySelector({element}).scrollLeft = {moveLength}");
        }
        public static void GetElementAndSwipeTo(this AppiumDriver<AndroidElement> driver, IWebElement element, int horizontal, int vertical)
        {
            TouchActions action = new TouchActions(driver);
            action.Scroll(element, horizontal, vertical);
            action.Perform();
        }

        public static void Swipe(this AppiumDriver<AndroidElement> driver, int startX, int startY, int endX, int endY, int duration)
        {
            ITouchAction touchAction = new TouchAction(driver)
            .Press( startX, startY)
            .Wait(duration)
            .MoveTo(endX, endY)
            .Release();

            touchAction.Perform();
        }

    }
}