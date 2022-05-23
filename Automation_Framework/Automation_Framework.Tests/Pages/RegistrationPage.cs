using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.Base;
using Automation_Framework.WebElementModels;


namespace Automation_Framework.Tests.Pages
{
    public class RegistrationPage : BasePage
    {
        public RegistrationPage(DriverBuilder driver) : base(driver) { }

        public IInputField RegisterFirstName => new WebElement(Driver, "//input[@id='RegisterFirstName']", Selector.Xpath);
        public IInputField RegisterLastName => new WebElement(Driver, "//input[@id='RegisterLastName']", Selector.Xpath);
        public IInputField RegisterEmail => new WebElement(Driver, "//input[@id='RegisterEmail']", Selector.Xpath);
        public IInputField RegisterPassword => new WebElement(Driver, "//input[@id='RegisterPassword']", Selector.Xpath);
        public IInputField RegisterRePassword => new WebElement(Driver, "//input[@id='RegisterRePassword']", Selector.Xpath);
        public IButton RegisterButtonComplete => new WebElement(Driver, "//button[@id='RegisterButtonComplete']", Selector.Xpath);
     
        public ILabel FailedRegisterMessage => new WebElement(Driver, "div[class='css-1y9e552'] code", Selector.Css);
        public ILabel RegistrationWarning => new WebElement(Driver, "div[class='css-1y9e552'] code", Selector.Css);

     


        public void Register(string firstName, string lastName, string email, string passwoord, string rePasswoord)
        {
            RegisterFirstName.SendKeys(firstName);
            RegisterLastName.SendKeys(lastName);
            RegisterEmail.SendKeys(email);
            RegisterPassword.SendKeys(passwoord);
            RegisterRePassword.SendKeys(rePasswoord);
            RegisterButtonComplete.ClickOnElement(); 
        }


    }
}
