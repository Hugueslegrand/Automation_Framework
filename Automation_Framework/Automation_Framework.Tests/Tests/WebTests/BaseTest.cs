using Automation_Framework.Builders;
using Automation_Framework.Base;
using Automation_Framework.Enums;
using Automation_Framework.Models;
using Automation_Framework.Utilities;
using Automation_Framework.TestRail.Service;
using Automation_Framework.Tests.Pages;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Automation_Framework.Tests.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class BaseTest : TestRailBaseTest
    {

        public DriverBuilder builder = new DriverBuilder();

  
       

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
            
          
            builder.BuildDriver(PlatformType.Desktop);
      
            Log.StartTestCase((string)TestContext.CurrentContext.Test.Properties.Get("Description"));
            // initPages();
        }

        [TearDown]
        public void TearDown()
        {
           
            builder.CloseDriver(PlatformType.Desktop);
           
            Log.EndTestCase(TestContext.CurrentContext.Result.Message);
        }

    }
}
