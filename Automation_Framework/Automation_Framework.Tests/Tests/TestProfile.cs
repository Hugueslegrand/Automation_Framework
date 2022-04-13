using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Pages;
using FluentAssertions;
using NUnit.Framework;
using System.Threading;


namespace Automation_Framework.Tests.Tests
{
    public class TestProfile : BaseTest
    {

        User UserAdminLogin_Exist = new User("Brent", "Dar", "brent.dar@ap.be", "hond123", "hond123");

        [Test]
        [Description("Test: Analysing Elements (3.1)")]
        public void Test_Analysing_Elements()
        {
            
            Navigation navigation = new Navigation(builder);
            ProfilePage profilePage = new ProfilePage(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);


            navigation.ClickProfile();

           // profilePage.GetInnerText_ProfileAvatar().Should().Be("");
            profilePage.GetInnerText_FirstName().Should().Be(UserAdminLogin_Exist.firstName);
            profilePage.GetInnerText_LastName().Should().Be(UserAdminLogin_Exist.lastName);
            profilePage.GetInnerText_Email().Should().Be(UserAdminLogin_Exist.email);
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
            
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);
            //loginPage.ScreenShot();

            navigation.ClickProfile();
            ProfilePage profilePage = new ProfilePage(builder);
            profilePage.ClickAddCredits();
            profilePage.ClickAmountOfCredits();
            profilePage.FillAmountOfCredits("30");
            profilePage.ClickBuyCredits();
            profilePage.WaitSeconds(2);

        }

        [Test]
        [Description("Test: Add credits to profile (not-number input) (3,4)  ")]
        public void Test_Add_Credits_To_Profile_nonNumberInput()
        {
            
            Navigation navigation = new Navigation(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);


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
            
            Navigation navigation = new Navigation(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);


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
            
            Navigation navigation = new Navigation(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);


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
            
            Navigation navigation = new Navigation(builder);
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);


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
