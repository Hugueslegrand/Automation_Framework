using Automation_Framework.Tests.Pages;
using NUnit.Framework;

using FluentAssertions;
using Automation_Framework.Tests.Models;
using Automation_Framework.Utilities;
using System.Collections.Generic;
using Automation_Framework.Tests.Screens;
using Automation_Framework.Builders;
using Automation_Framework.Enums;

namespace Automation_Framework.Tests.Tests
{

    [TestFixture]

    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    // [Parallelizable(scope: ParallelScope.All)]
    public class TestLogin :BaseTest
    {
        User userLoginExist = new User("Pirate@King.com", "onepiece111");

        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        User userNonExist = new User("UserNotExist@brightest.be", "UserNotExist");

        User userIncorrectEmail = new User("IncorrectEmailAdress", "IncorrectEmailAdress");

        User userIncorrectPassword = new User("Pirate@King.com", "IncorrectEmailAdress");


      




        [Test, Property("caseid", "7293")]
        [Description("Layout of unlogged user")]
        public void Test_Unlogged_Layout()
        {
            
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.Should();
            navigation.RegisterButton.Should();
        }


        [Test, Property("caseid", "7295")]
        [Description("Login as an existing user")]
        public void Test_Login_As_Existing_User()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userLoginExist.email, userLoginExist.password);

            navigation.SignOutButton.Should();
            navigation.MyMovieButton.Should();
            navigation.ProfileButton.Should();
        }

        [Test, Property("caseid", "7294")]
        [Description("Login as an existing userAdmin ")]
        public void Test_Login_As_Existing_UserAdmin()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userAdminExist.email, userAdminExist.password);

            navigation.SignOutButton.Should();
            navigation.MyMovieButton.Should();
            navigation.ProfileButton.Should();
            navigation.SettingsButton.Should();
        }


        [Test, Property("caseid", "7296")]
        [Description("Login as an NOT existing user")]
        public void Test_Login_As_Not_Existing_User()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userNonExist.email, userNonExist.password);
            loginPage.LoginWarning.Text.Should().Be("This email has not been registered.");
        }


        [Test, Property("caseid", "7297")]
        [Description("Login with an Incorrect Email adress")]
        public void Test_Login_With_An_Incorrect_EmailAdress()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userIncorrectEmail.email, userIncorrectEmail.password);
            loginPage.LoginWarning.Text.Should().Be("Please fill in a correct email-adress.");
        }

        [Test, Property("caseid", "7298")]
        [Description("Login with an Incorrect Email adress or Password")]
        public void Test_Login_With_An_Incorrect_Email_Or_Password()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userIncorrectPassword.email, userIncorrectPassword.password);
            loginPage.LoginWarning.Text.Should().Be("Email or password incorrect.");
        }


        [Test, Property("caseid", "7291")]
        [Description("All the neccesary elements are available in the footer and work accordingly")]
        public void Test_FooterElements()
        {
            
            HomePage homePage = new HomePage(builder);
            homePage.WaitSeconds(6);
            homePage.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            homePage.BrightestFaceBookSocials.Should();
            string hrefFB = homePage.BrightestFaceBookSocials.GetAttribute("href");
            //hrefFB.Should().NotBeNull(); Nodig of niet?
            hrefFB.Should().Be("https://www.facebook.com/BrightestNV");
            // Assertions op tags binnen een element, zijnde attribute, class, availability, etc.. deze 3 stappen voor een juiste assertion

            string hrefIG = homePage.BrightestInstagramSocials.GetAttribute("href");
            homePage.BrightestInstagramSocials.Should();
            homePage.BrightestFaceBookSocials.ClickOnElement();
            hrefIG.Should().NotBeNull();
            hrefIG.Should().Be("https://www.instagram.com/brightestsoftwarequality/");
   

            string hrefTW = homePage.BrightestTwitterSocials.GetAttribute("href");
            homePage.BrightestTwitterSocials.Should();
            hrefTW.Should().NotBeNull();
            hrefTW.Should().Be("https://twitter.com/brightestnv");

            string hrefLI = homePage.BrightestLinkedInSocials.GetAttribute("href");
            homePage.BrightestLinkedInSocials.Should();
            hrefLI.Should().NotBeNull();
            hrefLI.Should().Be("https://www.linkedin.com/company/brightest-nv/");

            homePage.CopyrightElement.Should();

            string hrefBR = homePage.BrightestOfficalSite.GetAttribute("href");
            homePage.BrightestOfficalSite.Should();
            hrefBR.Should().NotBeNull();
            hrefBR.Should().Be("https://www.brightest.be/");

        }
    }
}
