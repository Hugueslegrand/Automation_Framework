using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Pages;
using FluentAssertions;
using NUnit.Framework;



namespace Automation_Framework.Tests.Tests
{

    
    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestProfile : BaseTest
    {

        User UserAdminLogin_Exist = new User("Brent", "Dar", "brent.dar@ap.be", "hond123", "hond123");

        [Test, Property("caseid", "7308")]
        [Description("Test: Analysing profile page Elements")]
        public void Test_Analysing_Elements()
        {
            
            Navigation navigation = new Navigation(builder);
            ProfilePage profilePage = new ProfilePage(builder);
            navigation.WaitSeconds(6);
            navigation.ScaleScreen("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);

            navigation.ProfileButton.ClickOnElement();

            // profilePage.GetInnerText_ProfileAvatar().Should().Be("");
            navigation.WaitSeconds(2);
            profilePage.ProfileAvatar.Should();
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


        [Test, Property("caseid", "7309")]
        [Description("Test: Add credits to profile")]
        public void Test_AddPayment()
        {
            
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ScaleScreen("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);
            //loginPage.ScreenShot();
            navigation.ProfileButton.ClickOnElement();
            ProfilePage profilePage = new ProfilePage(builder);
            navigation.WaitSeconds(1);
            profilePage.AddCreditsButton.ClickOnElement();
            navigation.WaitSeconds(1);
            profilePage.AmountOfCredits.ClickOnElement();
            profilePage.FillAmountOfCredits("30");
            navigation.WaitSeconds(1);
            profilePage.BuyCreditsButton.ClickOnElement();
            profilePage.WaitSeconds(2);

        }

        [Test, Property("caseid", "7310")]
        [Description("Test: Add credits to profile (non-number input)  ")]
        public void Test_Add_Credits_To_Profile_nonNumberInput()
        {
            
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ScaleScreen("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);


            navigation.ProfileButton.ClickOnElement();
            ProfilePage profilePage = new ProfilePage(builder);

            profilePage.AddCreditsButton.ClickOnElement();
            profilePage.WaitSeconds(1);
            profilePage.AmountOfCredits.ClickOnElement();
            profilePage.FillAmountOfCredits("notNumberInput");
            profilePage.BuyCreditsButton.ClickOnElement();

            //ASSERT


            profilePage.WaitSeconds(2);
        }



        [Test, Property("caseid", "7311")]
        [Description("Test: Add credits to profile (decimal numbers input)  ")]
        public void Test_Add_Credits_To_Profile_Decimal_Numbers()
        {
            
            Navigation navigation = new Navigation(builder);

            navigation.WaitSeconds(6);

            navigation.ScaleScreen("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);


            navigation.ProfileButton.ClickOnElement();
            ProfilePage profilePage = new ProfilePage(builder);


            profilePage.AddCreditsButton.ClickOnElement();
            // profilePage.ScrollElementIntoView(profilePage.AmountOfCredits.getElement());
           
            
           
            bool result;
            try
            {
                profilePage.AmountOfCredits.ClickOnElement();
                profilePage.FillAmountOfCredits("7.566");
                profilePage.BuyCreditsButton.ClickOnElement();
                profilePage.WaitSeconds(2);
                result = true;

            }
            catch (System.Exception)
            {
                result = false;

            }
            if (result)
                Assert.Pass();
            Assert.Fail();

         
        }

        [Test, Property("caseid", "7312")]
        [Description("Test: Add credits to profile (negative integer) ")]
        public void Test_Add_Credits_To_Profile_Negative_Integer()
        {
            
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ScaleScreen("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);


            navigation.ProfileButton.ClickOnElement();
            ProfilePage profilePage = new ProfilePage(builder);


            profilePage.AddCreditsButton.ClickOnElement();
            profilePage.WaitSeconds(1);
            profilePage.AmountOfCredits.ClickOnElement();
            profilePage.FillAmountOfCredits("-1");
            profilePage.BuyCreditsButton.ClickOnElement();

            //ASSERT


            profilePage.WaitSeconds(2);
        }




        [Test, Property("caseid", "7313")]
        [Description("Test: CancelPayment ")]
        public void Test_CancelPayment()
        {
            
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ScaleScreen("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(UserAdminLogin_Exist.email, UserAdminLogin_Exist.password);


            navigation.ProfileButton.ClickOnElement();
            ProfilePage profilePage = new ProfilePage(builder);
            profilePage.WaitSeconds(1);
            profilePage.AddCreditsButton.ClickOnElement();
            profilePage.WaitSeconds(1);
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
