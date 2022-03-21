using Automation_Framework.Builders;
using Automation_Framework.Base;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;
using Automation_Framework.Extensions.WebDriver;
using Automation_Framework.Tests.Providers;

namespace Automation_Framework.Tests.Pages
{
    public class Navigation :BasePage
    {
        public Navigation(DriverBuilder driver) : base(driver) { }
        public IButton SignInButton => new WebElement(Driver, "//button[@id='SignInButton']",Selector.Xpath);
        public IInputField SearchBar => new WebElement(Driver, "//input[@id='mui-68877']", Selector.Xpath);
        public IButton Logo => new WebElement(Driver, "//img[@id='Logo']", Selector.Xpath);
        public IButton RegisterButton => new WebElement(Driver, "//button[@id='RegisterButton']", Selector.Xpath);
        public IButton MyMovieButton => new WebElement(Driver, "//a[@href='#/orders']//button[@id='OrdersPageButton']", Selector.Xpath);
        public IButton ProfileButton => new WebElement(Driver, "//a[@href='#/profile']//button[@id='OrdersPageButton']", Selector.Xpath);
        public IButton SignOutButton => new WebElement(Driver, "//button[@id='SignOutButton']", Selector.Xpath);
        public IButton SettingsButton => new WebElement(Driver, "//*[name()='path' and contains(@d,'M413.967 2')]", Selector.Xpath);

        /*public IWebElement SearchBar => Driver.FindElement(By.XPath("//input[@id='mui-68877']"));
        public IWebElement Logo => Driver.FindElement(By.XPath("//img[@id='Logo']"));

         public IWebElement SignInButton => Driver.FindElement(By.XPath("//button[@id='SignInButton']"));

        public IWebElement RegisterButton => Driver.FindElement(By.XPath("//button[@id='RegisterButton']"));


        public IWebElement MyMovieButton => Driver.FindElement(By.XPath("//a[@href='#/orders']//button[@id='OrdersPageButton']"));
        public IWebElement ProfileButton => Driver.FindElement(By.XPath("//a[@href='#/profile']//button[@id='OrdersPageButton']"));
        public IWebElement SignOutButton => Driver.FindElement(By.XPath("//button[@id='SignOutButton']"));
        public IWebElement SettingsButton => Driver.FindElement(By.XPath("//*[name()='path' and contains(@d,'M413.967 2')]"));
        */


        //Functions

       // public void surfToUrl() => Driver.OpenLink(UrlProvider.Login);
        public void ClickSearchBar() => SearchBar.ClickOnElement();
        //Driver.ClickOnElement(SearchBar);
        public void FillSearchBar(string searchBar) => SearchBar.SendKeys(searchBar);
        //SearchBar.SendKeys(searchBar);
        public void ClickLogo() => Logo.ClickOnElement();
            //Driver.ClickOnElement(Logo);
        public void ClickSignIn() => SignInButton.ClickOnElement();
        //Driver.ClickOnElement(SignInButton);
        public void ClickRegister() => RegisterButton.ClickOnElement();
        //Driver.ClickOnElement(RegisterButton);

        public void ClickMyMovie() => MyMovieButton.ClickOnElement();
        //Driver.ClickOnElement(MyMovieButton);
        public void ClickProfile() => ProfileButton.ClickOnElement();
        //Driver.ClickOnElement(ProfileButton);
        public void ClickSignOut() => SignOutButton.ClickOnElement();
        //Driver.ClickOnElement(SignOutButton);
        public void ClickSettings() => SettingsButton.ClickOnElement();
        //Driver.ClickOnElement(SettingsButton);

      //  public void Wait() => WaitExtension.Wait(Driver);
    }
}
