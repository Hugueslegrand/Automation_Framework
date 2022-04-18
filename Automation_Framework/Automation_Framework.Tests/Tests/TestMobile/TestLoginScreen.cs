﻿using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Tests.TestMobile
{

    public class TestLoginScreen : BaseTest
    {
        User userLoginExist = new User("Pirate@King.com", "onepiece111");

        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        User userNonExist = new User("UserNotExist@brightest.be", "UserNotExist");

        User userIncorrectEmail = new User("IncorrectEmailAdress", "IncorrectEmailAdress");

        User userIncorrectPassword = new User("Pirate@King.com", "IncorrectPassword");

       //[Test]
       //[Description("Login as administrator")]
       //public void Test_LoginAsAdmin_POM()
       //{
       //    NavigationScreen navigation = new NavigationScreen(builder);
       //
       //    Thread.Sleep(6000);
       //    navigation.ClickSignIn();
       //
       //    LoginScreen loginPage = new LoginScreen(builder);
       //
       //    //Assert.AreEqual(loginPage.getInnerText(), "login");
       //
       //    loginPage.Login("brent.dar@ap.be", "hond123");
       //
       //    navigation.ClickMyMovie();
       //
       //    MyMoviesPage myMoviesPage = new MyMoviesPage(builder);
       //    //Remove selenium
       //    IList<IWebElement> test = myMoviesPage.getElements();
       //    foreach (var item in test)
       //    {
       //        item.FindElement(By.ClassName("css-49l3oe"));
       //    }
       //    //Assert.AreEqual(myMoviesPage.getElements(), "login");
       //
       //
       //
       //}


        [Test]
        [Description("Login as an existing user []")]
        public void Test_Unlogged_Layout()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
        }

       [Test]
       [Description("Login as an existing user []")]
       public void Test_Login_As_Existing_User()
       {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            LoginScreen loginPage = new LoginScreen(builder);
            loginPage.AndroidLogin(userLoginExist.email, userLoginExist.password);
            NavigationScreen navigation = new NavigationScreen(builder);

            homeScreen.SignOutButton.Should();
            navigation.MyMoviesTab.Should();
            navigation.ProfileTab.Should();
       }

        
         [Test]
         [Description("Login as an existing userAdmin []")]
         public void Test_Login_As_Existing_UserAdmin()
         {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);
            
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            homeScreen.SignOutButton.Should();
            homeScreen.SettingsButton.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();

         }

        [Test]
        [Description("Login as an NOT existing user")]
        public void Test_Login_As_Not_Existing_User()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userNonExist.email, userNonExist.password);
            loginScreen.GetInnerText_Warning().Should().Be("This email has not been registered.");

        }


         [Test]
         [Description("Login with an Incorrect Email adress")]
         public void Test_Login_With_An_Incorrect_EmailAdress()
         {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userIncorrectEmail.email, userIncorrectEmail.password);
            loginScreen.GetInnerText_Warning().Should().Be("Please fill in a correct email-adress.");
         }
        
         [Test]
         [Description("Login with an Incorrect Email adress or Password")]
         public void Test_Login_With_An_Incorrect_Email_Or_Password()
         {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userIncorrectPassword.email, userIncorrectPassword.password);
            loginScreen.GetInnerText_Warning().Should().Be("Email or password incorrect.");
         }
    }
}
