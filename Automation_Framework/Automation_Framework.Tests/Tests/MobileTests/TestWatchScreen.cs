using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests.MobileTests
{
    [TestFixture]

    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestWatchScreen:BaseTest
    {
        User userLoginExist = new User("Pirate@King.com", "onepiece111");
        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");
        User movieWatcher = new User("Movie", "Watcher", "movieWatcher23@brightest.be", "watchmovie", "watchmovie");

        [Test, Property("caseid", "7353")]
        [Description("Necessary player-elements are present and work accordingly")]
        public void Test_Necessary_Element_Are_Present_And_Work()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            MyMoviesScreen myMoviesScreen = new MyMoviesScreen(builder);
            RegisterScreen registerScreen = new RegisterScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.ClickSignInButton();

            loginScreen.ClickGoToRegisterScreen();

            registerScreen.AndroidRegister(movieWatcher.firstName,
                                           movieWatcher.lastName,
                                           movieWatcher.email,
                                           movieWatcher.password,
                                           movieWatcher.rePassword);

            loginScreen.AndroidLogin(movieWatcher.email, movieWatcher.password);



            navigationScreen.ProfileTab.AndroidClick();
            profileScreen.AndroidAddCreditsButton.AndroidClick();
            profileScreen.AndroidFillAmountOfCredits("5");
            profileScreen.ClickBuyCreditsButton();

            navigationScreen.SearchbarTab.AndroidClick();
            ///// Nog te vervolledigen

            myMoviesScreen.MovieCardTitle.Text.Should().Be("The New Mutants");

            myMoviesScreen.MovieCardDate.Text.Should().Be("Available until: 03/05/2022");

            myMoviesScreen.WatchMovieButton.Should();

            myMoviesScreen.ClickWatchMovieButton();

            myMoviesScreen.GoBackButton.AndroidClick();


        }
    }
}
