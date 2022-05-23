using Automation_Framework.Builders;
using Automation_Framework.Utilities;
using Automation_Framework.Extensions.WebDriver;
using System.Collections.ObjectModel;
using Automation_Framework.Utilities;

namespace Automation_Framework.Tests.Pages
{
    public class BasePage : Base.BasePage
    {

        public string Url => Driver.Url;

        public string Title => Driver.Title;

        public string PageSource => Driver.PageSource;

        public string CurrentWindowHandle => Driver.CurrentWindowHandle;

        public ReadOnlyCollection<string> WindowHandles => Driver.WindowHandles;


        public BasePage(DriverBuilder driver) : base(driver) { }


        public void gotoUrl(string url)
        {
            Driver.OpenLink(url);
        }

        public void WaitSeconds(int seconds)
        {
            WaitExtension.WaitSeconds(seconds);
            
        }

        public void SendKeys(string keys)
        {
            SendKeys(keys);
        }

        public void PressTab() => Driver.PressTab();
        public void PressEnter() => Driver.PressEnter();

        public void SwitchToASpecificTab(int tabIndex)
        {
            Driver.SwitchToASpecificTab(tabIndex);
        }

        public void ScaleScreen(string script)
        {
            Driver.ExecuteJs(script);
        }
        public void ScrollElementIntoView(object element)
        {

            Driver.ExecuteJsObject("arguments[0].scrollIntoView(true);", element);
        }
        public void CloseCurrentTab()
        {
            Driver.Close();
        }

        public void ScreenShot() => ScreenshotTaker.TakeStandardScreenshot(Driver, "FirstScreenshot");
    }
}
