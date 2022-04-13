using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;

namespace Automation_Framework.Tests.Screens
{
    public class SearchScreen : BasePage
    {
        public SearchScreen(DriverBuilder driver) : base(driver) { }

        //Android elements
 
        public IAndroidElement AndroidSearchbar => new MobileElement(AndroidDriver, "//android.widget.EditText[@content-desc=\"searchInput\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidMovieCard => new MobileElement(AndroidDriver, "(//android.view.ViewGroup[@content-desc=\"movieCard\"])[1]", MobileSelector.Xpath);
        public IAndroidElement AndroidMovieTitle => new MobileElement(AndroidDriver, "(//android.widget.TextView[@content-desc=\"movieTitle\"])[1]", MobileSelector.Xpath);
        public IAndroidElement AndroidMovieBanner => new MobileElement(AndroidDriver, "(//android.view.ViewGroup[@content-desc=\"movieCard\"])[1]/android.widget.ImageView", MobileSelector.Xpath);
        public IAndroidElement AndroidMoreInfoButton => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"moreInfoBtn\"]/android.widget.TextView", MobileSelector.Xpath);

        //Android Functions
        public void FillSearchbar(string movieName) => AndroidSearchbar.AndroidSendKeys(movieName);
        public void ClickMoreInfoButton() => AndroidMoreInfoButton.AndroidClick();

    }
}
