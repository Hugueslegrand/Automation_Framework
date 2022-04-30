using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Pages;
using FluentAssertions;
using NUnit.Framework;



namespace Automation_Framework.Tests.Tests
{
    [TestFixture]
    [Property("suiteid", "4")]
    [Property("projectid", "1")]
    public class TestProfile : BaseTest
    {


        [Test, Property("caseid", "13")]
        [Description("Login as administrator parallel")]
        public void Test_LoginAsAdminChrome()
        {

            Navigation navigation = new Navigation(builder);

            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);


            loginPage.Login("brent.dar@ap.be", "hond123");

            navigation.WaitSeconds(10);



        }

        User UserAdminLogin_Exist = new User("Brent", "Dar", "brent.dar@ap.be", "hond123", "hond123");

        [Test, Property("caseid", "14")]
        [Description("Test: Analysing Elements (3.1)")]
        public void Test_Analysing_Elements()
        {
            
            Navigation navigation = new Navigation(builder);
            ProfilePage profilePage = new ProfilePage(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);

            navigation.ProfileButton.ClickOnElement();

            // profilePage.GetInnerText_ProfileAvatar().Should().Be("");
            profilePage.FirstName.Text.Should().Be(UserAdminLogin_Exist.firstName);
            profilePage.LastName.Text.Should().Be(UserAdminLogin_Exist.lastName);
            profilePage.Email.Text.Should().Be(UserAdminLogin_Exist.email);
            string src = profilePage.ProfileAvatar.GetAttribute("src"); 
            src.Should().NotBeNull();

            // string src = profilePage.GetAttribute("src");
            // if (src is null) 
            //     Assert.Fail();
            //
            //
            // Thread.Sleep(2000);

        }


        [Test, Property("caseid", "15")]
        [Description("Test: Add credits to profile (3,3)")]
        public void Test_AddPayment()
        {
            
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);
            //loginPage.ScreenShot();
            navigation.ProfileButton.ClickOnElement();
            ProfilePage profilePage = new ProfilePage(builder);
            profilePage.AddCreditsButton.ClickOnElement();
            profilePage.AmountOfCredits.ClickOnElement();
            profilePage.FillAmountOfCredits("30");
            profilePage.BuyCreditsButton.ClickOnElement();
            profilePage.WaitSeconds(2);

        }

        [Test, Property("caseid", "16")]
        [Description("Test: Add credits to profile (not-number input) (3,4)  ")]
        public void Test_Add_Credits_To_Profile_nonNumberInput()
        {
            
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);


            navigation.ProfileButton.ClickOnElement();
            ProfilePage profilePage = new ProfilePage(builder);

            profilePage.AddCreditsButton.ClickOnElement();
            profilePage.AmountOfCredits.ClickOnElement();
            profilePage.FillAmountOfCredits("notNumberInput");
            profilePage.BuyCreditsButton.ClickOnElement();

            //ASSERT


            profilePage.WaitSeconds(2);
        }



        [Test, Property("caseid", "17")]
        [Description("Test: Add credits to profile (decimal numbers input) (3,5)  ")]
        public void Test_Add_Credits_To_Profile_Decimal_Numbers()
        {
            
            Navigation navigation = new Navigation(builder);

            navigation.WaitSeconds(6);

            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);


            navigation.ProfileButton.ClickOnElement();
            ProfilePage profilePage = new ProfilePage(builder);


            profilePage.AddCreditsButton.ClickOnElement();
            // profilePage.ScrollElementIntoView(profilePage.AmountOfCredits.getElement());
           

            profilePage.AmountOfCredits.ClickOnElement();
            profilePage.FillAmountOfCredits("7.566");
            profilePage.BuyCreditsButton.ClickOnElement();

            //ASSERT

            profilePage.WaitSeconds(2);
        }

        [Test, Property("caseid", "18")]
        [Description("Test: Add credits to profile (negative integer) (3,6)  ")]
        public void Test_Add_Credits_To_Profile_Negative_Integer()
        {
            
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);


            navigation.ProfileButton.ClickOnElement();
            ProfilePage profilePage = new ProfilePage(builder);


            profilePage.AddCreditsButton.ClickOnElement();
            profilePage.AmountOfCredits.ClickOnElement();
            profilePage.FillAmountOfCredits("-1");
            profilePage.BuyCreditsButton.ClickOnElement();

            //ASSERT


            profilePage.WaitSeconds(2);
        }




        [Test, Property("caseid", "19")]
        [Description("Test: CancelPayment (3,7)")]
        public void Test_CancelPayment()
        {
            
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);


            navigation.ProfileButton.ClickOnElement();
            ProfilePage profilePage = new ProfilePage(builder);
            profilePage.AddCreditsButton.ClickOnElement();
            profilePage.AmountOfCredits.ClickOnElement();
            profilePage.FillAmountOfCredits("30");
            profilePage.CancelPaymentButton.ClickOnElement();

            string type = profilePage.AddCreditsButton.GetAttribute("type");
            type.Should().NotBeNull();


            profilePage.WaitSeconds(2);

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
