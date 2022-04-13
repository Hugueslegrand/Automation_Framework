using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.Base;
using Automation_Framework.WebElementModels;


namespace Automation_Framework.Tests.Pages
{
    public class RegistrationPage :BasePage
    {
        public RegistrationPage(DriverBuilder driver) : base(driver) { }

        public IInputField RegisterFirstName => new WebElement(Driver, "//input[@id='RegisterFirstName']", Selector.Xpath);
        public IInputField RegisterLastName => new WebElement(Driver, "//input[@id='RegisterLastName']", Selector.Xpath);
        public IInputField RegisterEmail => new WebElement(Driver, "//input[@id='RegisterEmail']", Selector.Xpath);
        public IInputField RegisterPassword => new WebElement(Driver, "//input[@id='RegisterPassword']", Selector.Xpath);
        public IInputField RegisterRePassword => new WebElement(Driver, "//input[@id='RegisterRePassword']", Selector.Xpath);
        public IButton RegisterButtonComplete => new WebElement(Driver, "//button[@id='RegisterButtonComplete']",Selector.Xpath);
        //public IButton IncorrectEmail => new WebElement(Driver, "//code[normalize-space()='Please fill in a correct email-adress.']", Selector.Xpath);
        //public IButton AlreadyRegistered => new WebElement(Driver, "//code[normalize-space()='Account is already registered.']", Selector.Xpath);

        //public IButton UnmatchingPasswords1 => new WebElement(Driver, "//code[normalize-space()=\"Passwords don't match.\"]", Selector.Xpath);

        public IButton FailedRegisterMessage => new WebElement(Driver, "div[class='css-1y9e552'] code", Selector.Css);
        public IButton RegistrationWarning => new WebElement(Driver, "div[class='css-1y9e552'] code", Selector.Css);

        //Functions
        public string GetInnerText_Warning()
        {
            return RegistrationWarning.Text;
        }

        public string UserAlreadyExist()
        {
            return FailedRegisterMessage.Text;
        }
        public string IncorrectEmail()
        {
            return FailedRegisterMessage.Text;
        }
        public string PasswordDontMatch()
        {
            return FailedRegisterMessage.Text;
        }

        public void ClickRegister() => RegisterButtonComplete.ClickOnElement();
        

        public void Register(string firstName, string lastName, string email, string passwoord, string rePasswoord)
        {
            RegisterFirstName.SendKeys(firstName);
            RegisterLastName.SendKeys(lastName);
            RegisterEmail.SendKeys(email);
            RegisterPassword.SendKeys(passwoord);
            RegisterRePassword.SendKeys(rePasswoord);
            RegisterButtonComplete.ClickOnElement(); // Or ClickRegister();
        }


    }
}
