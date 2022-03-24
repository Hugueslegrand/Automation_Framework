using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.Base;
using Automation_Framework.WebElementModels;
using System;
using System.Threading;
using OpenQA.Selenium;

namespace Automation_Framework.Tests.Pages
{
    public class RegistrationPage :BasePage
    {
        public RegistrationPage(DriverBuilder driver) : base(driver) { }
        
       
        //Desktop elements
        public IInputField RegisterFirstName => new WebElement(Driver, "//input[@id='RegisterFirstName']", Selector.Xpath);
        public IInputField RegisterLastName => new WebElement(Driver, "//input[@id='RegisterLastName']", Selector.Xpath);
        public IInputField RegisterEmail => new WebElement(Driver, "//input[@id='RegisterEmail']", Selector.Xpath);
        public IInputField RegisterPassword => new WebElement(Driver, "//input[@id='RegisterPassword']", Selector.Xpath);
        public IInputField RegisterRePassword => new WebElement(Driver, "//input[@id='RegisterRePassword']", Selector.Xpath);
        public IButton RegisterButtonComplete => new WebElement(Driver, "//button[@id='RegisterButtonComplete']",Selector.Xpath);


        //Desktop Functions

        public void ClickRegister() => RegisterButtonComplete.ClickOnElement();

        public void Register(string firstName, string lastName, string email, string passwoord, string rePasswoord)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            
            RegisterFirstName.SendKeys(firstName);
            RegisterLastName.SendKeys(lastName);
            RegisterEmail.SendKeys(email);
            RegisterPassword.SendKeys(passwoord);
            RegisterRePassword.SendKeys(rePasswoord);
            RegisterButtonComplete.ClickOnElement();
            
            Thread.Sleep(1000);// Or ClickRegister();
            string validationMessage = (string)js.ExecuteScript("return arguments[0].validity.validationMessage;", RegisterFirstName.getElement());

            Console.WriteLine(validationMessage);
            Thread.Sleep(10000);
        }

        
    }
}
