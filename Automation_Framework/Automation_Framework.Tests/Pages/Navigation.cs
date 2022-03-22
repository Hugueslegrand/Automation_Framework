using Automation_Framework.Builders;
using Automation_Framework.Base;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;
using Automation_Framework.Extensions.WebDriver;


namespace Automation_Framework.Tests.Pages
{
    public class Navigation :BasePage
    {
        public Navigation(DriverBuilder driver) : base(driver) { }

        
        //Desktop elements
        public IButton SignInButton => new WebElement(Driver, "//button[@id='SignInButton']",Selector.Xpath);
        public IInputField SearchBar => new WebElement(Driver, "//input[@id='mui-68877']", Selector.Xpath);
        public IButton Logo => new WebElement(Driver, "//img[@id='Logo']", Selector.Xpath);
        public IButton RegisterButton => new WebElement(Driver, "//button[@id='RegisterButton']", Selector.Xpath);
        public IButton MyMovieButton => new WebElement(Driver, "//a[@href='#/orders']//button[@id='OrdersPageButton']", Selector.Xpath);
        public IButton ProfileButton => new WebElement(Driver, "//a[@href='#/profile']//button[@id='OrdersPageButton']", Selector.Xpath);
        public IButton SignOutButton => new WebElement(Driver, "//button[@id='SignOutButton']", Selector.Xpath);
        public IButton SettingsButton => new WebElement(Driver, "//*[name()='path' and contains(@d,'M413.967 2')]", Selector.Xpath);


        //Desktop Functions

        public void ClickSearchBar() => SearchBar.ClickOnElement();
        public void FillSearchBar(string searchBar) => SearchBar.SendKeys(searchBar);
        public void ClickLogo() => Logo.ClickOnElement();
        public void ClickSignIn() => SignInButton.ClickOnElement();
        public void ClickRegister() => RegisterButton.ClickOnElement();
        public void ClickMyMovie() => MyMovieButton.ClickOnElement();
        public void ClickProfile() => ProfileButton.ClickOnElement();
        public void ClickSignOut() => SignOutButton.ClickOnElement();
        public void ClickSettings() => SettingsButton.ClickOnElement();


        

    }
}
