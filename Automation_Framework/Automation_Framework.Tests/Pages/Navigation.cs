using Automation_Framework.Base;
using Automation_Framework.Extensions.WebDriver;
using Automation_Framework.Tests.Providers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Pages
{
    internal class Navigation : BasePage
    {
        public Navigation(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement SearchBar => Driver.FindElement(By.XPath("//input[@id='mui-68877']"));
        public IWebElement Logo => Driver.FindElement(By.XPath("//img[@id='Logo']"));

        public IWebElement SignInButton => Driver.FindElement(By.XPath("//button[@id='SignInButton']"));

        public IWebElement RegisterButton => Driver.FindElement(By.XPath("//button[@id='RegisterButton']"));


        public IWebElement MyMovieButton => Driver.FindElement(By.XPath("//a[@href='#/orders']//button[@id='OrdersPageButton']"));
        public IWebElement ProfileButton => Driver.FindElement(By.XPath("//a[@href='#/profile']//button[@id='OrdersPageButton']"));
        public IWebElement SignOutButton => Driver.FindElement(By.XPath("//button[@id='SignOutButton']"));
        public IWebElement SettingsButton => Driver.FindElement(By.XPath("//*[name()='path' and contains(@d,'M413.967 2')]"));



        //Functions
        public void surfToUrl() => Driver.OpenLink(UrlProvider.Login);
         
        public void ClickSearchBar() => Driver.ClickOnElement(SearchBar);
        public void FillSearchBar(string searchBar) => SearchBar.SendKeys(searchBar);
        public void ClickLogo() => Driver.ClickOnElement(Logo);
        public void ClickSignIn() => Driver.ClickOnElement(SignInButton);
        public void ClickRegister() => Driver.ClickOnElement(RegisterButton);

        public void ClickMyMovie() => Driver.ClickOnElement(MyMovieButton);
        public void ClickProfile() => Driver.ClickOnElement(ProfileButton);
        public void ClickSignOut() => Driver.ClickOnElement(SignOutButton);
        public void ClickSettings() => Driver.ClickOnElement(SettingsButton);
    }
}
