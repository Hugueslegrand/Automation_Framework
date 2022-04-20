using Automation_Framework.Base;
using Automation_Framework.Enums;
using Automation_Framework.Builders;
using Automation_Framework.WebElementModels;
using Automation_Framework.Extensions.WebDriver;
using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Tests;


namespace Automation_Framework.Tests.Pages
{
    public class ProfilePage : BasePage
    {
        public TestProfile testProfile = new TestProfile();



        public ProfilePage(DriverBuilder driver) : base(driver) { }

        public IButton AddCreditsButton => new WebElement(Driver, "//button[normalize-space()='add credits']", Selector.Xpath);
        public IButton BuyCreditsButton => new WebElement(Driver, "//button[normalize-space()='buy']", Selector.Xpath);
        public IButton CancelPaymentButton => new WebElement(Driver, "//a[normalize-space()='Cancel payment']", Selector.Xpath);
        public IInputField AmountOfCredits => new WebElement(Driver, "//input[@placeholder='5']", Selector.Xpath);

        public IButton FirstnameLabelWarning => new WebElement(Driver, "div[class='css-kcntxh'] div p[class='css-10izyqr']", Selector.Css);


        public IButton ProfileAvatar => new WebElement(Driver, "#SignIn > div.css-kcntxh > img.css-1wu7nrr", Selector.Css);
        public IButton FirstName => new WebElement(Driver, "#SignIn > div > div > p.css-cpr2ex", Selector.Css);
        public IButton LastName => new WebElement(Driver, "#SignIn > div > p:nth-child(4)", Selector.Css);
        public IButton Email => new WebElement(Driver, "#SignIn > div > p:nth-child(6)", Selector.Css);
        public IButton Credits => new WebElement(Driver, "#SignIn > div > p:nth-child(8)", Selector.Css);


        // public IButton FirstName => new WebElement(Driver, $"//p[normalize-space()='Brent']", Selector.Xpath);
        //
        // public IButton LastName => new WebElement(Driver, "//p[normalize-space()='Dar']", Selector.Xpath);
        // public IButton Email => new WebElement(Driver, "//p[normalize-space()='brent.dar@ap.be']", Selector.Xpath);
        // public IButton Credits => new WebElement(Driver, "//p[normalize-space()='233883.37332899997']", Selector.Xpath);


        //  public IButton ProfileAvatar => new WebElement(Driver, "//img[@class='css-1wu7nrr']", Selector.Xpath);          
        //  public IButton FirstName => new WebElement(Driver, $"//p[normalize-space()='{user.firstName}']", Selector.Xpath);
        // 
        //  public IButton LastName => new WebElement(Driver, $"//p[normalize-space()='{user.lastName}']", Selector.Xpath);
        //  public IButton Email => new WebElement(Driver, $"//p[normalize-space()='{user.email}']", Selector.Xpath);
        //  public IButton Credits => new WebElement(Driver, $"//p[normalize-space()='{user.credits}']", Selector.Xpath);



        //body div[id='root'] div[class='App'] div div div[class='css-1jf7604'] div[id='SignIn'] div[class='css-kcntxh'] p:nth-child(2)

        //public IButton Elements => new WebElement(Driver, "css-cpr2ex", Selector.ClassName);


        public string GetInnerText_ProfileAvatar()
        {
            return ProfileAvatar.Text;
        }
        public string GetInnerText_FirstName()
        {
            return FirstName.Text;
        }
        public string GetInnerText_LastName()
        {
            return LastName.Text;
        }
        public string GetInnerText_Email()
        {
            return Email.Text;
        }

        public string GetAttribute_ProfileAvatar(string attribute, IButton button)
        {
            return ProfileAvatar.GetAttribute(attribute);
        }


        public string GetAttribute_AddCreditsButton(string attribute, IButton button)
        {
            return AddCreditsButton.GetAttribute(attribute);
        }
        public string GetAttribute_BuyCreditsButton(string attribute, IButton button)
        {
            return BuyCreditsButton.GetAttribute(attribute);
        }
        public string GetAttribute_CancelPaymentButton(string attribute, IButton button)
        {
            return CancelPaymentButton.GetAttribute(attribute);
        }

        public string GetAttribute_AmountOfCredits(string attribute, IInputField input)
        {
            return AmountOfCredits.GetAttribute(attribute);
        }

        public bool ElementIsVisible(IButton button)
        {
            return button.ElementIsVisible();
        }


        //Functions
        public void ClickAddCredits() => AddCreditsButton.ClickOnElement();
        public void ClickBuyCredits() => BuyCreditsButton.ClickOnElement();
        public void ClickCancelPayment() => CancelPaymentButton.ClickOnElement();
        public void ClickAmountOfCredits() => AmountOfCredits.ClickOnElement();
        public void FillAmountOfCredits(string amountOfCredits) => AmountOfCredits.SendKeys(amountOfCredits);


    }
}