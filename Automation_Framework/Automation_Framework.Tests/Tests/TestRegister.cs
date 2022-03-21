using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using System.Threading;
using FluentAssertions;
using Automation_Framework.Tests.Models;


namespace Automation_Framework.Tests.Tests
{

    public class TestRegister : BaseTest
    {
        public User User1()
        {

            return new User
            {
                firstName = "Goku",
                lastName = "Kakarot",
                email = "DragonBallZ@King.com",
                password = "onepiece111",
                rePassword = "onepiece111"
            };
        }

        public User User2()
        {
            return new User
            {
                firstName = " Vegata",
                lastName = " PrinceSayan",
                email = " Strongest.Saiyan@mail.com",
                password = " FreezaSucks",
                rePassword = " FreezaSucks"
            };
        }

        public User User3()
        {
            return new User
            {
                firstName = "Luffy-san",
                lastName = "D. Monkey",
                email = "elPirate@King.com",
                password = "onepiece111",
                rePassword = "onepiece11rzezrzerzerzrzerz1"
            };
        }

        public User User4()
        {
            return new User
            {
                firstName = "goku",
                lastName = "ssblu",
                email = "sowieso@goku.com",
                password = "kamehameha",
                rePassword = "kamehameha"
            };
        }

        public User User5()
        {
            return new User
            {
                firstName = "MAJIN",
                lastName = "BUU",
                email = "MAJIN.BUU@PINK.COM",
                password = "KATANAZEBEST",
                rePassword = "KATANAZEBEST"
            };
        }

        public User Admin()
        {
            return new User
            {
                email = "brent.dar@ap.be",
                password = "hond"
            };

        }

        [Test]
        [Description("Register an user")]
        public void Test_RegisterAnUser()
        {
            User user = User1();
            Navigation navigation = new Navigation(builder);

            Thread.Sleep(6000);
            navigation.ClickRegister();

            RegistrationPage registrationPage = new RegistrationPage(builder);

            registrationPage.Register(user.firstName, user.lastName, user.email, user.password, user.rePassword);

        }

        [Test]
        [Description("Register an user with an existing email")]
        public void Test_RegisterSameUser()
        {
            User user = User1();
            Navigation navigation = new Navigation(builder);

            Thread.Sleep(6000);
            navigation.ClickRegister();

            RegistrationPage registrationPage = new RegistrationPage(builder);

            registrationPage.Register(user.firstName, user.lastName, user.email, user.password, user.rePassword);
            registrationPage.UserAlreadyExist().Should().Be("Account is already registered.");

        }

        [Test]
        [Description("Register an user with a spacebar leading inputforms")]
        public void Test_RegisterUserWithSpaceBar()
        {
            User user = User2();
            Navigation navigation = new Navigation(builder);

            Thread.Sleep(6000);
            navigation.ClickRegister();

            RegistrationPage registrationPage = new RegistrationPage(builder);

            registrationPage.Register(user.firstName, user.lastName, user.email, user.password, user.rePassword);
            registrationPage.IncorrectEmail().Should().Be("Please fill in a correct email-adress.");

        }

        [Test]
        [Description("Register an user with no matching passwords")]
        public void Test_RegisterUnmatchingPasswords()

        {
            User user = User3();
            Navigation navigation = new Navigation(builder);

            Thread.Sleep(6000);
            navigation.ClickRegister();

            RegistrationPage registrationPage = new RegistrationPage(builder);

            registrationPage.Register(user.firstName, user.lastName, user.email, user.password, user.rePassword);
            registrationPage.PasswordDontMatch().Should().Be("Passwords don't match.");

        }

        [Test]
        [Description("Register an user only lowercase and log in to verify registration")]
        public void Test_RegisterLowerCaseAndLogIn()
        {
            User user = User4();
            Navigation navigation = new Navigation(builder);

            Thread.Sleep(6000);
            navigation.ClickRegister();

            RegistrationPage registrationPage = new RegistrationPage(builder);

            registrationPage.Register(user.firstName, user.lastName, user.email, user.password, user.rePassword);
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(user.email, user.password);
            navigation.SignOutButton.Should();

        }

        [Test]
        [Description("Register an user only uppercase and log in to verify registration")]
        public void Test_RegisterUpperCaseAndLogIn()
        {
            User user = User5();
            Navigation navigation = new Navigation(builder);

            Thread.Sleep(6000);
            navigation.ClickRegister();

            RegistrationPage registrationPage = new RegistrationPage(builder);

            registrationPage.Register(user.firstName, user.lastName, user.email, user.password, user.rePassword);
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(user.email, user.password);
            navigation.SignOutButton.Should();

        }


    }


}