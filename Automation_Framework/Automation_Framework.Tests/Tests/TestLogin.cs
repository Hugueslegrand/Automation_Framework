using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using System.Threading;
using FluentAssertions;
using Automation_Framework.Tests.Models;
using OpenQA.Selenium;

namespace Automation_Framework.Tests.Tests
{

    public class TestLogin : BaseTest
    {
        public User UserLogin_Exist()
        {
            return new User
            {
                email = "Pirate@King.com",
                password = "onepiece111",
            };
        }
        public User UserAdminLogin_Exist()
        {
            return new User
            {
                email = "stageadmin@stageadmin.stageadmin",
                password = "StageAdmin0221!",
            };
        }

        public User UserLogin_Not_Exist()
        {
            return new User
            {
                email = "UserNotExist@brightest.be",
                password = "UserNotExist",
            };
        }

        public User UserLogin_With_An_Incorrect_EmailAdress()
        {
            return new User
            {
                email = "IncorrectEmailAdress",
                password = "IncorrectEmailAdress",
            };
        }
        public User UserLogin_With_An_Incorrect_Email_Or_Password()
        {
            return new User
            {
                email = "Pirate@King.com",
                password = "IncorrectPassword",
            };
        }


  

         [Test]
         [Description("Login as an existing user")]
         public void Test_Login_As_Existing_User()
         {
            User userLogin = UserLogin_Exist();
            Navigation navigation = new Navigation(builder);
            
            Thread.Sleep(6000);
            navigation.ClickSignIn();
       
            LoginPage loginPage = new LoginPage(builder);
        
            loginPage.Login(userLogin.email, userLogin.password);
            navigation.SignOutButton.Should();

        }
         [Test]
         [Description("Login as an existing userAdmin")]
         public void Test_Login_As_Existing_UserAdmin()
         {
            User userLogin = UserAdminLogin_Exist();
            Navigation navigation = new Navigation(builder);
            
            Thread.Sleep(6000);
            navigation.ClickSignIn();
       
            LoginPage loginPage = new LoginPage(builder);
        
            loginPage.Login(userLogin.email, userLogin.password);
            navigation.SignOutButton.Should();
            navigation.SettingsButton.Should();

        }
        [Test]
        public void Test_Scroller()
        {
            LoginPage loginPage = new LoginPage(builder);
            Thread.Sleep(6000);
            loginPage.scrollMofo();
          
       
        }


        [Test]
        [Description("Login as an NOT existing user")]
        public void Test_Login_As_Not_Existing_User()
        {
            User userLogin = UserLogin_Not_Exist();
            Navigation navigation = new Navigation(builder);

            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(userLogin.email, userLogin.password);

            loginPage.GetInnerText_Warning().Should().Be("This email has not been registered.");

            // Assert.AreEqual(loginPage.GetInnerText(),"This email has not been registered.");
        }

            
         [Test]
         [Description("Login with an Incorrect Email adress")]
         public void Test_Login_With_An_Incorrect_EmailAdress()
         {
            User userLogin = UserLogin_With_An_Incorrect_EmailAdress();
            Navigation navigation = new Navigation(builder);
            
            Thread.Sleep(6000);
            navigation.ClickSignIn();
       
            LoginPage loginPage = new LoginPage(builder);
        
            loginPage.Login(userLogin.email, userLogin.password);

            loginPage.GetInnerText_Warning().Should().Be("Please fill in a correct email-adress.");

        }  
        
         [Test]
         [Description("Login with an Incorrect Email adress or Password")]
         public void Test_Login_With_An_Incorrect_Email_Or_Password()
         {
            User userLogin = UserLogin_With_An_Incorrect_Email_Or_Password();
            Navigation navigation = new Navigation(builder);
            
            Thread.Sleep(6000);
            navigation.ClickSignIn();
       
            LoginPage loginPage = new LoginPage(builder);
        
            loginPage.Login(userLogin.email, userLogin.password);

            loginPage.GetInnerText_Warning().Should().Be("Email or password incorrect.");

        }
        
            


        ///*  [Test]
        //  public void LoginWithAdmin()
        //  {
        //      Thread.Sleep(10000);
        //      HomePage homeScreen = new HomePage(AndroidDriver);
        //      homeScreen.ClickSignInButton();
        //
        //      LoginPage loginScreen = new LoginPage(AndroidDriver);
        //      loginScreen.Login1("brent.dar@ap.be", "hond");
        //  }*/
    }
}
