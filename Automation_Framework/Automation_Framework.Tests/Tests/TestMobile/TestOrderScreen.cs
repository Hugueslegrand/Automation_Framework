using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Tests.TestMobile
{
    public class TestOrderScreen : BaseTest
    {
        //User userLoginExist = new User("Pirate@King.com", "onepiece111");
        User userAdminExist = new User("Stage", "Admin", "stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        ProfileScreenLabels profileScreenLabels = new ProfileScreenLabels("PROFILE", "FIRSTNAME", "LASTNAME", "EMAIL", "CREDITS");

        [Test]
        [Description("Visual layout of order screen [4.1]")]
        public void Test_Visual_Layout_Of_MyMoviesScreen()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            MyMoviesScreen myMoviesScreen = new MyMoviesScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);

            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ClickMyMoviesTab();

            myMoviesScreen.MovieCard.Should();
            myMoviesScreen.MovieCardImage.Should();
            myMoviesScreen.MovieCardTitle.Should();
            myMoviesScreen.MovieCardDate.Should();
            myMoviesScreen.WatchMovieButton.Should();

        }


        //Nakijken
        [Test]
        [Description("Watchability of available and expired rented movies [4.2]")] 
        public void Test_Watchability_Of_Available_And_Expired_Rented_Movies()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            MyMoviesScreen myMoviesScreen = new MyMoviesScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);

            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ClickMyMoviesTab();

           // myMoviesScreen.MovieCard.Should();
           // myMoviesScreen.MovieCardImage.Should();
           // myMoviesScreen.MovieCardTitle.Should();
           // myMoviesScreen.MovieCardDate.Should();
            myMoviesScreen.WatchMovieButton.Should();

            myMoviesScreen.GoBackButton.Should();
            myMoviesScreen.ClickGoBackButton();



        }
    }
}
