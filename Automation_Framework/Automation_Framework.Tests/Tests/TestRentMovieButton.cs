using Automation_Framework.Tests.Pages;
using NUnit.Framework;

using FluentAssertions;
using Automation_Framework.Tests.Models;



namespace Automation_Framework.Tests.Tests
{
    [TestFixture]

    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestRentMovieButton : BaseTest
    {
        User Renter = new User("Test", "Renter", "rentmovie@button.test", "rentmovie", "rentmovie");
        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        [Test, Order(1), Property("caseid", "7303")]
        [Description("Test: RentMovieButton Setup Loop - register and buy 5 credits, then rent movie not yet rented")]
        public void Test_RentMovieButton_NotYetRented()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");

            navigation.RegisterButton.ClickOnElement();
            RegistrationPage registrationPage = new RegistrationPage(builder);
            registrationPage.Register(Renter.firstName, Renter.lastName, Renter.email, Renter.password, Renter.rePassword);

            navigation.SignInButton.ClickOnElement();
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(Renter.email, Renter.password);

            navigation.ProfileButton.ClickOnElement();
            ProfilePage profilePage = new ProfilePage(builder);
            profilePage.AddCreditsButton.ClickOnElement();
            profilePage.AmountOfCredits.ClickOnElement();
            profilePage.FillAmountOfCredits("5");
            profilePage.BuyCreditsButton.ClickOnElement();

            navigation.Logo.ClickOnElement();
            HomePage homePage = new HomePage(builder);
            homePage.Movie1.ClickOnElement();
            homePage.RentThisMovieButton.ClickOnElement();
            homePage.RentPopUp.Text.Should().Contain("added to My Movies!");
        }

        [Test, Order(2), Property("caseid", "7304")]
        [Description("Test: RentMovieButton - movie is already rented")]
        public void TestRentMovieButtonAlreadyRented()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(Renter.email, Renter.password);

            HomePage homePage = new HomePage(builder);
            homePage.Movie1.ClickOnElement();
            homePage.RentThisMovieButton.ClickOnElement();
            homePage.RentPopUp.Text.Should().Contain("You already rented this movie");
        }

        [Test, Order(3), Property("caseid", "7305")]
        [Description("Test: RentMovieButton - not suffcient credits")]
        public void Test_RentMovieButton_InsufficientCredits()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(Renter.email, Renter.password);

            HomePage homePage = new HomePage(builder);
            homePage.Movie2.ClickOnElement();
            homePage.RentThisMovieButton.ClickOnElement();
            homePage.RentPopUp.Text.Should().Contain("Insufficient credits.");
        }

        [Test, Order(4), Property("caseid", "7306")]
        [Description("Test: RentMovieButton - renting movie while not logged in")]
        public void Test_RentMovieButton_Unsigned()
        {

            HomePage homePage = new HomePage(builder);
            homePage.WaitSeconds(6);
            homePage.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            homePage.Movie1.ClickOnElement();
            homePage.RentThisMovieButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.SignInPage.Should();
            loginPage.WaitSeconds(3);
        }

        [Test, Order(5), Property("caseid", "7307")]
        [Description("Test: RentMovieButton - remove renter for continious testing")]
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
            adminPanelPage.RemoveUserByEmail(Renter.email);
            adminPanelPage.WaitSeconds(1);
        }
    }
}
