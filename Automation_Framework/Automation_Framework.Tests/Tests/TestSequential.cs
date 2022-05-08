using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Pages;
using Automation_Framework.Tests.Screens;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Tests
{
    public class TestSequentiel : BaseTest
    {
        User NewBrightestUser = new User("Brightest", "TestJuniors", "Testers@brightest.com", "Test123", "Test123");
        User userAdminExist = new User("Stage", "Admin", "stageadmin@stageadmin.stageadmin", "StageAdmin0221!");


        [Test]
        [Description("Login as an existing user []")]
        public void Test_Register_Login_Mobile_Web()
        {
            //Web Register an user
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.RegisterButton.ClickOnElement();

            RegistrationPage registrationPage = new RegistrationPage(builder);
            registrationPage.Register(NewBrightestUser.firstName, NewBrightestUser.lastName, NewBrightestUser.email, NewBrightestUser.password, NewBrightestUser.rePassword);

            //Web Login with the Registered user
            LoginPage loginPage = new LoginPage(builder);
            navigation.SignInButton.ClickOnElement();
            loginPage.Login(NewBrightestUser.email, NewBrightestUser.password);
            navigation.SignOutButton.Should();


            //Mobile Login the Registered user
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();


            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(NewBrightestUser.email, NewBrightestUser.password);
            NavigationScreen navigationScreen = new NavigationScreen(builder);

            homeScreen.SignOutButton.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();

        }

        [Test]
        [Description("Renting a movie on mobile and adding credits on web []")]
        public void Test_RentMovie_Mobile_AddCredits_Web()
        {
            //Web Register an user
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.RegisterButton.ClickOnElement();

            RegistrationPage registrationPage = new RegistrationPage(builder);
            registrationPage.Register(NewBrightestUser.firstName, NewBrightestUser.lastName, NewBrightestUser.email, NewBrightestUser.password, NewBrightestUser.rePassword);


            //Mobile Login the Registered user
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(NewBrightestUser.email, NewBrightestUser.password);
            NavigationScreen navigationScreen = new NavigationScreen(builder);


            //Rent a movie
            homeScreen.MovieBanner.Should();
            homeScreen.ClickMovieBanner();

            DetailsScreen detailsScreen = new DetailsScreen(builder);
            detailsScreen.Swipe(685, 1400, 685, 800, 500);
            detailsScreen.AndroidRentMovieButton.Should();
            detailsScreen.ClickRentMovieButton();
            navigationScreen.ClickMyMoviesTab();
            MyMoviesScreen myMoviesScreen = new MyMoviesScreen(builder);
            myMoviesScreen.StartRentingButton.Should();
            navigationScreen.ClickHomeTab();
            detailsScreen.ClickBackButton();


            //-- Login as admin on web and change credits on registered user --
            navigation.WaitSeconds(6);
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userAdminExist.email, userAdminExist.password);

            navigation.SettingsButton.Should();
            navigation.SettingsButton.ClickOnElement();
            navigation.WaitSeconds(6);


            AdminPanelPage adminPanelPage = new AdminPanelPage(builder);
            adminPanelPage.UsersMenu.ClickOnElement();
            adminPanelPage.EditUserByEmaill(NewBrightestUser.email);
            adminPanelPage.WaitSeconds(3);
            adminPanelPage.EditCredits("5");
            adminPanelPage.WaitSeconds(3);
            adminPanelPage.SaveButton.ClickOnElement();

            //Rent and assert in My Movies page
            homeScreen.MovieBanner.Should();
            homeScreen.ClickMovieBanner();
            detailsScreen.Swipe(685, 1400, 685, 800, 500);
            detailsScreen.AndroidRentMovieButton.Should();
            detailsScreen.ClickRentMovieButton();
            navigationScreen.ClickMyMoviesTab();
            myMoviesScreen.MovieCardTitle.Text.Should().Contain("American Pie");

            adminPanelPage.UsersMenu.ClickOnElement();
            adminPanelPage.WaitSeconds(1);
            adminPanelPage.RemoveUserByEmail(NewBrightestUser.email);
        }


    }
}