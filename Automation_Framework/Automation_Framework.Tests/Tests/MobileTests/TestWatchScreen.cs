using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests.TestMobile
{
    public class TestWatchScreen:BaseTest
    {
        User userLoginExist = new User("Pirate@King.com", "onepiece111");
        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        [Test]
        [Description("Necessary player-elements are present and work accordingly")]
        public void Test_Necessary_Element_Are_Present_And_Work()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            MyMoviesScreen myMoviesScreen = new MyMoviesScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);

            navigationScreen.ClickMyMoviesTab();

            myMoviesScreen.MovieCardTitle.Text.Should().Be("The New Mutants");

            myMoviesScreen.MovieCardDate.Text.Should().Be("Available until: 03/05/2022");

            myMoviesScreen.WatchMovieButton.Should();

            myMoviesScreen.ClickWatchMovieButton();

            myMoviesScreen.GoBackButton.AndroidClick();


        }
    }
}
