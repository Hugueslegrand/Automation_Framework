using Automation_Framework.Base;
using Automation_Framework.Enums;
using Automation_Framework.Builders;
using Automation_Framework.WebElementModels;
using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Tests;


namespace Automation_Framework.Tests.Pages
{
    public class ProfilePage : BasePage
    {
        public TestProfile testProfile = new TestProfile();
        public User user => testProfile.UserAdminLogin_Exist();
        

        public ProfilePage(DriverBuilder driver) : base(driver) { }

        public IButton AddCreditsButton => new WebElement(Driver, "//button[normalize-space()='add credits']",Selector.Xpath);
        public IButton BuyCreditsButton => new WebElement(Driver, "//button[normalize-space()='buy']",Selector.Xpath);
        public IButton CancelPaymentButton => new WebElement(Driver, "//a[normalize-space()='Cancel payment']", Selector.Xpath);
        public IInputField AmountOfCredits => new WebElement(Driver, "//input[@placeholder='5']", Selector.Xpath);

        public IButton FirstnameLabelWarning => new WebElement(Driver, "div[class='css-kcntxh'] div p[class='css-10izyqr']", Selector.Css);



          public IButton FirstName => new WebElement(Driver, "div p[class='css-cpr2ex']", Selector.Css);
          public IButton LastName => new WebElement(Driver, "p:nth-child(2)", Selector.Css);
          public IButton Email => new WebElement(Driver, "p:nth-child(4)", Selector.Css);
          public IButton Credits => new WebElement(Driver, "p:nth-child(6)", Selector.Css);
        
        
       // public IButton FirstName => new WebElement(Driver, $"//p[normalize-space()='Brent']", Selector.Xpath);
       //
       // public IButton LastName => new WebElement(Driver, "//p[normalize-space()='Dar']", Selector.Xpath);
       // public IButton Email => new WebElement(Driver, "//p[normalize-space()='brent.dar@ap.be']", Selector.Xpath);
       // public IButton Credits => new WebElement(Driver, "//p[normalize-space()='233883.37332899997']", Selector.Xpath);

       //  public IButton FirstName => new WebElement(Driver, $"//p[normalize-space()='{user.firstName}']", Selector.Xpath);
       // 
       //  public IButton LastName => new WebElement(Driver, $"//p[normalize-space()='{user.lastName}']", Selector.Xpath);
       //  public IButton Email => new WebElement(Driver, $"//p[normalize-space()='{user.email}']", Selector.Xpath);
       //  public IButton Credits => new WebElement(Driver, $"//p[normalize-space()='{user.credits}']", Selector.Xpath);

        



        //public IButton Elements => new WebElement(Driver, "css-cpr2ex", Selector.ClassName);


        public string GetInnerText_FirstName()
       {
           return FirstName.GetInnerHTML();
       }
        public string GetInnerText_LastName()
        {
            return LastName.GetInnerHTML();
        }
        public string GetInnerText_Email()
        {
            return Email.GetInnerHTML();
        }


        //Functions


        public void ClickAddCredits() => AddCreditsButton.ClickOnElement();
        public void ClickBuyCredits() => BuyCreditsButton.ClickOnElement();
        public void ClickCancelPayment() => CancelPaymentButton.ClickOnElement();
        public void ClickAmountOfCredits() => AmountOfCredits.ClickOnElement();
        public void FillAmountOfCredits(string amountOfCredits) => AmountOfCredits.SendKeys(amountOfCredits);


    }
}
