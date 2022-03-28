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
