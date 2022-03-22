using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using System;
using System.Threading;


namespace Automation_Framework.Tests.Tests
{
    public class TestLogin : BaseTest
    {


        [Test]
        [Description("Login as administrator")]
        public void Test_LoginAsAdmin_POM()
        {
            Navigation navigation = new Navigation(builder);
           
            Thread.Sleep(6000);
            navigation.ClickSignIn();
           
            LoginPage loginPage = new LoginPage(builder);

            Assert.AreEqual(loginPage.getInnerText(), "login");
             
            loginPage.Login("brent.dar@ap.be", "hond");
   
        }
       [Test]
        public void LoginWithAdmin()
        {
            Thread.Sleep(20000);
            HomePage homeScreen = new HomePage(builder);
            homeScreen.ClickSignInButton();

            LoginPage loginScreen = new LoginPage(builder);
            loginScreen.AndroidLogin("brent.dar@ap.be", "hond");
        }
    }
}
