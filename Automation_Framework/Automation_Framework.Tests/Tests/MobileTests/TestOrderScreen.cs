using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using Automation_Framework.Tests.Tests.MobileTests;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests.TestMobile
{
  
    [Property("runname", "TestOrderScreen")]
    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestOrderScreen : MobileBaseTest
    {
        //User userLoginExist = new User("Pirate@King.com", "onepiece111");
        User userAdminExist = new User("Stage", "Admin", "stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        ProfileScreenLabels profileScreenLabels = new ProfileScreenLabels("PROFILE", "FIRSTNAME", "LASTNAME", "EMAIL", "CREDITS");

        [Test, Property("caseid", "7335")]
        [Description("Visual layout of order screen ")]
        public void Test_Visual_Layout_Of_MyMoviesScreen()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            MyMoviesScreen myMoviesScreen = new MyMoviesScreen(builder);

            homeScreen.WaitSeconds(50);
          
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);
            homeScreen.WaitSeconds(4);
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ClickMyMoviesTab();
            homeScreen.WaitSeconds(4);
            myMoviesScreen.MovieCard.Should();
            myMoviesScreen.MovieCardImage.Should();
            myMoviesScreen.MovieCardTitle.Should();
            myMoviesScreen.MovieCardDate.Should();
            myMoviesScreen.WatchMovieButton.Should();

        }


        //Nakijken
        [Test, Property("caseid", "7336")]
        [Description("Watchability of available and expired rented movies")]
        public void Test_Watchability_Of_Available_And_Expired_Rented_Movies()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            MyMoviesScreen myMoviesScreen = new MyMoviesScreen(builder);

            homeScreen.WaitSeconds(50);
          
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);
            homeScreen.WaitSeconds(4);
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ClickMyMoviesTab();
            homeScreen.WaitSeconds(4);
            // myMoviesScreen.MovieCard.Should();
            // myMoviesScreen.MovieCardImage.Should();
            // myMoviesScreen.MovieCardTitle.Should();
            // myMoviesScreen.MovieCardDate.Should();
            myMoviesScreen.WatchMovieButton.Should();

            myMoviesScreen.GoBackButton.Should();
            myMoviesScreen.ClickGoBackButton();
            homeScreen.WaitSeconds(1);


        }
    }
}
