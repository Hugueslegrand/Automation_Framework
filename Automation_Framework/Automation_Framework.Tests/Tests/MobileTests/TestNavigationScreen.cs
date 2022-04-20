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
    public class TestNavigationScreen : BaseTest
    {
        User userLoginExist = new User("Pirate@King.com", "onepiece111");
        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        [Test]
        [Description("Navigation screen Top and Bottom ( unlogged end user ) [2.1]")]
        public void Test_Unlogged_Navigation_Layout()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.Logo.Should();
            homeScreen.SignInButton.Should();

            navigationScreen.HomeTab.Should();
            navigationScreen.SearchbarTab.Should();


        }
        [Test]
        [Description("Navigation screen Top and Bottom ( Logged end user ) [2.2]")]
        public void Test_Logged_Navigation_Layout()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            loginScreen.AndroidLogin(userLoginExist.email, userLoginExist.password);

            homeScreen.Logo.Should();
            homeScreen.SignOutButton.Should();

            navigationScreen.HomeTab.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();
            navigationScreen.SearchbarTab.Should();


        }
        [Test]
        [Description("Navigation screen Top and Bottom ( Administrator ) [2.3]")]
        public void Test_Administration_Navigation_Layout()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);


            homeScreen.Logo.Should();
            homeScreen.SignOutButton.Should();
            homeScreen.SettingsButton.Should();

            navigationScreen.HomeTab.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();
            navigationScreen.SearchbarTab.Should();

        }
    }
}
