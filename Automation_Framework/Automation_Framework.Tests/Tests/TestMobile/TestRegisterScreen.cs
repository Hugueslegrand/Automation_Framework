using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Tests.TestMobile
{
    public class TestRegistration : BaseTest
    {
        User registerNewUser = new User("GomuGomoNooooooJet", "Strawhatsszz", "Test@brightest.com", "biggie", "biggie");
        User registerNewUserLeadSpace = new User(" Biggie", " Smalls", " ZezzBiggie_East@Coast.com", " biggie", " biggie");
        User registerNewUserUnmatchingPasswords = new User("Biggie", "Smalls", "BiggieZ_East@Coast.com", "biggie", "biggieZZZZZZZ");
        User registerNewUserUpperCase = new User("RAKEEM", "BEST", "RAKEEMG@GMAIL.COM", "CHIPCHOP", "CHIPCHOP");
        User registerNewUserLowerCase = new User("tupac", "shakur", "2pac_wzt@coast.com", "thuglife", "thuglife");
        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");


        [Test]
        [Description("Register an user and log in to verify")]
        public void TestRegisterAnUser()
        {
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            RegisterScreen registrationPage = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);

            homeScreen.WaitSeconds(10);
            homeScreen.ClickSignInButton();

            loginScreen.ClickGoToRegisterScreen();

            registrationPage.AndroidRegister(registerNewUser.firstName, registerNewUser.lastName, registerNewUser.email, registerNewUser.password, registerNewUser.rePassword);

            loginScreen.AndroidLogin(registerNewUser.email, registerNewUser.password);

            homeScreen.SignOutButton.Should();
        }

    }
}
