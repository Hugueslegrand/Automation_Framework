using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;


namespace Automation_Framework.Tests.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(DriverBuilder driver): base(driver) { }

      

        //Mobile elements
       /* public AndroidElement Logo => AndroidDriver.FindElementByXPath("//android.view.ViewGroup[@content-desc=\"logo\"]/android.widget.ImageView");
        public AndroidElement SignInButton => AndroidDriver.FindElementByXPath("//android.view.ViewGroup[@content-desc=\"loginIcon\"]/android.widget.TextView");
        public AndroidElement SignOutButton => AndroidDriver.FindElementByXPath("//android.view.ViewGroup[@content-desc=\"logoutIcon\"]/android.widget.TextView");
        public AndroidElement SettingsButton => AndroidDriver.FindElementByXPath("//android.view.ViewGroup[@content-desc=\"settingsIcon\"]/android.widget.TextView");


        public AndroidElement MovieTitle => AndroidDriver.FindElementByXPath("(//android.view.ViewGroup[@content-desc=\"moviesRow\"])[1]/android.widget.TextView");
        public AndroidElement MovieBanner => AndroidDriver.FindElementByXPath("(//android.view.ViewGroup[@content-desc=\"moviePoster\"])[1]/android.widget.ImageView");
       */

        //Desktop elements

        public IButton MovieBannerButton => new WebElement(Driver, "//div[@id='Comedy Movies']//img[@id='734280']", Selector.Xpath);
        public IButton deHorizontalScrollBarrs => new WebElement(Driver, "//div[@id='Comedy Movies']//div[@class='css-nlgfro']", Selector.Xpath);
        public IButton BrightestOfficalSite => new WebElement(Driver, "//a[@class='css-mi3e9x']", Selector.Xpath);
        public IButton BrightestFaceBookSocials => new WebElement(Driver, "//a[@href='https://www.facebook.com/BrightestNV']",Selector.Xpath);
        public IButton BrightestTwitterSocials => new WebElement(Driver, "//a[@href='https://twitter.com/brightestnv']", Selector.Xpath);
        public IButton BrightestInstagramSocials => new WebElement(Driver, "//a[@href='https://www.instagram.com/brightestsoftwarequality/']",Selector.Xpath);
        public IButton BrightestLinkedInSocials => new WebElement(Driver, "//a[@href='https://www.linkedin.com/company/brightest-nv/']", Selector.Xpath);
        public IButton RentThisMovieButton => new WebElement(Driver, "//button[@id='RentMovieButton']", Selector.Xpath);
        public IButton MoreInfoButton => new WebElement(Driver, "//a[@class='css-14nkc1e']",Selector.Xpath);
        public IButton CloseModalButton => new WebElement(Driver, "//div[@class='css-ce9ngx']//button[@id='CloseModal']",Selector.Xpath);


        public IButton RentPopUp => new WebElement(Driver, "//div[@class='notification-container--top-center']", Selector.Xpath);

        public string GetInnerText_Warning()
        {
            return RentPopUp.GetInnerHTML();
        }

        /* public IWebElement MovieBannerButton => Driver.FindElement(By.XPath("//div[@id='Comedy Movies']//img[@id='531219']"));

         public IWebElement HorizontalScrollBar => Driver.FindElement(By.XPath("//div[@id='Comedy Movies']//div[@class='css-nlgfro']"));
         public IWebElement BrightestOfficalSite => Driver.FindElement(By.XPath("//a[@class='css-mi3e9x']"));
         public IWebElement BrightestFaceBookSocials => Driver.FindElement(By.XPath("//a[@href='https://www.facebook.com/BrightestNV']"));
         public IWebElement BrightestTwitterSocials => Driver.FindElement(By.XPath("//a[@href='https://twitter.com/brightestnv']"));
         public IWebElement BrightestInstagramSocials => Driver.FindElement(By.XPath("//a[@href='https://www.instagram.com/brightestsoftwarequality/']"));
         public IWebElement BrightestLinkedInSocials => Driver.FindElement(By.XPath("//a[@href='https://www.linkedin.com/company/brightest-nv/']"));


         public IWebElement RentThisMovieButton => Driver.FindElement(By.XPath("//button[@id='RentMovieButton']"));
         public IWebElement MoreInfoButton => Driver.FindElement(By.XPath("//a[@class='css-14nkc1e']"));
         public IWebElement CloseModalButton => Driver.FindElement(By.XPath("//div[@class='css-ce9ngx']//button[@id='CloseModal']"));*/

        //public void ClickMovieBanner()=> MovieBannerButton.ClickOnElement();


        public void ClickMovieBanner() => MovieBannerButton.ClickOnElement();
        //Driver.ClickOnElement(MovieBannerButton);
        public void ClickBrightestOfficalSite() => BrightestOfficalSite.ClickOnElement();
        //Driver.ClickOnElement(BrightestOfficalSite);
        public void ClickBrightestFaceBookSocials() => BrightestFaceBookSocials.ClickOnElement();
        //Driver.ClickOnElement(BrightestFaceBookSocials);
        public void ClickBrightestTwitterSocials() => BrightestTwitterSocials.ClickOnElement();
        //Driver.ClickOnElement(BrightestTwitterSocials);
        public void ClickBrightestInstagramSocials() => BrightestInstagramSocials.ClickOnElement();
        //Driver.ClickOnElement(BrightestInstagramSocials);
        public void ClickBrightestLinkedInSocials() => BrightestLinkedInSocials.ClickOnElement();
        //Driver.ClickOnElement(BrightestLinkedInSocials);
        public void ClickRentThisMovie() => RentThisMovieButton.ClickOnElement();
        //Driver.ClickOnElement(RentThisMovieButton);
        public void ClickMoreInfo() => MoreInfoButton.ClickOnElement();
        //Driver.ClickOnElement(MoreInfoButton);
        public void ClickCloseModal() => CloseModalButton.ClickOnElement();
        //Driver.ClickOnElement(CloseModalButton);



        //Mobile methods
     /*   public void ClickLogo() => Logo.Click();
        public void ClickSignInButton() => SignInButton.Click();
        public void ClickSignOutButton() => SignOutButton.Click();
        public void ClickSettingsButton() => SettingsButton.Click();*/
    }
}
