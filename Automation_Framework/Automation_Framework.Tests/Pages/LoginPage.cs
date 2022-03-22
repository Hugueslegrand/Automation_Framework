using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.Extensions.WebDriver;
using Automation_Framework.WebElementModels;
using Automation_Framework.Base;
using OpenQA.Selenium.Appium.Android;

namespace Automation_Framework.Tests.Pages
{
    public class LoginPage :BasePage
    {

        public LoginPage(DriverBuilder driver) : base(driver) { }
     

        
     
        //Desktop elements

        public IInputField SignInEmail => new WebElement(Driver, "//input[@id='SignInEmail']", Selector.Xpath);
        public IInputField SignInPassword => new WebElement(Driver, "//input[@id='SignInPassword']", Selector.Xpath);
        public IButton SignInButtonComplete => new WebElement(Driver, "//button[@id='SignInButtonComplete']", Selector.Xpath);




        //Desktop functions
        public void ClickLogin() => SignInButtonComplete.ClickOnElement();
         

        public void Login(string userName, string password)
        {
            SignInEmail.ClickOnElement();
            SignInEmail.SendKeys(userName);
            SignInPassword.ClickOnElement();
            SignInPassword.SendKeys(password);
            SignInButtonComplete.ClickOnElement();
        }
        public string getInnerText()
        {
          return  SignInButtonComplete.getInnerHtml();
        }
        public void ScreenShot() => ScreenshotTaker.TakeStandardScreenshot(Driver, "FirstScreenshot");



        
    }
}
