using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.Extensions.WebDriver;
using Automation_Framework.WebElementModels;
using Automation_Framework.Base;
using System.Threading;

namespace Automation_Framework.Tests.Pages
{
    public class LoginPage : BasePage
    {

        public LoginPage(DriverBuilder driver) : base(driver) { }

        public IInputField SignInEmail => new WebElement(Driver, "//input[@id='SignInEmail']", Selector.Xpath);
        public IInputField SignInPassword => new WebElement(Driver, "//input[@id='SignInPassword']", Selector.Xpath);
        public IButton SignInButtonComplete => new WebElement(Driver, "//button[@id='SignInButtonComplete']", Selector.Xpath);


        public string scroller = "'div[class=\"css-nlgfro\"]'";
        public IButton SignInPage => new WebElement(Driver, "SignIn", Selector.Id);

        //Functions
        public void ClickLogin() => SignInButtonComplete.ClickOnElement();

        public IButton LoginWarning => new WebElement(Driver, "div[class='css-1y9e552'] code", Selector.Css);

        public string GetInnerText_Warning()
        {
            return LoginWarning.Text;
        }

        public void Scroll()
        {
            Thread.Sleep(3000);
            Driver.GetElementAndScrollHorizontally(scroller, 500);
            Thread.Sleep(3000);
            Driver.GetElementAndScrollHorizontally(scroller, 1200);
            Thread.Sleep(3000);
            Driver.GetElementAndScrollHorizontally(scroller, -600);

        }

        public void Login(string userName, string password)
        {
            SignInEmail.ClickOnElement();
            SignInEmail.SendKeys(userName);
            SignInPassword.ClickOnElement();
            SignInPassword.SendKeys(password);
            SignInButtonComplete.ClickOnElement();
        }
        public void ScreenShot() => ScreenshotTaker.TakeStandardScreenshot(Driver, "FirstScreenshot");

    }
}
