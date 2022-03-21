﻿using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.Extensions.WebDriver;
using Automation_Framework.WebElementModels;
using Automation_Framework.Base;


namespace Automation_Framework.Tests.Pages
{
    public class LoginPage :BasePage
    {

        public LoginPage(DriverBuilder driver) : base(driver) { }
        /*  public LoginPage(AppiumDriver<AndroidElement> driver) : base(driver)
          {
          }*/

        //Mobile elements
        /*  public AndroidElement BackButton => AndroidDriver.FindElementByXPath("//android.widget.Button[@content-desc=\"goBack\"]/android.widget.TextView");

          public AndroidElement SignInEmail1 => AndroidDriver.FindElementByXPath("//android.widget.EditText[@content-desc=\"emailTxt\"]");
          public AndroidElement SignInPassword1 => AndroidDriver.FindElementByXPath("//android.widget.EditText[@content-desc=\"passwordTxt\"]");
          public AndroidElement SignInButtonComplete1 => AndroidDriver.FindElementByXPath("//android.view.ViewGroup[@content-desc=\"submitBtn\"]");
          public AndroidElement GoToRegisterScreen => AndroidDriver.FindElementByXPath("//android.view.ViewGroup[@content-desc=\"not registered yet button\"]/android.widget.TextView");
        */
        //Desktop elements
        public IInputField SignInEmail => new WebElement(Driver, "//input[@id='SignInEmail']", Selector.Xpath);
        public IInputField SignInPassword => new WebElement(Driver, "//input[@id='SignInPassword']", Selector.Xpath);
        public IButton SignInButtonComplete => new WebElement(Driver, "//button[@id='SignInButtonComplete']", Selector.Xpath);


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
       public void ScreenShot() => ScreenshotTaker.TakeStandardScreenshot(Driver, "FirstScreenshot");

        //Mobile methods
      /*  public void ClickBackButton() =>BackButton.Click();
        public void ClickEmail() => SignInEmail1.Click();
        public void ClickPassword() => SignInPassword1.Click();
        public void ClickLoginButton() => SignInButtonComplete1.Click();
        public void ClickGoToRegisterScreen() => GoToRegisterScreen.Click();

        public void Login1(string userName, string password)
        {
            SignInEmail1.SendKeys(userName);
            SignInPassword1.SendKeys(password);
            SignInButtonComplete1.Click(); // Or ClickLogin();

        }*/
    }
}
