using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using Automation_Framework.Tests.Tests.MobileTests;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests.TestMobile
{

    [Property("runname", "TestWatchScreen")]
    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestWatchScreen : MobileBaseTest
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

            homeScreen.WaitSeconds(50);
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            loginScreen.ClickGoToRegisterScreen();
            homeScreen.WaitSeconds(4);
            registerScreen.AndroidRegister(movieWatcher.firstName,
                                           movieWatcher.lastName,
                                           movieWatcher.email,
                                           movieWatcher.password,
                                           movieWatcher.rePassword);
            homeScreen.WaitSeconds(4);
            loginScreen.AndroidLogin(movieWatcher.email, movieWatcher.password);

            homeScreen.WaitSeconds(4);

            navigationScreen.ProfileTab.AndroidClick();
            homeScreen.WaitSeconds(4);
            profileScreen.AndroidAddCreditsButton.AndroidClick();
            homeScreen.WaitSeconds(4);
            profileScreen.AndroidFillAmountOfCredits("5");
            homeScreen.WaitSeconds(4);
            profileScreen.ClickBuyCreditsButton();

            homeScreen.WaitSeconds(4);
            navigationScreen.SearchbarTab.AndroidClick();
            ///// Nog te vervolledigen homeScreen.WaitSeconds(4);

            myMoviesScreen.MovieCardTitle.AndroidText.Should().Be("The New Mutants");

            myMoviesScreen.MovieCardDate.AndroidText.Should().Be("Available until: 03/05/2022");

            myMoviesScreen.WatchMovieButton.Should();

            myMoviesScreen.ClickWatchMovieButton();
            homeScreen.WaitSeconds(4);

            myMoviesScreen.GoBackButton.AndroidClick();


        }
    }
}
