using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Pages;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Tests
{
    public class TestProfile : BaseTest
    {

        public User UserAdminLogin_Exist()
        {
            return new User
            {
                firstName = "Brent",
                lastName = "Dar",
                email = "brent.dar@ap.be",
                password = "hond",
                credits = ""
            };
        }

        [Test]
        [Description("Test: Analysing Elements")]
        public void Test_Analysing_Elements()
        {
            User user = UserAdminLogin_Exist();
            Navigation navigation = new Navigation(builder);
            ProfilePage profilePage = new ProfilePage(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(user.email, user.password);


            //loginPage.ScreenShot();

            navigation.ClickProfile();
            profilePage.GetInnerText_FirstName().Should().Be(user.firstName);
            profilePage.GetInnerText_LastName().Should().Be(user.lastName);
            profilePage.GetInnerText_Email().Should().Be(user.email);

            //profilePage.GetInnerText_Email().Should().Be(user.email);


            Thread.Sleep(2000);

        }


        [Test]
        [Description("Test: AddPayment")]
        public void Test_AddPayment()
        {
            User user = UserAdminLogin_Exist();
            Navigation navigation = new Navigation(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(user.email, user.password);
            //loginPage.ScreenShot();

            navigation.ClickProfile();
            ProfilePage profilePage = new ProfilePage(builder);
            profilePage.ClickAddCredits();
            profilePage.ClickAmountOfCredits();
            profilePage.FillAmountOfCredits("30");
            profilePage.ClickBuyCredits();
            Thread.Sleep(2000);

        }

        [Test]
        [Description("Test: CancelPayment")]
        public void Test_CancelPayment()
        {
            User user = UserAdminLogin_Exist();
            Navigation navigation = new Navigation(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(user.email, user.password);
            //loginPage.ScreenShot();


            navigation.ClickProfile();
            ProfilePage profilePage = new ProfilePage(builder);
            profilePage.ClickAddCredits();
            profilePage.ClickAmountOfCredits();
            profilePage.FillAmountOfCredits("30");
            profilePage.ClickCancelPayment();
            Thread.Sleep(2000);

        }

        [Test]
        [Description("Test: Add credits to profile (non-number input)  ")]
        public void Test_Add_Credits_To_Profile_nonNumberInput()
        {
            User user = UserAdminLogin_Exist();
            Navigation navigation = new Navigation(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(user.email, user.password);
            //loginPage.ScreenShot();


            navigation.ClickProfile();
            ProfilePage profilePage = new ProfilePage(builder);


            profilePage.ClickAddCredits();
            profilePage.ClickAmountOfCredits();
            profilePage.FillAmountOfCredits("notNumberInput");
            profilePage.ClickBuyCredits();
            Thread.Sleep(2000);

        }
        /*
        [Test]
        [Description("Test: Add Correct Amount of credits  ")]
        public void Test_Add_Correct_Amount_Of_Credits()
        {
            User user = UserAdminLogin_Exist();
            Navigation navigation = new Navigation(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(user.email, user.password);
            //loginPage.ScreenShot();


            navigation.ClickProfile();
            ProfilePage profilePage = new ProfilePage(builder);

            
            profilePage.ClickAddCredits();
            profilePage.ClickAmountOfCredits();
            profilePage.FillAmountOfCredits("30");
            profilePage.ClickCancelPayment();
            Thread.Sleep(2000);
        
        }
        */
    }
}
