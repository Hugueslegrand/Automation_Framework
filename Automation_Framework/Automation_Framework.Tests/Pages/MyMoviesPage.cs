using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;


namespace Automation_Framework.Tests.Pages
{
    public class MyMoviesPage : BasePage
    {

        public MyMoviesPage(DriverBuilder driver) : base(driver) { }

        

        public IButton MovieTitle => new WebElement(Driver, "//p[@class='css-49l3oe']", Selector.Xpath);
        public IButton MovieAvailableDate => new WebElement(Driver, "//p[@class='css-1l8ljr1']", Selector.Xpath);
        public IButton MovieHoverPoster => new WebElement(Driver, "//img[@class='testing css-8cfhcr']", Selector.Xpath);
        public IButton MovieHoverTitle => new WebElement(Driver, "//p[@class='css-49l3oe']", Selector.Xpath);
        public IButton MovieHoverDescription => new WebElement(Driver, "//p[@class='css-1sivm4u']", Selector.Xpath);
        public IButton MovieHoverActorImage => new WebElement(Driver, "//img[@class='css-8ut8n4']", Selector.Xpath);
        //public IButton MovieHoverRealName => new WebElement(Driver, "//p[@class='css-1sivm4u']", Selector.Xpath);
        //public IButton MovieHoverActorName => new WebElement(Driver, "//p[@class='css-1sivm4u']", Selector.Xpath);



        public IButton WatchNowButton => new WebElement(Driver, "//button[normalize-space()='Watch now']", Selector.Xpath);
        public IButton CloseModalButton => new WebElement(Driver, "//div[@class='css-ce9ngx']//button[@id='CloseModal']",Selector.Xpath);


        public string GetInnerText_MovieTitle()
        {
            return MovieTitle.GetInnerHTML();
        }
        public string GetInnerText_MovieAvailableDate()
        {
            return MovieAvailableDate.GetInnerHTML();
        }

        //Functions

        public void ClickWatchNow() => WatchNowButton.ClickOnElement();
        public void ClickCloseModal() => CloseModalButton.ClickOnElement();

    }
}
