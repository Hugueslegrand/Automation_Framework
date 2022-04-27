
using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests.TestMobile
{
    public class TestProfileScreen : BaseTest
    {
        //User userLoginExist = new User("Pirate@King.com", "onepiece111");
        User userAdminExist = new User("Stage", "Admin", "stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        ProfileScreenLabels profileScreenLabels = new ProfileScreenLabels("PROFILE", "FIRSTNAME", "LASTNAME", "EMAIL", "CREDITS");

        [Test]
        [Description("Visual layout of profile screen [3.1]")]
        public void Test_Visual_Layout_Of_ProfileScreen()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);
            //Console.WriteLine(profileScreenLabels.profileTitleLabel);
            //Console.WriteLine(userAdminExist.email);

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

        [Test]
        [Description("Add credits to profile (positive integer) [3.2]")]
        public void Test_Add_Credits_To_Profile_PositiveNumber()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
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

        [Test]
        [Description("Add credits to profile (non-number input) [3.3]")]
        public void Test_Add_Credits_To_Profile_NonNumberInput()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
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

        [Test]
        [Description("Add credits to profile (decimal numbers) [3.4]")]
        public void Test_Add_Credits_To_Profile_DecimalNumbers()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
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
        [Test]
        [Description("Add credits to profile (negative integer) [3.5]")]
        public void Test_Add_Credits_To_Profile_NegativeNumbers()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
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
            profileScreen.AndroidFillAmountOfCredits("-1");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();

            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("0");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();

            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("-123321");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();

            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("0.9999999999999999");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();

            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("0.99999999999999999");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();

            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("0.999999999999999944479999999");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();

            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("0.9999999999999999444888487687421729788184165954");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();

            profileScreen.ClickAddCreditsButton();
            profileScreen.AndroidFillAmountOfCredits("0.9999999999999999444888487687421729788184165955");
            profileScreen.ClickBuyCreditsButton();
            profileScreen.ClickCancelPaymentButton();


        }


        [Test]
        [Description("Add credits to profile (cancel payment) [3.6]")]
        public void Test_Cancelpayment()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
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
