using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using Automation_Framework.Tests.Tests.MobileTests;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests.TestMobile
{


    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestNavigationScreen : MobileBaseTest
    {
        User userLoginExist = new User("Pirate@King.com", "onepiece111");
        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        [Test, Property("caseid", "7327")]
        [Description("Navigation screen Top and Bottom ( unlogged end user ) ")]
        public void Test_Unlogged_Navigation_Layout()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);

            homeScreen.WaitSeconds(50);
            homeScreen.Logo.Should();
            homeScreen.SignInButton.Should();

            navigationScreen.HomeTab.Should();
            navigationScreen.SearchbarTab.Should();


        }
        [Test, Property("caseid", "7333")]
        [Description("Navigation screen Top and Bottom ( Logged end user )")]
        public void Test_Logged_Navigation_Layout()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);

            homeScreen.WaitSeconds(50);
           
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            loginScreen.AndroidLogin(userLoginExist.email, userLoginExist.password);
            homeScreen.WaitSeconds(4);
            homeScreen.Logo.Should();
            homeScreen.SignOutButton.Should();

            navigationScreen.HomeTab.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();
            navigationScreen.SearchbarTab.Should();


        }
        [Test, Property("caseid", "7334")]
        [Description("Navigation screen Top and Bottom ( Administrator )")]
        public void Test_Administration_Navigation_Layout()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);

            homeScreen.WaitSeconds(50);
           
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);
            homeScreen.WaitSeconds(4);

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
