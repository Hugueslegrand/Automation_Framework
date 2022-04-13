using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;

namespace Automation_Framework.Tests.Screens
{
    class DetailsScreen : BasePage
    {
        public DetailsScreen(DriverBuilder driver) : base(driver) { }

        //Android elements

        public IAndroidElement AndroidBackButton => new MobileElement(AndroidDriver, "//android.widget.Button[@content-desc=\"goBack\"]/android.widget.TextView", MobileSelector.Xpath);
        public IAndroidElement AndroidMovieTitle => new MobileElement(AndroidDriver, "//android.widget.TextView[@content-desc=\"movieTitle\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidMovieDescription => new MobileElement(AndroidDriver, "//android.widget.TextView[@content-desc=\"movieDescription\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidMoreInfo => new MobileElement(AndroidDriver, "//android.widget.TextView[@content-desc=\"moreInfo\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidNameActorsTitle => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"mainContent\"]/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.widget.TextView[1]", MobileSelector.Xpath);
        public IAndroidElement AndroidAvatarActor => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"mainContent\"]/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.widget.ImageView[1]", MobileSelector.Xpath);
        public IAndroidElement AndroidNameActor => new MobileElement(AndroidDriver, "(//android.widget.TextView[@content-desc=\"actorName\"])[1]", MobileSelector.Xpath);
        public IAndroidElement AndroidPrice => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"mainContent\"]/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView[4]", MobileSelector.Xpath);
        public IAndroidElement AndroidGenres => new MobileElement(AndroidDriver, "//android.widget.TextView[@content-desc=\"genres\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidRentMovieButton => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"rentMovie\"]", MobileSelector.Xpath);

        //Android Functions
        public void ClickBackButton() => AndroidBackButton.AndroidClick();
        public void ClickMoreInfo() => AndroidMoreInfo.AndroidClick();
        public void ClickRentMovieButton() => AndroidRentMovieButton.AndroidClick();

    }
}
