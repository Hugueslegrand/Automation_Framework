using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Pages;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Automation_Framework.Tests.Tests
{
    [Property("runname", "TestWatchMovie")]
    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestWatchMovie : BaseTest
    {
        User Watcher = new User("Test", "Watcher", "watchmovie@button.test", "watchmovie", "watchmovie");
        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        [Test, Order(1)]
        [Description("Test: WatchMovie Setup Loop - register and buy 5 credits, then rent movie not yet rented")]
        public void Test_RentMovieButton_NotYetRented()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");

            navigation.RegisterButton.ClickOnElement();
            RegistrationPage registrationPage = new RegistrationPage(builder);
            registrationPage.Register(Watcher.firstName, Watcher.lastName, Watcher.email, Watcher.password, Watcher.rePassword);

            navigation.SignInButton.ClickOnElement();
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(Watcher.email, Watcher.password);
            navigation.WaitSeconds(4);
            navigation.ProfileButton.ClickOnElement();
            ProfilePage profilePage = new ProfilePage(builder);
            navigation.WaitSeconds(1);
            profilePage.AddCreditsButton.ClickOnElement();
            navigation.WaitSeconds(1);
            profilePage.AmountOfCredits.ClickOnElement();
            profilePage.FillAmountOfCredits("5");
            profilePage.BuyCreditsButton.ClickOnElement();
            navigation.WaitSeconds(4);
            navigation.Logo.ClickOnElement();
            HomePage homePage = new HomePage(builder);
            navigation.WaitSeconds(2);
            homePage.Movie1.ClickOnElement();
            navigation.WaitSeconds(2);
            homePage.RentThisMovieButton.ClickOnElement();
            homePage.ScrollElementIntoView(homePage.RentPopUp.GetElement());
            navigation.WaitSeconds(1);
            homePage.RentPopUp.Text.Should().Contain("added to My Movies!");
        }


        [Test,Order(2), Property("caseid", "7300")]
        [Description("Test: User is able to watch rented and available movies")]
        public void Test_WatchMovie()
        {
            Navigation navigation = new Navigation(builder);

            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(Watcher.email, Watcher.password);
            //loginPage.ScreenShot();

            navigation.MyMovieButton.ClickOnElement();
            //Thread.Sleep(2000);

            MyMoviesPage watchMovie = new MyMoviesPage(builder);
            watchMovie.WatchNowButton.ClickOnElement();
            //Thread.Sleep(2000);

            watchMovie.CloseModalButton.ClickOnElement();
        }

        [Test,Order(3), Property("caseid", "7299")]
        [Description("Test: Visual Layout Of Order Page")]
        public void Test_Visual_Layout_Of_Order_Page()
        {
            Navigation navigation = new Navigation(builder);

            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(Watcher.email, Watcher.password);
            


            navigation.MyMovieButton.ClickOnElement();

            MyMoviesPage watchMovie = new MyMoviesPage(builder);
            watchMovie.WaitSeconds(3);
            watchMovie.MovieTitle.Text.Should().Be("FATMAN");

            string date = DateTime.UtcNow.AddDays(7).ToString("dd-MM-yyyy").Replace('-', '/');
          
            watchMovie.MovieAvailableDate.Text.Should().Be($"AVAILABLE UNTIL: {date}");
            watchMovie.WatchNowButton.ClickOnElement();
           

            watchMovie.CloseModalButton.ClickOnElement();
        }

        [Test, Order(4)]
        [Description("Test: WatchMovie - remove watcher for continious testing")]
        public void Test_RemoveRenter()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userAdminExist.email, userAdminExist.password);

            navigation.SettingsButton.Should();
            navigation.SettingsButton.ClickOnElement();

            AdminPanelPage adminPanelPage = new AdminPanelPage(builder);
            adminPanelPage.UsersMenu.ClickOnElement();
            adminPanelPage.WaitSeconds(1);
            adminPanelPage.RemoveUserByEmail(Watcher.email);
            adminPanelPage.WaitSeconds(1);
        }

    }
}