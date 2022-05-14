using Automation_Framework.Enums;
using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Pages;
using Automation_Framework.Tests.Screens;
using Automation_Framework.Tests.Tests.MobileTests;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Automation_Framework.Tests.Tests.TestMobile
{

   
    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestWatchScreen : MobileBaseTest
    {
        User userLoginExist = new User("Pirate@King.com", "onepiece111");
        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");
        User movieWatcher = new User("Movie", "Watcher", "movieWatcher23@brightest.be", "watchmovie", "watchmovie");

        [Test, Order(1), Property("caseid", "7353")]
        [Description("Necessary player-elements are present and work accordingly")]
        public void Test_Necessary_Element_Are_Present_And_Work()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            MyMoviesScreen myMoviesScreen = new MyMoviesScreen(builder);
            RegisterScreen registerScreen = new RegisterScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);
            SearchScreen searchScreen = new SearchScreen(builder);
            DetailsScreen detailsScreen = new DetailsScreen(builder);

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
            navigationScreen.WaitSeconds(4);
            searchScreen.AndroidSearchbar.AndroidSendKeys("The New Mutants");
            searchScreen.AndroidMoreInfoButton.AndroidClick();
            detailsScreen.WaitSeconds(4);
            detailsScreen.Swipe(685, 1400, 685, 800, 500);
            detailsScreen.AndroidRentMovieButton.AndroidClick();
            detailsScreen.WaitSeconds(4);
            navigationScreen.MyMoviesTab.AndroidClick();
            navigationScreen.WaitSeconds(5);

            ///// Nog te vervolledigen homeScreen.WaitSeconds(4);

            myMoviesScreen.MovieCardTitle.AndroidText.Should().Be("The New Mutants");
            string date = DateTime.Today.AddDays(7).ToString("dd-MM-yyyy").Replace('-', '/');

            myMoviesScreen.MovieCardDate.AndroidText.Should().Be($"Available until: {date}");

            myMoviesScreen.WatchMovieButton.Should();

            myMoviesScreen.ClickWatchMovieButton();
            homeScreen.WaitSeconds(4);
            myMoviesScreen.GoBackButton.AndroidClick();
        }

        [Test, Order(2), Property("caseid", "7362")]
        [Description("Remove Watcher user for continious testing")]
        public void Test_RemoveWatcherUser()
        {
            builder.BuildDriver(PlatformType.Desktop);
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userAdminExist.email, userAdminExist.password);


            navigation.SettingsButton.ClickOnElement();

            AdminPanelPage adminPanelPage = new AdminPanelPage(builder);
            adminPanelPage.UsersMenu.ClickOnElement();
            adminPanelPage.WaitSeconds(1);
            adminPanelPage.RemoveUserByEmail(movieWatcher.email);
           
            adminPanelPage.WaitSeconds(1);
            builder.CloseDriver(PlatformType.Desktop);
        }
    }
}
