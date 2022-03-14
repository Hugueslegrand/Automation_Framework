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
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public InputField SignInEmail => new InputField(Driver, By.XPath("//input[@id='SignInEmail']"));
        public InputField SignInPassword => new InputField(Driver, By.XPath("//input[@id='SignInPassword']"));
        public Button SignInButtonComplete => new Button(Driver, By.XPath("//button[@id='SignInButtonComplete']"));
        /*public IWebElement SignInEmail => Driver.FindElement(By.XPath("//input[@id='SignInEmail']"));
        public IWebElement SignInPassword => Driver.FindElement(By.XPath("//input[@id='SignInPassword']"));
        public IWebElement SignInButtonComplete => Driver.FindElement(By.XPath("//button[@id='SignInButtonComplete']"));*/

        public void ClickLogin() => SignInButtonComplete.ClickOnElement();
            //Driver.ClickOnElement(SignInButtonComplete);

        public void Login(string userName, string password)
        {
            SignInEmail.ClickOnElement();
            SignInEmail.SendKeys(userName);
            SignInPassword.ClickOnElement();
            SignInPassword.SendKeys(password);
            SignInButtonComplete.ClickOnElement();
        }
    }
}
