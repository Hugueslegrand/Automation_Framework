﻿using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests.TestMobile
{
    public class TestRentMovies : BaseTest
    {
        //User userLoginExist = new User("Pirate@King.com", "onepiece111");
        User userAdminExist = new User("Stage", "Admin", "stageadmin@stageadmin.stageadmin", "StageAdmin0221!");



        [Test]
        [Description("Visual layout of profile screen [3.1]")]
        public void Test_Visual_Layout_Of_ProfileScreen()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);


            navigationScreen.ProfileTab.Should();
            navigationScreen.ClickProfileTab();



        }
    }
}
