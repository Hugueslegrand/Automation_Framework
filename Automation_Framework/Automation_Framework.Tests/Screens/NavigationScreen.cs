using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;

namespace Automation_Framework.Tests.Screens
{
    public class NavigationScreen : BasePage
    {
        public NavigationScreen(DriverBuilder driver) : base(driver) { }

        //Android elements
        public IAndroidElement SearchbarTab => new MobileElement(AndroidDriver, "//android.widget.Button[@content-desc=\"searchTab\"]", MobileSelector.Xpath);
        public IAndroidElement ProfileTab => new MobileElement(AndroidDriver, "//android.widget.Button[@content-desc=\"profileTab\"]", MobileSelector.Xpath);
        public IAndroidElement MyMoviesTab => new MobileElement(AndroidDriver, "//android.widget.Button[@content-desc=\"moviesTab\"]", MobileSelector.Xpath);
        public IAndroidElement HomeTab => new MobileElement(AndroidDriver, "//android.widget.Button[@content-desc=\"homeTab\"]", MobileSelector.Xpath);


        //Android Functions
        public void ClickSearchbarTab() => SearchbarTab.AndroidClick();
        public void ClickProfileTab() => ProfileTab.AndroidClick();
        public void ClickMyMoviesTab() => MyMoviesTab.AndroidClick();
        public void ClickHomeTab() => HomeTab.AndroidClick();
    }
}
