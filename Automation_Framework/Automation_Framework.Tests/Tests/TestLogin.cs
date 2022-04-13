using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using System.Threading;
using FluentAssertions;
using Automation_Framework.Tests.Models;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Automation_Framework.Tests.Tests
{

    public class TestLogin : BaseTest
    {
        User userLoginExist = new User("Pirate@King.com", "onepiece111");

        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        User userNonExist = new User("UserNotExist@brightest.be", "UserNotExist");

        User userIncorrectEmail = new User("IncorrectEmailAdress", "IncorrectEmailAdress");

        User userIncorrectPassword = new User("Pirate@King.com", "IncorrectEmailAdress");

        [Test]
        [Description("Login as administrator")]
        public void Test_LoginAsAdmin_POM()
        {
            Navigation navigation = new Navigation(builder);

            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            //Assert.AreEqual(loginPage.getInnerText(), "login");

            loginPage.Login("brent.dar@ap.be", "hond");

            navigation.ClickMyMovie();

            MyMoviesPage myMoviesPage = new MyMoviesPage(builder);
            //Remove selenium
            IList<IWebElement> test = myMoviesPage.getElements();
            foreach (var item in test)
            {
                item.FindElement(By.ClassName("css-49l3oe"));
            }
            //Assert.AreEqual(myMoviesPage.getElements(), "login");



        }


        [Test]
        [Description("Login as an existing user [2.1]")]
        public void Test_Unlogged_Layout()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.SignInButton.Should();
            navigation.RegisterButton.Should();
        }

        [Test]
        [Description("Login as an existing user [2.2]")]
        public void Test_Login_As_Existing_User()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userLoginExist.email, userLoginExist.password);

            navigation.SignOutButton.Should();
            navigation.MyMovieButton.Should();
            navigation.ProfileButton.Should();
        }

        [Test]
        [Description("Login as an existing userAdmin [2.3]")]
        public void Test_Login_As_Existing_UserAdmin()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userAdminExist.email, userAdminExist.password);

            navigation.SignOutButton.Should();
            navigation.MyMovieButton.Should();
            navigation.ProfileButton.Should();
            navigation.SettingsButton.Should();
        }


        [Test]
        [Description("Login as an NOT existing user")]
        public void Test_Login_As_Not_Existing_User()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userNonExist.email, userNonExist.password);
            loginPage.GetInnerText_Warning().Should().Be("This email has not been registered.");
        }


        [Test]
        [Description("Login with an Incorrect Email adress")]
        public void Test_Login_With_An_Incorrect_EmailAdress()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userIncorrectEmail.email, userIncorrectEmail.password);
            loginPage.GetInnerText_Warning().Should().Be("Please fill in a correct email-adress.");
        }

        [Test]
        [Description("Login with an Incorrect Email adress or Password")]
        public void Test_Login_With_An_Incorrect_Email_Or_Password()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userIncorrectPassword.email, userIncorrectPassword.password);
            loginPage.GetInnerText_Warning().Should().Be("Email or password incorrect.");
        }


        [Test]
        [Description("All the neccesary elements are available in the footer and work accordingly [1.5]")]
        public void Test_FooterElements()
        {
            
            HomePage homePage = new HomePage(builder);
            homePage.WaitSeconds(6);
            homePage.BrightestFaceBookSocials.Should();
            string hrefFB = homePage.GetAttribute("href", homePage.BrightestFaceBookSocials);
            //hrefFB.Should().NotBeNull(); Nodig of niet?
            hrefFB.Should().Be("https://www.facebook.com/BrightestNV");
            // Assertions op tags binnen een element, zijnde attribute, class, availability, etc.. deze 3 stappen voor een juiste assertion

            string hrefIG = homePage.GetAttribute("href", homePage.BrightestInstagramSocials);
            homePage.BrightestInstagramSocials.Should();
            homePage.BrightestFaceBookSocials.ClickOnElement();
            hrefIG.Should().NotBeNull();
            hrefIG.Should().Be("https://www.instagram.com/brightestsoftwarequality/");
   

            string hrefTW = homePage.GetAttribute("href", homePage.BrightestTwitterSocials);
            homePage.BrightestTwitterSocials.Should();
            hrefTW.Should().NotBeNull();
            hrefTW.Should().Be("https://twitter.com/brightestnv");

            string hrefLI = homePage.GetAttribute("href", homePage.BrightestLinkedInSocials);
            homePage.BrightestLinkedInSocials.Should();
            hrefLI.Should().NotBeNull();
            hrefLI.Should().Be("https://www.linkedin.com/company/brightest-nv/");

            homePage.CopyrightElement.Should();

            string hrefBR = homePage.GetAttribute("href", homePage.BrightestOfficalSite);
            homePage.BrightestOfficalSite.Should();
            hrefBR.Should().NotBeNull();
            hrefBR.Should().Be("https://www.brightest.be/");

        }
    }
}
