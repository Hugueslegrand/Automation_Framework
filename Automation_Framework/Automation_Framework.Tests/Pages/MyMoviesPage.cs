using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;


namespace Automation_Framework.Tests.Pages
{
    public class MyMoviesPage : BasePage
    {

        public MyMoviesPage(DriverBuilder driver) : base(driver) { }

      
        //Desktop elements
        public IButton WatchNowButton => new WebElement(Driver, "//button[normalize-space()='Watch now']", Selector.Xpath);
        public IButton CloseModalButton => new WebElement(Driver, "//div[@class='css-ce9ngx']//button[@id='CloseModal']",Selector.Xpath);




        //Desktop Functions

        public void ClickWatchNow() => WatchNowButton.ClickOnElement();
        public void ClickCloseModal() => CloseModalButton.ClickOnElement();

        

    }
}
