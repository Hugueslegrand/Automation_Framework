using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;
using Automation_Framework.Extensions;
using System.Linq;
using Automation_Framework.Extensions.WebDriver;

namespace Automation_Framework.Tests.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(DriverBuilder driver) : base(driver) { }


        public IButton MovieBannerButton => new WebElement(Driver, "//div[@id='Comedy Movies']//img[@id='531219']", Selector.Xpath);

        public IButton BrightestOfficalSite => new WebElement(Driver, "//a[@class='css-mi3e9x']", Selector.Xpath);
        public IButton BrightestFaceBookSocials => new WebElement(Driver, "//a[@href='https://www.facebook.com/BrightestNV']", Selector.Xpath);
        public IButton BrightestTwitterSocials => new WebElement(Driver, "//a[@href='https://twitter.com/brightestnv']", Selector.Xpath);
        public IButton BrightestInstagramSocials => new WebElement(Driver, "//a[@href='https://www.instagram.com/brightestsoftwarequality/']", Selector.Xpath);
        public IButton BrightestLinkedInSocials => new WebElement(Driver, "//a[@href='https://www.linkedin.com/company/brightest-nv/']", Selector.Xpath);
        public IButton RentThisMovieButton => new WebElement(Driver, "//button[@id='RentMovieButton']", Selector.Xpath);
        public IButton MoreInfoButton => new WebElement(Driver, "//a[@class='css-14nkc1e']", Selector.Xpath);
        public IButton CloseModalButton => new WebElement(Driver, "//div[@class='css-ce9ngx']//button[@id='CloseModal']", Selector.Xpath);
        public IButton CopyrightElement => new WebElement(Driver, ".css-6kebaf", Selector.Css);

        public IButton allLITags => new WebElement(Driver, "div", Selector.TagName);


        public IButton Movie1 => new WebElement(Driver, "602211", Selector.Id);
        public IButton Movie2 => new WebElement(Driver, "//div[@id='Comedy Movies']//img[@id='551804']", Selector.Xpath);

        public string ComedyHorizontalScrollBars = "'div[class=\"css-nlgfro\"]'";

        public object getElements()
        {

            return allLITags.getElements().First(x => x.Text == "FATMAN");

        }

        // public string GetAttributeFB(string attribute)
        // {
        //     return BrightestFaceBookSocials.GetAttribute(attribute);
        // }
        //
        // public string GetAttributeIG(string attribute)
        // {
        //     return BrightestInstagramSocials.GetAttribute(attribute);
        // }
        //
        // public string GetAttributeTW(string attribute)
        // {
        //     return BrightestTwitterSocials.GetAttribute(attribute);
        // }

        public string GetAttribute(string attribute, IButton button)
        {
            return button.GetAttribute(attribute);
        }


        public IButton RentPopUp => new WebElement(Driver, "//div[@class='notification-container--top-center']", Selector.Xpath);

        public void ScrollComedyBar()
        {
            Driver.GetElementAndScrollHorizontally(ComedyHorizontalScrollBars, 500);

        }

        public string GetInnerText_Warning()
        {
            return RentPopUp.Text;
        }


        public void ClickMovieBanner() => MovieBannerButton.ClickOnElement();

        public void ClickBrightestOfficalSite() => BrightestOfficalSite.ClickOnElement();

        public void ClickBrightestFaceBookSocials() => BrightestFaceBookSocials.ClickOnElement();

        public void ClickBrightestTwitterSocials() => BrightestTwitterSocials.ClickOnElement();

        public void ClickBrightestInstagramSocials() => BrightestInstagramSocials.ClickOnElement();

        public void ClickBrightestLinkedInSocials() => BrightestLinkedInSocials.ClickOnElement();

        public void ClickRentThisMovie() => RentThisMovieButton.ClickOnElement();

        public void ClickMoreInfo() => MoreInfoButton.ClickOnElement();

        public void ClickCloseModal() => CloseModalButton.ClickOnElement();


        public void ClickMovie1() => Movie1.ClickOnElement();
        public void ClickMovie2() => Movie2.ClickOnElement();
    }
}
