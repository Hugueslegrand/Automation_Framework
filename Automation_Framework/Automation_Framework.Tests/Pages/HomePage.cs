using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.Extensions.WebDriver;
using Automation_Framework.WebElementModels;


namespace Automation_Framework.Tests.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(DriverBuilder driver): base(driver) { }
        

        

        //Desktop elements

        public IButton MovieBannerButton => new WebElement(Driver,"//div[@id='Comedy Movies']//img[@id='531219']",Selector.Xpath);
        public IButton deHorizontalScrollBarrs => new WebElement(Driver, "//div[@id='Comedy Movies']//div[@class='css-nlgfro']", Selector.Xpath);
        public IButton BrightestOfficalSite => new WebElement(Driver, "//a[@class='css-mi3e9x']", Selector.Xpath);
        public IButton BrightestFaceBookSocials => new WebElement(Driver, "//a[@href='https://www.facebook.com/BrightestNV']",Selector.Xpath);
        public IButton BrightestTwitterSocials => new WebElement(Driver, "//a[@href='https://twitter.com/brightestnv']", Selector.Xpath);
        public IButton BrightestInstagramSocials => new WebElement(Driver, "//a[@href='https://www.instagram.com/brightestsoftwarequality/']",Selector.Xpath);
        public IButton BrightestLinkedInSocials => new WebElement(Driver, "//a[@href='https://www.linkedin.com/company/brightest-nv/']", Selector.Xpath);
        public IButton RentThisMovieButton => new WebElement(Driver, "//button[@id='RentMovieButton']", Selector.Xpath);
        public IButton MoreInfoButton => new WebElement(Driver, "//a[@class='css-14nkc1e']",Selector.Xpath);
        public IButton CloseModalButton => new WebElement(Driver, "//div[@class='css-ce9ngx']//button[@id='CloseModal']",Selector.Xpath);

       
     

        //Desktop functions
        public void ClickMovieBanner() =>  MovieBannerButton.ClickOnElement();
    
        public void ClickBrightestOfficalSite() => BrightestOfficalSite.ClickOnElement();
    
        public void ClickBrightestFaceBookSocials() => BrightestFaceBookSocials.ClickOnElement();
      
        public void ClickBrightestTwitterSocials() => BrightestTwitterSocials.ClickOnElement();
  
        public void ClickBrightestInstagramSocials() => BrightestInstagramSocials.ClickOnElement();
   
        public void ClickBrightestLinkedInSocials() => BrightestLinkedInSocials.ClickOnElement();

        public void ClickRentThisMovie() => RentThisMovieButton.ClickOnElement();

        public void ClickMoreInfo() => MoreInfoButton.ClickOnElement();
      
        public void ClickCloseModal() => CloseModalButton.ClickOnElement();




        
    }
}
