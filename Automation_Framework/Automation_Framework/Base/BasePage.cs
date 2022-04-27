using Automation_Framework.Builders;
using Automation_Framework.Extensions.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using System.Collections.ObjectModel;
using System.Threading;

namespace Automation_Framework.Base
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;
        protected readonly AndroidDriver<AndroidElement> AndroidDriver;
        protected readonly IOSDriver<IOSElement> IOSDriver;

        //
        // Summary:
        //     Gets or sets the URL the browser is currently displaying.
        //
        // Remarks:
        //     Setting the OpenQA.Selenium.IWebDriver.Url property will load a new web page
        //     in the current browser window. This is done using an HTTP GET operation, and
        //     the method will block until the load is complete. This will follow redirects
        //     issued either by the server or as a meta-redirect from within the returned HTML.
        //     Should a meta-redirect "rest" for any duration of time, it is best to wait until
        //     this timeout is over, since should the underlying page change while your test
        //     is executing the results of future calls against this interface will be against
        //     the freshly loaded page.
        public string Url => Driver.Url;
        //
        // <summary>
        //     Gets the title of the current browser window.
        public string Title => Driver.Title;
        //
        // <summary>
        //     Gets the source of the page last loaded by the browser.
        //
        // Remarks:
        //     If the page has been modified after loading (for example, by JavaScript) there
        //     is no guarantee that the returned text is that of the modified page. Please consult
        //     the documentation of the particular driver being used to determine whether the
        //     returned text reflects the current state of the page or the text last sent by
        //     the web server. The page source returned is a representation of the underlying
        //     DOM: do not expect it to be formatted or escaped in the same way as the response
        //     sent from the web server.
        public string PageSource => Driver.PageSource;
        //
        // <summary>
        //     Gets the current window handle, which is an opaque handle to this window that
        //     uniquely identifies it within this driver instance.
        public string CurrentWindowHandle => Driver.CurrentWindowHandle;
        //
        // <summary>
        //     Gets the window handles of open browser windows.
        public ReadOnlyCollection<string> WindowHandles => Driver.WindowHandles;

        protected BasePage(DriverBuilder driver)
        {
            Driver = driver._webDriver;
            AndroidDriver = driver._androidDriver;
            IOSDriver = driver._iosDriver;
        }

        public void gotoUrl(string url)
        {
            Driver.OpenLink(url);
        }

        public void WaitSeconds(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public void SendKeys(string keys)
        {
            SendKeys(keys);
        }

        public void PressTab() => Driver.PressTab();

        public void PressEnter()
        {
            Driver.PressEnter();
        }

        public void SwitchToASpecificTab(int tabIndex)
        {
            Driver.SwitchToASpecificTab(tabIndex);
        }

      

        public void CloseCurrentTab()
        {
            Driver.Close();
        }

        public void ScreenShot() => ScreenshotTaker.TakeStandardScreenshot(Driver, "FirstScreenshot");
    }
}
