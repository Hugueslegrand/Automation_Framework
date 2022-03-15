using Automation_Framework.Base;
using Automation_Framework.Extensions.WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Pages
{
    public class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        public InputField RegisterFirstName => new InputField(Driver, By.XPath("//input[@id='RegisterFirstName']"));
        public InputField RegisterLastName => new InputField(Driver, By.XPath("//input[@id='RegisterLastName']"));
        public InputField RegisterEmail => new InputField(Driver, By.XPath("//input[@id='RegisterEmail']"));
        public InputField RegisterPassword => new InputField(Driver, By.XPath("//input[@id='RegisterPassword']"));
        public InputField RegisterRePassword => new InputField(Driver, By.XPath("//input[@id='RegisterRePassword']"));
        public Button RegisterButtonComplete => new Button(Driver, By.XPath("//button[@id='RegisterButtonComplete']"));


        //Functions

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

        public void ScreenShot() => ScreenshotTaker.TakeStandardScreenshot(Driver, "RegistrationScreenshot");

    }
}
