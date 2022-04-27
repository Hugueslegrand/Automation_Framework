using Automation_Framework.Tests.Pages;
using NUnit.Framework;

using FluentAssertions;
using Automation_Framework.Tests.Models;


namespace Automation_Framework.Tests.Tests
{

    public class TestRegistration : BaseTest
    {
        User registerNewUser = new User("Biggie", "Smalls", "ELzzZBiggie_East@Coast.com", "biggie", "biggie");
        User registerNewUserLeadSpace = new User(" Biggie", " Smalls", " ZezzBiggie_East@Coast.com", " biggie", " biggie");
        User registerNewUserUnmatchingPasswords = new User("Biggie", "Smalls", "BiggieZ_East@Coast.com", "biggie", "biggieZZZZZZZ");
        User registerNewUserUpperCase = new User("RAKEEM", "BEST", "RAKEEMG@GMAIL.COM", "CHIPCHOP", "CHIPCHOP");
        User registerNewUserLowerCase = new User("tupac", "shakur", "2pac_wzt@coast.com", "thuglife", "thuglife");
        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");


        [Test]
        [Description("Register an user and log in to verify")]
        public void TestRegisterAnUser()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.RegisterButton.ClickOnElement();

            RegistrationPage registrationPage = new RegistrationPage(builder);
            registrationPage.Register(registerNewUser.firstName, registerNewUser.lastName, registerNewUser.email, registerNewUser.password, registerNewUser.rePassword);
            LoginPage loginPage = new LoginPage(builder);
            navigation.SignInButton.ClickOnElement();
            loginPage.Login(registerNewUser.email, registerNewUser.password);
            navigation.SignOutButton.Should();
        }


        [Test]
        [Description("Register an user with an existing email")]
        public void TestRegisterSameUser()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.RegisterButton.ClickOnElement();

            RegistrationPage registrationPage = new RegistrationPage(builder);
            registrationPage.Register(registerNewUser.firstName, registerNewUser.lastName, registerNewUser.email, registerNewUser.password, registerNewUser.rePassword);
            registrationPage.RegistrationWarning.Text.Should().Be("Account is already registered.");

        }

        [Test]
        [Description("Register an user with a spacebar leading inputforms")]
        public void TestRegisterUserWithSpaceBar()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.RegisterButton.ClickOnElement();

            RegistrationPage registrationPage = new RegistrationPage(builder);
            registrationPage.Register(registerNewUserLeadSpace.firstName, registerNewUserLeadSpace.lastName, registerNewUserLeadSpace.email, registerNewUserLeadSpace.password, registerNewUserLeadSpace.rePassword);
            registrationPage.RegistrationWarning.Text.Should().Be("Please fill in a correct email-adress.");

        }

        [Test]
        [Description("Register an user with no matching passwords")]
        public void TestRegisterUnmatchingPasswords()

        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.RegisterButton.ClickOnElement();

            RegistrationPage registrationPage = new RegistrationPage(builder);
            registrationPage.Register(registerNewUserUnmatchingPasswords.firstName, registerNewUserUnmatchingPasswords.lastName, registerNewUserUnmatchingPasswords.email, registerNewUserUnmatchingPasswords.password, registerNewUserUnmatchingPasswords.rePassword);
            registrationPage.RegistrationWarning.Text.Should().Be("Passwords don't match.");
        }

        [Test]
        [Description("Register an user only lowercase and log in to verify registration")]
        public void TestRegisterLowerCaseAndLogIn()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.RegisterButton.ClickOnElement();

            RegistrationPage registrationPage = new RegistrationPage(builder);
            registrationPage.Register(registerNewUserLowerCase.firstName, registerNewUserLowerCase.lastName, registerNewUserLowerCase.email, registerNewUserLowerCase.password, registerNewUserLowerCase.rePassword);

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(registerNewUserLowerCase.email, registerNewUserLowerCase.password);
            navigation.SignOutButton.Should();
        }

        [Test]
        [Description("Register an user only uppercase and log in to verify registration")]
        public void TestRegisterUpperCaseAndLogIn()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.RegisterButton.ClickOnElement();

            RegistrationPage registrationPage = new RegistrationPage(builder);
            registrationPage.Register(registerNewUserUpperCase.firstName, registerNewUserUpperCase.lastName, registerNewUserUpperCase.email, registerNewUserUpperCase.password, registerNewUserUpperCase.rePassword);
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(registerNewUserUpperCase.email, registerNewUserUpperCase.password);
            navigation.SignOutButton.Should();
        }

        [Test, Order(7)]
        [Description("Delete registered Users for continious testing")]
        public void Test_RemoveRegisteredUsers()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.SignInButton.ClickOnElement();
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userAdminExist.email, userAdminExist.password);

            navigation.SettingsButton.Should();
            navigation.SettingsButton.ClickOnElement();

            AdminPanelPage adminPanelPage = new AdminPanelPage(builder);
            adminPanelPage.UsersMenu.ClickOnElement();
            adminPanelPage.WaitSeconds(1);
            adminPanelPage.RemoveUserByEmail(registerNewUser.email);
            adminPanelPage.RemoveUserByEmail(registerNewUserLowerCase.email);
            adminPanelPage.RemoveUserByEmail(registerNewUserUpperCase.email);
            adminPanelPage.WaitSeconds(1);
        }
    }
}
