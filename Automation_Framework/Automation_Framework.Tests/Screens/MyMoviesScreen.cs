using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;

namespace Automation_Framework.Tests.Screens
{
    public class MyMoviesScreen : BasePage
    {
        public MyMoviesScreen(DriverBuilder driver) : base(driver) { }

        //Android element
        public IAndroidElement MovieCard => new MobileElement(AndroidDriver, "(//android.view.ViewGroup[@content-desc=\"movieCard\"])[1]", MobileSelector.Xpath);
        public IAndroidElement MovieCardImage => new MobileElement(AndroidDriver, "(//android.view.ViewGroup[@content-desc=\"movieCard\"])[1]/android.widget.ImageView", MobileSelector.Xpath);
        public IAndroidElement MovieCardTitle => new MobileElement(AndroidDriver, "(//android.widget.TextView[@content-desc=\"movieTitle\"])[1]", MobileSelector.Xpath);
        public IAndroidElement MovieCardDate => new MobileElement(AndroidDriver, "(//android.widget.TextView[@content-desc=\"movieDueTo\"])[1]", MobileSelector.Xpath);
        public IAndroidElement WatchMovieButton => new MobileElement(AndroidDriver, "(//android.view.ViewGroup[@content-desc=\"watchMovie\"])[1]/android.widget.TextView", MobileSelector.Xpath);
        public IAndroidElement GoBackButton => new MobileElement(AndroidDriver, "//android.widget.Button[@content-desc=\"goBack\"]/android.widget.TextView", MobileSelector.Xpath);

        //Android Functions
        public void ClickWatchMovieButton() => WatchMovieButton.AndroidClick();
        public void ClickGoBackButton() => GoBackButton.AndroidClick();

       
    }
}
