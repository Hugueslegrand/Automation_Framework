using Automation_Framework.Base;
using Automation_Framework.Enums;
using Automation_Framework.Builders;
using Automation_Framework.WebElementModels;



namespace Automation_Framework.Tests.Pages
{
    public class ProfilePage : BasePage
    {
     

        public ProfilePage(DriverBuilder driver) : base(driver) { }

        public IButton AddCreditsButton => new WebElement(Driver, "//button[normalize-space()='add credits']", Selector.Xpath);
        public IButton BuyCreditsButton => new WebElement(Driver, "//button[normalize-space()='buy']", Selector.Xpath);
        public IButton CancelPaymentButton => new WebElement(Driver, "//a[normalize-space()='Cancel payment']", Selector.Xpath);
        public IInputField AmountOfCredits => new WebElement(Driver, "//input[@placeholder='5']", Selector.Xpath);

        public ILabel FirstnameLabelWarning => new WebElement(Driver, "div[class='css-kcntxh'] div p[class='css-10izyqr']", Selector.Css);


        public IButton ProfileAvatar => new WebElement(Driver, "#SignIn > div.css-kcntxh > img.css-1wu7nrr", Selector.Css);
        public IParagraph FirstName => new WebElement(Driver, "#SignIn > div > div > p.css-cpr2ex", Selector.Css);
        public IParagraph LastName => new WebElement(Driver, "#SignIn > div > p:nth-child(4)", Selector.Css);
        public IParagraph Email => new WebElement(Driver, "#SignIn > div > p:nth-child(6)", Selector.Css);
        public IParagraph Credits => new WebElement(Driver, "#SignIn > div > p:nth-child(8)", Selector.Css);


       
      
        public void FillAmountOfCredits(string amountOfCredits) => AmountOfCredits.SendKeys(amountOfCredits);


    }
}