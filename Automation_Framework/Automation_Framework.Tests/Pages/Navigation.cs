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
        public Button SignInButton => new Button(Driver, By.XPath("//button[@id='SignInButton']"));
        public InputField SearchBar => new InputField(Driver, By.XPath("//input[@id='mui-68877']"));
        public Button Logo => new Button(Driver, By.XPath("//img[@id='Logo']"));
        public Button RegisterButton => new Button(Driver, By.XPath("//button[@id='RegisterButton']"));
        public Button MyMovieButton => new Button(Driver, By.XPath("//a[@href='#/orders']//button[@id='OrdersPageButton']"));
        public Button ProfileButton => new Button(Driver, By.XPath("//a[@href='#/profile']//button[@id='OrdersPageButton']"));
        public Button SignOutButton => new Button(Driver, By.XPath("//button[@id='SignOutButton']"));
        public Button SettingsButton => new Button(Driver, By.XPath("//*[name()='path' and contains(@d,'M413.967 2')]"));

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

        public void Wait() => WaitExtension.Wait(Driver);
    }
}
