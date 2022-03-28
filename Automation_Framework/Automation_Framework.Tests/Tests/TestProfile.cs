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
using OpenQA.Selenium;

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
        [Description("Test: Analysing Elements (3.1)")]
        public void Test_Analysing_Elements()
        {
            User user = UserAdminLogin_Exist();
            Navigation navigation = new Navigation(builder);
            ProfilePage profilePage = new ProfilePage(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(user.email, user.password);


            navigation.ClickProfile();

           // profilePage.GetInnerText_ProfileAvatar().Should().Be("");
            profilePage.GetInnerText_FirstName().Should().Be(user.firstName);
            profilePage.GetInnerText_LastName().Should().Be(user.lastName);
            profilePage.GetInnerText_Email().Should().Be(user.email);
            string src = profilePage.GetAttribute_ProfileAvatar("src", profilePage.ProfileAvatar);
            src.Should().NotBeNull();

            // string src = profilePage.GetAttribute("src");
            // if (src is null) 
            //     Assert.Fail();
            //
            //
            // Thread.Sleep(2000);

        }


        [Test]
        [Description("Test: Add credits to profile (3,3)")]
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
        [Description("Test: Add credits to profile (not-number input) (3,4)  ")]
        public void Test_Add_Credits_To_Profile_nonNumberInput()
        {
            User user = UserAdminLogin_Exist();
            Navigation navigation = new Navigation(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(user.email, user.password);


            navigation.ClickProfile();
            ProfilePage profilePage = new ProfilePage(builder);


            profilePage.ClickAddCredits();
            profilePage.ClickAmountOfCredits();
            profilePage.FillAmountOfCredits("notNumberInput");
            profilePage.ClickBuyCredits();

            //ASSERT

            Thread.Sleep(2000);
        }



        [Test]
        [Description("Test: Add credits to profile (decimal numbers input) (3,5)  ")]
        public void Test_Add_Credits_To_Profile_Decimal_Numbers()
        {
            User user = UserAdminLogin_Exist();
            Navigation navigation = new Navigation(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(user.email, user.password);


            navigation.ClickProfile();
            ProfilePage profilePage = new ProfilePage(builder);


            profilePage.ClickAddCredits();
            profilePage.ClickAmountOfCredits();
            profilePage.FillAmountOfCredits("7.566");
            profilePage.ClickBuyCredits();

            //ASSERT
            Thread.Sleep(2000);
        }

        [Test]
        [Description("Test: Add credits to profile (negative integer) (3,6)  ")]
        public void Test_Add_Credits_To_Profile_Negative_Integer()
        {
            User user = UserAdminLogin_Exist();
            Navigation navigation = new Navigation(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(user.email, user.password);


            navigation.ClickProfile();
            ProfilePage profilePage = new ProfilePage(builder);


            profilePage.ClickAddCredits();
            profilePage.ClickAmountOfCredits();
            profilePage.FillAmountOfCredits("-1");
            profilePage.ClickBuyCredits();

            //ASSERT

            Thread.Sleep(2000);
        }




        [Test]
        [Description("Test: CancelPayment (3,7)")]
        public void Test_CancelPayment()
        {
            User user = UserAdminLogin_Exist();
            Navigation navigation = new Navigation(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(user.email, user.password);


            navigation.ClickProfile();
            ProfilePage profilePage = new ProfilePage(builder);
            profilePage.ClickAddCredits();
            profilePage.ClickAmountOfCredits();
            profilePage.FillAmountOfCredits("30");
            profilePage.ClickCancelPayment();

            string type = profilePage.GetAttribute_AddCreditsButton("type", profilePage.AddCreditsButton);
            type.Should().NotBeNull();


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
