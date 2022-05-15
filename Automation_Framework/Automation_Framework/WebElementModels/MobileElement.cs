using Automation_Framework.Enums;
using Automation_Framework.Extensions.MobileDriver;
using Automation_Framework.Extensions.WebDriver;
using Automation_Framework.Utilities;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Drawing;

namespace Automation_Framework.WebElementModels
{
    /// <summary>
    /// MobileElement class to create android and Ios elements
    /// </summary>
    public class MobileElement : IAndroidElement, IIOSElement
    {

        private AppiumDriver<AndroidElement>? _androidDriver;
        private AndroidElement? _androidElement;
        private AppiumDriver<IOSElement>? _iosDriver;
        private IOSElement? _iosElement;


        public string AndroidTagName => _androidElement.TagName;
       
        public string AndroidText => _androidElement.Text;

        public bool AndroidEnabled => _androidElement.Enabled;

        public bool AndroidSelected => _androidElement.Selected;

        public bool AndroidDisplayed => _androidElement.Displayed;

        public Size AndroidSize => _androidElement.Size;

        public Point AndroidLocation => _androidElement.Location;

        public string IOSTagName => _iosElement.TagName;

        public string IOSText => _iosElement.Text;

        public bool IOSEnabled => _iosElement.Enabled;

        public bool IOSSelected => _iosElement.Selected;

        public bool IOSDisplayed => _iosElement.Displayed;

        public Size IOSSize => _iosElement.Size;

        public Point IOSLocation => _iosElement.Location;



        /// <summary>
        /// Creates android mobile elements 
        /// </summary>
        /// <param name="driver">The running Android driver instance</param>
        /// <param name="element">Id, css selector, xpath, etc.. of the element</param>
        /// <param name="selector">Selector to use for element in test, example: find element by CSS, XPath, Id, ...</param>
        public MobileElement(AndroidDriver<AndroidElement> driver, string element, MobileSelector selector)
        {

            _androidDriver = driver;
            switch (selector)
            {
                case MobileSelector.Name:
                    _androidDriver.WaitForClickableAndroid(_androidDriver.FindElementByName(element));
                    _androidElement = _androidDriver.FindElementByName(element);
                    break;
                case MobileSelector.Id:
                    _androidDriver.WaitForClickableAndroid(_androidDriver.FindElementById(element));
                    _androidElement = _androidDriver.FindElementById(element);
                    break;
                case MobileSelector.Css:
                    _androidDriver.WaitForClickableAndroid(_androidDriver.FindElementByCssSelector(element));
                    _androidElement = _androidDriver.FindElementByCssSelector(element);
                    break;

                case MobileSelector.Xpath:
                    _androidDriver.WaitForClickableAndroid(_androidDriver.FindElementByXPath(element));
                    _androidElement = _androidDriver.FindElementByXPath(element);
                    break;

                case MobileSelector.AccessibilityID:
                    _androidDriver.WaitForClickableAndroid(_androidDriver.FindElementByAccessibilityId(element));
                    _androidElement = _androidDriver.FindElementByAccessibilityId(element);
                    break;
                case MobileSelector.ClassName:
                    _androidDriver.WaitForClickableAndroid(_androidDriver.FindElementByClassName(element));
                    _androidElement = _androidDriver.FindElementByClassName(element);
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// Creates IOS mobile elements 
        /// </summary>
        /// <param name="driver">The running IOS driver instance</param>
        /// <param name="element">Id, css selector, xpath, etc.. of the element</param>
        /// <param name="selector">Selector to use for element in test, example: find element by CSS, XPath, Id, ...</param>
        public MobileElement(AppiumDriver<IOSElement> driver, string element, MobileSelector selector)
        {
            _iosDriver = driver;
            Log.Info($"Finding element `{element}` by {selector} ");
            switch (selector)
            {
                case MobileSelector.Name:
                    _iosDriver.WaitForClickableIOS(_iosDriver.FindElementByName(element));
                    _iosElement = _iosDriver.FindElementByName(element);
                    break;
                case MobileSelector.Id:
                    _iosDriver.WaitForClickableIOS(_iosDriver.FindElementById(element));
                    _iosElement = _iosDriver.FindElementById(element);
                    break;
                case MobileSelector.Css:
                    _iosDriver.WaitForClickableIOS(_iosDriver.FindElementByCssSelector(element));
                    _iosElement = _iosDriver.FindElementByCssSelector(element);
                    break;

                case MobileSelector.Xpath:
                    _iosDriver.WaitForClickableIOS(_iosDriver.FindElementByXPath(element));
                    _iosElement = _iosDriver.FindElementByXPath(element);
                    break;

                case MobileSelector.AccessibilityID:
                    _iosDriver.WaitForClickableIOS(_iosDriver.FindElementByAccessibilityId(element));
                    _iosElement = _iosDriver.FindElementByAccessibilityId(element);
                    break;
                case MobileSelector.ClassName:
                    _iosDriver.WaitForClickableIOS(_iosDriver.FindElementByClassName(element));
                    _iosElement = _iosDriver.FindElementByClassName(element);
                    break;
                default:
                    new ArgumentOutOfRangeException(nameof(MobileSelector),
                       $"No valid SelectorType given. Selector must be of either types {MobileSelector.AccessibilityID}, {MobileSelector.ClassName}, {MobileSelector.Css}, {MobileSelector.Id}, {MobileSelector.Name}, {MobileSelector.Xpath}.",
                       null);
                    break;
            }
        }


        public void AndroidSendKeys(string text)
        {
            _androidElement.SendKeys(text);
        }
        public void AndroidClick()
        {
            Log.Info($"Clicking on the  {_androidElement}");
            _androidElement.Click();
            Log.Info($"clicked on the  {_androidElement.Id} ");
        }

        public void AndroidClear()
        {
            _androidElement.Clear();
        }

        public void IOSClick()
        {
            _iosElement.Click();
        }

        public void IOSSendKeys(string text)
        {
            _iosElement.SendKeys(text);
        }

        public void IOSClear()
        {
            _iosElement.Clear();
        }

        public void Swipe(int startX, int startY, int endX, int endY, int duration)
        {
            _androidDriver.Swipe(startX, startY, endX, endY, duration);
        }

    }
}
