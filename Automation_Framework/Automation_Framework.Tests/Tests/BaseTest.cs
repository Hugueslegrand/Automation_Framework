﻿using Automation_Framework.Builders;
using Automation_Framework.Base;
using Automation_Framework.Enums;
using Automation_Framework.Models;
using Automation_Framework.Utility;
using Automation_Framework.TestRail.Service;
using Automation_Framework.Tests.Pages;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Automation_Framework.Tests.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class BaseTest : Base.BaseTest
    {
       

        //We kunnen alle paginas builden maar als er veel pages zijn waarvan
        //een test niet gebruik van maakt zal de test trager zijn
        
        /*
        protected AdminPanelPage adminPanelPage;
        protected HomePage homePage;
        protected MyMoviesPage myMoviesPage;
        protected Navigation navigation;
        protected LoginPage loginPage;
        protected ProfilePage profilePage;
        protected RegistrationPage registrationPage;
       

        private void initPages()
        {
            navigation = new Navigation(builder);
            loginPage = new LoginPage(builder);
            adminPanelPage = new AdminPanelPage(builder);
            homePage = new HomePage(builder);
            myMoviesPage = new MyMoviesPage(builder);
            profilePage = new ProfilePage(builder);
            registrationPage = new RegistrationPage(builder);
        }
        */


        [SetUp]
        public void Setup()
        {
            
          
            builder.BuildDriver(PlatformType.Android);
           // initPages();
        }

        [TearDown]
        public void TearDown()
        {
           
            builder.CloseDriver(PlatformType.Android);
        }

    }
}
