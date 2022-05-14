
using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using Automation_Framework.Tests.Tests.MobileTests;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests.TestMobile
{
    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestProfileScreen : MobileBaseTest
    {
        //User userLoginExist = new User("Pirate@King.com", "onepiece111");
        User userAdminExist = new User("Stage", "Admin", "stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        ProfileScreenLabels profileScreenLabels = new ProfileScreenLabels("PROFILE", "FIRSTNAME", "LASTNAME", "EMAIL", "CREDITS");

        [Test, Property("caseid", "7337")]
        [Description("Visual layout of profile screen ")]
        public void Test_Visual_Layout_Of_ProfileScreen()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(50);
        
            homeScreen.ClickSignInButton();

            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);
            

            navigationScreen.ProfileTab.Should();
            navigationScreen.ClickProfileTab();

            profileScreen.GetInnerText_AndroidLabelTitle().Should().Be(profileScreenLabels.profileTitleLabel);
            profileScreen.AndroidAvatar.Should();

            profileScreen.GetInnerText_AndroidLabelFirstName().Should().Be(profileScreenLabels.firstNameLabel);
            profileScreen.GetInnerText_AndroidFirstName().Should().Be(userAdminExist.firstName);
            profileScreen.GetInnerText_AndroidLabelLastName().Should().Be(profileScreenLabels.lastNameLabel);
            profileScreen.GetInnerText_AndroidLastName().Should().Be(userAdminExist.lastName);
            profileScreen.GetInnerText_AndroidLabelEmail().Should().Be(profileScreenLabels.emailLabel);
            profileScreen.GetInnerText_AndroidEmail().Should().Be(userAdminExist.email);
            profileScreen.GetInnerText_AndroidLabelCredits().Should().Be(profileScreenLabels.creditsLabel);

            profileScreen.AndroidCredits.Should();      //Juiste Aantal credits gaan halen
            profileScreen.AndroidAddCreditsButton.Should();

        }

        [Test, Property("caseid", "7338")]
        [Description("Add credits to profile (positive integer) ")]
        public void Test_Add_Credits_To_Profile_PositiveNumber()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(50);

            homeScreen.ClickSignInButton();

            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);

            navigationScreen.ProfileTab.Should();
            navigationScreen.ClickProfileTab();


            // profileScreen.GetInnerText_AndroidLabelTitle().Should().Be(profileScreenLabels.profileTitleLabel);
            // profileScreen.AndroidAvatar.Should();
            // profileScreen.GetInnerText_AndroidLabelFirstName().Should().Be(profileScreenLabels.firstNameLabel);
            // profileScreen.GetInnerText_AndroidFirstName().Should().Be(userAdminExist.firstName);
            // profileScreen.GetInnerText_AndroidLabelLastName().Should().Be(profileScreenLabels.lastNameLabel);
            // profileScreen.GetInnerText_AndroidLastName().Should().Be(userAdminExist.lastName);
            // profileScreen.GetInnerText_AndroidLabelEmail().Should().Be(profileScreenLabels.emailLabel);
            // profileScreen.GetInnerText_AndroidEmail().Should().Be(userAdminExist.email);
            // profileScreen.GetInnerText_AndroidLabelCredits().Should().Be(profileScreenLabels.creditsLabel);
            // profileScreen.AndroidCredits.Should();      //Juiste Aantal credits gaan halen

            string creditsBefore = profileScreen.GetInnerText_AndroidCredits();
            profileScreen.AndroidAddCreditsButton.Should();
            profileScreen.ClickAddCreditsButton();


            profileScreen.AndroidFillAmountOfCredits("500");
            profileScreen.ClickBuyCreditsButton();
            string creditsAfter = profileScreen.GetInnerText_AndroidCredits();

            creditsBefore.Should().NotBe(creditsAfter);




        }

        [Test, Property("caseid", "7339")]
        [Description("Add credits to profile (non-number input)")]
        public void Test_Add_Credits_To_Profile_NonNumberInput()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(50);
           
            homeScreen.ClickSignInButton();

            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);

            navigationScreen.ProfileTab.Should();
            navigationScreen.ClickProfileTab();

            // profileScreen.GetInnerText_AndroidLabelTitle().Should().Be(profileScreenLabels.profileTitleLabel);
            // profileScreen.AndroidAvatar.Should();
            // profileScreen.GetInnerText_AndroidLabelFirstName().Should().Be(profileScreenLabels.firstNameLabel);
            // profileScreen.GetInnerText_AndroidFirstName().Should().Be(userAdminExist.firstName);
            // profileScreen.GetInnerText_AndroidLabelLastName().Should().Be(profileScreenLabels.lastNameLabel);
            // profileScreen.GetInnerText_AndroidLastName().Should().Be(userAdminExist.lastName);
            // profileScreen.GetInnerText_AndroidLabelEmail().Should().Be(profileScreenLabels.emailLabel);
            // profileScreen.GetInnerText_AndroidEmail().Should().Be(userAdminExist.email);
            // profileScreen.GetInnerText_AndroidLabelCredits().Should().Be(profileScreenLabels.creditsLabel);
            // profileScreen.AndroidCredits.Should();      //Juiste Aantal credits gaan halen

            string creditsBefore = profileScreen.GetInnerText_AndroidCredits();
            profileScreen.AndroidAddCreditsButton.Should();
            profileScreen.ClickAddCreditsButton();


            profileScreen.AndroidFillAmountOfCredits("$^é");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();


            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("lololol");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();

            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("920oO");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();

            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();

            string creditsAfter = profileScreen.GetInnerText_AndroidCredits();
            creditsBefore.Should().Be(creditsAfter);

        }

        //MOET ALTIJD FALEN
        [Test, Property("caseid", "7341")]
        [Description("Add credits to profile (decimal numbers) ")]
        public void Test_Add_Credits_To_Profile_DecimalNumbers()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(50);
           
            homeScreen.ClickSignInButton();

            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);

            navigationScreen.ProfileTab.Should();
            navigationScreen.ClickProfileTab();

            // profileScreen.GetInnerText_AndroidLabelTitle().Should().Be(profileScreenLabels.profileTitleLabel);
            // profileScreen.AndroidAvatar.Should();
            // profileScreen.GetInnerText_AndroidLabelFirstName().Should().Be(profileScreenLabels.firstNameLabel);
            // profileScreen.GetInnerText_AndroidFirstName().Should().Be(userAdminExist.firstName);
            // profileScreen.GetInnerText_AndroidLabelLastName().Should().Be(profileScreenLabels.lastNameLabel);
            // profileScreen.GetInnerText_AndroidLastName().Should().Be(userAdminExist.lastName);
            // profileScreen.GetInnerText_AndroidLabelEmail().Should().Be(profileScreenLabels.emailLabel);
            // profileScreen.GetInnerText_AndroidEmail().Should().Be(userAdminExist.email);
            // profileScreen.GetInnerText_AndroidLabelCredits().Should().Be(profileScreenLabels.creditsLabel);
            // profileScreen.AndroidCredits.Should();      //Juiste Aantal credits gaan halen

            profileScreen.AndroidAddCreditsButton.Should();


            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("4.2");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();

            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("4,2");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();

            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("3.00723456789");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();

            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("7.123456789123456789123456789");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();
            

        }
        [Test, Property("caseid", "7342")]
        [Description("Add credits to profile (negative integer) ")]
        public void Test_Add_Credits_To_Profile_NegativeNumbers()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(50);
        
            homeScreen.ClickSignInButton();

            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);

            navigationScreen.ProfileTab.Should();
            navigationScreen.ClickProfileTab();


            profileScreen.AndroidAddCreditsButton.Should();

            bool result;
            try
            {
                profileScreen.ClickAddCreditsButton();
                profileScreen.AndroidFillAmountOfCredits("-1");
                profileScreen.ClickBuyCreditsButton();
                profileScreen.ClickCancelPaymentButton();
                result = true;

            }
            catch (System.Exception)
            {
                result = false;

            }
            if (result)
                Assert.Pass();
            Assert.Fail();

            //Andere test zetten`


            //profileScreen.ClickAddCreditsButton();
            //profileScreen.AndroidFillAmountOfCredits("0");
            //profileScreen.ClickBuyCreditsButton();
            //profileScreen.ClickCancelPaymentButton();

            //try
            //{
            //    profileScreen.ClickAddCreditsButton();
            //    profileScreen.AndroidFillAmountOfCredits("-123321");
            //    profileScreen.ClickBuyCreditsButton();
            //    profileScreen.ClickCancelPaymentButton();
            //    Assert.Pass();
            //}
            //catch (System.Exception)
            //{

            //    Assert.Fail();
            //}


            //try
            //{
            //    profileScreen.ClickAddCreditsButton();
            //    profileScreen.AndroidFillAmountOfCredits("0.9999999999999999");
            //    profileScreen.ClickBuyCreditsButton();
            //    profileScreen.ClickCancelPaymentButton();
            //    Assert.Pass();
            //}
            //catch (System.Exception)
            //{

            //    Assert.Fail();
            //}


            //try
            //{
            //    profileScreen.ClickAddCreditsButton();
            //    profileScreen.AndroidFillAmountOfCredits("0.99999999999999999");
            //    profileScreen.ClickBuyCreditsButton();
            //    profileScreen.ClickCancelPaymentButton();
            //    Assert.Pass();
            //}
            //catch (System.Exception)
            //{

            //    Assert.Fail();
            //}



            //profileScreen.ClickAddCreditsButton();
            //profileScreen.AndroidFillAmountOfCredits("0.999999999999999944479999999");
            //profileScreen.ClickBuyCreditsButton();
            //profileScreen.ClickCancelPaymentButton();

            //profileScreen.ClickAddCreditsButton();
            //profileScreen.AndroidFillAmountOfCredits("0.9999999999999999444888487687421729788184165954");
            //profileScreen.ClickBuyCreditsButton();
            //profileScreen.ClickCancelPaymentButton();

            //profileScreen.ClickAddCreditsButton();
            //profileScreen.AndroidFillAmountOfCredits("0.9999999999999999444888487687421729788184165955");
            //profileScreen.ClickBuyCreditsButton();
            //profileScreen.ClickCancelPaymentButton();


        }


        [Test, Property("caseid", "7343")]
        [Description("Add credits to profile (cancel payment)")]
        public void Test_Cancelpayment()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(50);
        
            homeScreen.ClickSignInButton();

            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);

            navigationScreen.ProfileTab.Should();
            navigationScreen.ClickProfileTab();

            // profileScreen.GetInnerText_AndroidLabelTitle().Should().Be(profileScreenLabels.profileTitleLabel);
            // profileScreen.AndroidAvatar.Should();
            // profileScreen.GetInnerText_AndroidLabelFirstName().Should().Be(profileScreenLabels.firstNameLabel);
            // profileScreen.GetInnerText_AndroidFirstName().Should().Be(userAdminExist.firstName);
            // profileScreen.GetInnerText_AndroidLabelLastName().Should().Be(profileScreenLabels.lastNameLabel);
            // profileScreen.GetInnerText_AndroidLastName().Should().Be(userAdminExist.lastName);
            // profileScreen.GetInnerText_AndroidLabelEmail().Should().Be(profileScreenLabels.emailLabel);
            // profileScreen.GetInnerText_AndroidEmail().Should().Be(userAdminExist.email);
            // profileScreen.GetInnerText_AndroidLabelCredits().Should().Be(profileScreenLabels.creditsLabel);
            // profileScreen.AndroidCredits.Should();      //Juiste Aantal credits gaan halen

            profileScreen.AndroidAddCreditsButton.Should();

            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("500");
            profileScreen.ClickCancelPaymentButton();

        }

    }
}
