using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using Automation_Framework.Tests.Tests.MobileTests;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests.TestMobile
{

   
    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestLoginScreen : MobileBaseTest
    {
        User userLoginExist = new User("Pirate@King.com", "onepiece111");

        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        User userNonExist = new User("UserNotExist@brightest.be", "UserNotExist");

        User userIncorrectEmail = new User("IncorrectEmailAdress", "IncorrectEmailAdress");

        User userIncorrectPassword = new User("Pirate@King.com", "IncorrectPassword");



       

        [Test, Property("caseid", "7328")]
        [Description("Login as an existing user ")]
        public void Test_Login_As_Existing_User()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(50);
        
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userLoginExist.email, userLoginExist.password);
            homeScreen.WaitSeconds(4);
            NavigationScreen navigationScreen = new NavigationScreen(builder);

            homeScreen.SignOutButton.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();
        }


        [Test, Property("caseid", "7329")]
        [Description("Login as an existing userAdmin")]
        public void Test_Login_As_Existing_UserAdmin()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(50);

         
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);
            homeScreen.WaitSeconds(4);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            homeScreen.SignOutButton.Should();
            homeScreen.SettingsButton.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();

        }

        [Test, Property("caseid", "7330")]
        [Description("Login as an NOT existing user ")]
        public void Test_Login_As_Not_Existing_User()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(50);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userNonExist.email, userNonExist.password);
            homeScreen.WaitSeconds(4);
            loginScreen.GetInnerText_Warning().Should().Be("This email has not been registered.");

        }


        [Test, Property("caseid", "7331")]
        [Description("Login with an Incorrect Email adress ")]
        public void Test_Login_With_An_Incorrect_EmailAdress()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(50);
           
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userIncorrectEmail.email, userIncorrectEmail.password);
            homeScreen.WaitSeconds(4);
            loginScreen.GetInnerText_Warning().Should().Be("Please fill in a correct email-adress.");
        }

        [Test, Property("caseid", "7332")]
        [Description("Login with an Incorrect Email adress or Password ")]
        public void Test_Login_With_An_Incorrect_Email_Or_Password()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(50);
           
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userIncorrectPassword.email, userIncorrectPassword.password);
            homeScreen.WaitSeconds(4);
            loginScreen.GetInnerText_Warning().Should().Be("Email or password incorrect.");
        }
    }
}
