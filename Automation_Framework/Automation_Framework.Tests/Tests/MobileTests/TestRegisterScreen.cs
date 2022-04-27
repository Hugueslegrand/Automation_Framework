using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests.TestMobile
{
    public class TestRegistration : BaseTest
    {
        User registerNewUser = new User("luffy", "monkey", "luffy@monkey.ap.be", "strawhat", "strawhat");
        User registerUsedUser = new User(" Zoro", " Rononoa", "luffy@monkey.ap.be", " hunter", " hunter");
        User registerNewUserUnmatchingPasswords = new User("Maxi", "Cosi", "MaxiCosi@ap.be", "Maxi123", "Cosi123");
        User registerNewUserUpperCase = new User("RAKEEM", "BEST", "RAKEEMG@GMAIL.COM", "CHIPCHOP", "CHIPCHOP");
        User registerNewUserLowerCase = new User("tupac", "shakur", "2pac_wzt@coast.com", "thuglife", "thuglife");
        User registerNewUserNumbers = new User("12345", "12345", "12345@12345.12345", "12345", "12345");
        User registerNewUserLeadingSpacebar = new User(" nami"," navigator", " nami@brightest.be"," strawhat1234"," strawhat1234");
        User registerNewUserSpecialCharacters = new User("Zaweh","Ewaz", "|^¦¢¥§¶¡@brightest.be", "|^¦¢¥§¶¡", "|^¦¢¥§¶¡");
        User registerNewUserOpenFields = new User("Sunny","Sunny","sunny@ap.be","sunny","sunny");
        User registerNewUser1Character = new User("k", "k", "k", "k", "k");


        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");


        [Test]
        [Description("Register a new user and log in to verify [5.1]")]
        public void Test_Register_A_New_User()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.ClickSignInButton();

            loginScreen.ClickGoToRegisterScreen();

            registerScreen.AndroidRegister(registerNewUser.firstName,
                                           registerNewUser.lastName,
                                           registerNewUser.email,
                                           registerNewUser.password,
                                           registerNewUser.rePassword);

            loginScreen.AndroidLogin(registerNewUser.email, registerNewUser.password);

            homeScreen.SignOutButton.Should();
            navigationScreen.HomeTab.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();
            navigationScreen.SearchbarTab.Should();


        }


        [Test]
        [Description("Register a used user [5.2]")]
        public void Test_Register_A_Used_User()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.ClickSignInButton();

            loginScreen.ClickGoToRegisterScreen();

            registerScreen.AndroidRegister(registerUsedUser.firstName,
                                           registerUsedUser.lastName,
                                           registerUsedUser.email,
                                           registerUsedUser.password,
                                           registerUsedUser.rePassword);

            registerScreen.GetInnerText_ErrorMessage().Should().Be("Account is already registered.");


        }

        [Test]
        [Description("Register a new user with unmatching passwords [5.3]")]
        public void Test_Register_Unmatching_Passwords()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.ClickSignInButton();

            loginScreen.ClickGoToRegisterScreen();

            registerScreen.AndroidRegister(registerNewUserUnmatchingPasswords.firstName,
                                             registerNewUserUnmatchingPasswords.lastName,
                                             registerNewUserUnmatchingPasswords.email,
                                             registerNewUserUnmatchingPasswords.password,
                                             registerNewUserUnmatchingPasswords.rePassword);

            registerScreen.GetInnerText_ErrorMessage().Should().Be("Passwords don't match.");
        }

        [Test]
        [Description("Register user with numbers [5.4]")]
        public void Test_Register_User_With_Numbers()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);

            //AllScreens allScreens = new AllScreens(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.ClickSignInButton();

            loginScreen.ClickGoToRegisterScreen();
            // loginScreen.GoToRegisterScreen.AndroidClick();

            registerScreen.AndroidRegister(registerNewUserNumbers.firstName,
                                           registerNewUserNumbers.lastName,
                                           registerNewUserNumbers.email,
                                           registerNewUserNumbers.password,
                                           registerNewUserNumbers.rePassword);

            registerScreen.GetInnerText_ErrorMessage().Should().Be("Please fill in a correct email-adress.");


        }

        [Test]
        [Description("Register user lead with a spacebar in the inputfields [5.5]")]
        public void Test_Register_User_Lead_With_Spacebar()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.ClickSignInButton();

            loginScreen.ClickGoToRegisterScreen();

            registerScreen.AndroidRegister(registerNewUserLeadingSpacebar.firstName,
                                             registerNewUserLeadingSpacebar.lastName,
                                             registerNewUserLeadingSpacebar.email,
                                             registerNewUserLeadingSpacebar.password,
                                             registerNewUserLeadingSpacebar.rePassword);

            loginScreen.AndroidLogin(registerNewUserLeadingSpacebar.email, registerNewUserLeadingSpacebar.password);

            homeScreen.SignOutButton.Should();
            navigationScreen.HomeTab.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();
            navigationScreen.SearchbarTab.Should();
        }

        [Test]
        [Description("Register user with special characters [5.6]")]
        public void Test_Register_User_With_Special_Characters()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.ClickSignInButton();

            loginScreen.ClickGoToRegisterScreen();

            registerScreen.AndroidRegister(registerNewUserSpecialCharacters.firstName,
                                             registerNewUserSpecialCharacters.lastName,
                                             registerNewUserSpecialCharacters.email,
                                             registerNewUserSpecialCharacters.password,
                                             registerNewUserSpecialCharacters.rePassword);

            loginScreen.AndroidLogin(registerNewUserSpecialCharacters.email, registerNewUserSpecialCharacters.password);

            homeScreen.SignOutButton.Should();
            navigationScreen.HomeTab.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();
            navigationScreen.SearchbarTab.Should();
        }

        //Error message element changes based on view, can't run this test
        //[Test]
        //[Description("Register user with few open fields [5.7]")]
        //public void Test_Register_User_With_Few_Open_Fields()
        //{
        //    RegisterScreen registerScreen = new RegisterScreen(builder);
        //    LoginScreen loginScreen = new LoginScreen(builder);
        //    HomeScreen homeScreen = new HomeScreen(builder);

        //    homeScreen.WaitSeconds(20);
        //    homeScreen.ClickSignInButton();

        //    loginScreen.ClickGoToRegisterScreen();

        //    registerScreen.AndroidRegister("",
        //                                   registerNewUserOpenFields.lastName,
        //                                   registerNewUserOpenFields.email,
        //                                   registerNewUserOpenFields.password,
        //                                   registerNewUserOpenFields.rePassword);

        //    registerScreen.GetInnerText_ErrorMessage().Should().Be("firstname is required.");
        //    registerScreen.Swipe(685, 900, 685, 2000, 500);
        //    registerScreen.AndroidClearRegisterFields();

        //    registerScreen.AndroidRegister(registerNewUserOpenFields.firstName,
        //                                   "",
        //                                   registerNewUserOpenFields.email,
        //                                   registerNewUserOpenFields.password,
        //                                   registerNewUserOpenFields.rePassword);

        //    registerScreen.GetInnerText_ErrorMessage().Should().Be("lastname is required.");
        //    registerScreen.Swipe(685, 900, 685, 2000, 500);
        //    registerScreen.AndroidClearRegisterFields();

        //    registerScreen.AndroidRegister(registerNewUserOpenFields.firstName,
        //                                   registerNewUserOpenFields.lastName,
        //                                   "",
        //                                   registerNewUserOpenFields.password,
        //                                   registerNewUserOpenFields.rePassword);

        //    registerScreen.GetInnerText_ErrorMessage().Should().Be("email is required.");
        //    registerScreen.Swipe(685, 900, 685, 2000, 500);
        //    registerScreen.AndroidClearRegisterFields();

        //    registerScreen.AndroidRegister(registerNewUserOpenFields.firstName,
        //                                   registerNewUserOpenFields.lastName,
        //                                   registerNewUserOpenFields.email,
        //                                   "",
        //                                   registerNewUserOpenFields.rePassword);

        //    registerScreen.GetInnerText_ErrorMessage().Should().Be("password is required.");
        //    registerScreen.Swipe(685, 900, 685, 2000, 500);
        //    registerScreen.AndroidClearRegisterFields();

        //    registerScreen.AndroidRegister(registerNewUserOpenFields.firstName,
        //                                   registerNewUserOpenFields.lastName,
        //                                   registerNewUserOpenFields.email,
        //                                   registerNewUserOpenFields.password,
        //                                   "");

        //    registerScreen.GetInnerText_ErrorMessage().Should().Be("password is required.");
        //    registerScreen.Swipe(685, 900, 685, 2000, 500);
        //    registerScreen.AndroidClearRegisterFields();

        //}


        //Error message element changes based on view, can't run this test
        //[Test]
        //[Description("Register with only 1 character in every inputfield [5.8]")]
        //public void Test_Register_User_With_1_Character_In_Every_Field()
        //{
        //    RegisterScreen registerScreen = new RegisterScreen(builder);
        //    LoginScreen loginScreen = new LoginScreen(builder);
        //    HomeScreen homeScreen = new HomeScreen(builder);

        //    homeScreen.WaitSeconds(20);
        //    homeScreen.ClickSignInButton();

        //    loginScreen.ClickGoToRegisterScreen();

        //    registerScreen.AndroidRegister(registerNewUser1Character.firstName,
        //                                   registerNewUser1Character.lastName,
        //                                   registerNewUser1Character.email,
        //                                   registerNewUser1Character.password,
        //                                   registerNewUser1Character.rePassword);

        //    registerScreen.GetInnerText_ErrorMessage().Should().Be("Please fill in a correct email-adress.");
        //    registerScreen.GetInnerText_ErrorMessage().Should().Be("Password should contain alteast 5 characters.");

        //}

    }
}
