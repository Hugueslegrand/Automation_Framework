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
        public IWebElement SignInEmail => Driver.FindElement(By.XPath("//input[@id='SignInEmail']"));
        public IWebElement SignInPassword => Driver.FindElement(By.XPath("//input[@id='SignInPassword']"));
        public IWebElement SignInButtonComplete => Driver.FindElement(By.XPath("//button[@id='SignInButtonComplete']"));

        public void ClickLogin() => Driver.ClickOnElement(SignInButtonComplete);

        public void Login(string userName, string password)
        {
            Driver.FillFormByElement(SignInEmail,userName);
            //SignInEmail.SendKeys(userName);
            Driver.FillFormByElement(SignInPassword, password);
           // SignInPassword.SendKeys(password);
            SignInButtonComplete.Click(); // Or ClickLogin();

        }
    }
}
