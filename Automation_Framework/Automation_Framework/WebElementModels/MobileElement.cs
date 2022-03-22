using Automation_Framework.Enums;
using Automation_Framework.Extensions.MobileDriver;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.WebElementModels
{
    public class MobileElement : IAndroidElement,IIOSElement
    {
        private AppiumDriver<AndroidElement>? _androidDriver;
        private AndroidElement? _androidElement;
        private AppiumDriver<IOSElement>? _iosDriver;
        private IOSElement? _iosElement;

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
        public MobileElement(AppiumDriver<IOSElement> driver, string element, MobileSelector selector)
        {
            _iosDriver = driver;
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
                    break;
            }
        }

        public void AndroidSendKeys(string text)
        {
            _androidElement.SendKeys(text);
        }
        public void AndroidClick()
        {
            _androidElement.Click();
        }

  
        public void IOSClick()
        {
            _iosElement.Click();
        }

        public void IOSSendKeys(string text)
        {
            _iosElement.SendKeys(text);
        }

      

    }
}
