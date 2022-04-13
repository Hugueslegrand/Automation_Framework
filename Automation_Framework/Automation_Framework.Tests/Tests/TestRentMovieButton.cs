using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using System.Threading;
using FluentAssertions;
using Automation_Framework.Tests.Models;



namespace Automation_Framework.Tests.Tests
{
    public class TestRentMovieButton : BaseTest
    {
        User Renter = new User("Test", "Renter", "rentmovie@button.test", "rentmovie", "rentmovie");
        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        [Test, Order(1)]
        [Description("Test: RentMovieButton Setup Loop - register and buy 5 credits, then rent movie not yet rented")]
        public void Test_RentMovieButton_NotYetRented()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);

            navigation.ClickRegister();
            RegistrationPage registrationPage = new RegistrationPage(builder);
            registrationPage.Register(Renter.firstName, Renter.lastName, Renter.email, Renter.password, Renter.rePassword);

            navigation.ClickSignIn();
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(Renter.email, Renter.password);

            navigation.ClickProfile();
            ProfilePage profilePage = new ProfilePage(builder);
            profilePage.ClickAddCredits();
            profilePage.ClickAmountOfCredits();
            profilePage.FillAmountOfCredits("5");
            profilePage.ClickBuyCredits();

            navigation.ClickLogo();
            HomePage homePage = new HomePage(builder);
            homePage.ClickMovie1();
            homePage.ClickRentThisMovie();
            homePage.GetInnerText_Warning().Should().Contain("added to My Movies!");
        }

        [Test, Order(2)]
        [Description("Test: RentMovieButton - movie is already rented")]
        public void TestRentMovieButtonAlreadyRented()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ClickSignIn();
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(Renter.email, Renter.password);

            HomePage homePage = new HomePage(builder);
            homePage.ClickMovie1();
            homePage.ClickRentThisMovie();
            homePage.GetInnerText_Warning().Should().Contain("You already rented this movie");
        }

        [Test, Order(3)]
        [Description("Test: RentMovieButton - not suffcient credits")]
        public void Test_RentMovieButton_InsufficientCredits()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ClickSignIn();
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(Renter.email, Renter.password);

            HomePage homePage = new HomePage(builder);
            homePage.ClickMovie2();
            homePage.ClickRentThisMovie();
            homePage.GetInnerText_Warning().Should().Contain("Insufficient credits.");
        }

        [Test, Order(4)]
        [Description("Test: RentMovieButton - renting movie while not logged in")]
        public void Test_RentMovieButton_Unsigned()
        {
            
            HomePage homePage = new HomePage(builder);
            homePage.WaitSeconds(6);
            homePage.ClickMovie1();
            homePage.ClickRentThisMovie();
            
            LoginPage loginPage = new LoginPage(builder);
            loginPage.SignInPage.Should();
            loginPage.WaitSeconds(3);
        }

        [Test, Order(5)]
        [Description("Test: RentMovieButton - remove renter for continious testing")]
        public void Test_RemoveRenter()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ClickSignIn();
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userAdminExist.email, userAdminExist.password);

            navigation.SettingsButton.Should();
            navigation.SettingsButton.ClickOnElement();

            AdminPanelPage adminPanelPage = new AdminPanelPage(builder);
            adminPanelPage.UsersMenu.ClickOnElement();
            adminPanelPage.WaitSeconds(1);
            adminPanelPage.RemoveButtonUserByEmail(Renter.email);
            adminPanelPage.WaitSeconds(1);
        }
    }
}
