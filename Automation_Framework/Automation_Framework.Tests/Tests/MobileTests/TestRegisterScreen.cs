using Automation_Framework.Enums;
using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Pages;
using Automation_Framework.Tests.Screens;
using Automation_Framework.Tests.Tests.MobileTests;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests.TestMobile
{

    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestRegistration : MobileBaseTest
    {
        User registerNewUser = new User("luffy", "monkey", "luffy@monkey.ap.be", "strawhat", "strawhat");
        User registerUsedUser = new User("Zoro", "Rononoa", "luffy@monkey.ap.be", "hunter", "hunter");
        User registerNewUserUnmatchingPasswords = new User("Maxi", "Cosi", "MaxiCosi@ap.be", "Maxi123", "Cosi123");
        User registerNewUserUpperCase = new User("RAKEEM", "BEST", "RAKEEMG@GMAIL.COM", "CHIPCHOP", "CHIPCHOP");
        User registerNewUserLowerCase = new User("tupac", "shakur", "2pacwzt@coast.com", "thuglife", "thuglife");
        User registerNewUserNumbers = new User("12345", "12345", "12345@12345.12345", "12345", "12345");
        User registerNewUserLeadingSpacebar = new User(" nami"," navigator", " nami@brightest.be"," strawhat1234"," strawhat1234");
        User registerNewUserSpecialCharacters = new User("Zaweh","Ewaz", "|^¦¢¥§¶¡@brightest.be", "|^¦¢¥§¶¡", "|^¦¢¥§¶¡");
        User registerNewUserOpenFields = new User("Sunny","Sunny","sunny@ap.be","sunny","sunny");
        User registerNewUser1Character = new User("k", "k", "k", "k", "k");


        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");


        [Test, Order(1), Property("caseid", "7344")]
        [Description("Register a new user and log in to verify ")]
        public void Test_Register_A_New_User()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);

            homeScreen.WaitSeconds(50);
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            loginScreen.ClickGoToRegisterScreen();
            homeScreen.WaitSeconds(4);
            registerScreen.AndroidRegister(registerNewUser.firstName,
                                           registerNewUser.lastName,
                                           registerNewUser.email,
                                           registerNewUser.password,
                                           registerNewUser.rePassword);
            homeScreen.WaitSeconds(4);
            loginScreen.AndroidLogin(registerNewUser.email, registerNewUser.password);
            homeScreen.WaitSeconds(4);
            homeScreen.SignOutButton.Should();
            navigationScreen.HomeTab.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();
            navigationScreen.SearchbarTab.Should();
        }


        [Test, Order(2), Property("caseid", "7345")]
        [Description("Register a used user ")]
        public void Test_Register_A_Used_User()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);

            homeScreen.WaitSeconds(50);
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            loginScreen.ClickGoToRegisterScreen();
            homeScreen.WaitSeconds(4);
            registerScreen.AndroidRegister(registerUsedUser.firstName,
                                           registerUsedUser.lastName,
                                           registerUsedUser.email,
                                           registerUsedUser.password,
                                           registerUsedUser.rePassword);
            homeScreen.WaitSeconds(4);
            registerScreen.GetInnerText_ErrorMessage().Should().Be("Account is already registered.");


        }

        [Test, Order(3)]
        [Description("Register uppercase user and log in to verify ")]
        public void Test_Register_UpperCase_User()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);

            homeScreen.WaitSeconds(50);
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            loginScreen.ClickGoToRegisterScreen();
            homeScreen.WaitSeconds(4);
            registerScreen.AndroidRegister(registerNewUserUpperCase.firstName,
                                           registerNewUserUpperCase.lastName,
                                           registerNewUserUpperCase.email,
                                           registerNewUserUpperCase.password,
                                           registerNewUserUpperCase.rePassword);
            homeScreen.WaitSeconds(4);
            loginScreen.AndroidLogin(registerNewUserUpperCase.email, registerNewUserUpperCase.password);
            homeScreen.WaitSeconds(4);
            homeScreen.SignOutButton.Should();
            navigationScreen.HomeTab.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();
            navigationScreen.SearchbarTab.Should();
        }

        [Test, Order(4)]
        [Description("Register lowercase user and log in to verify ")]
        public void Test_Register_LowerCase_User()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);

            homeScreen.WaitSeconds(50);
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            loginScreen.ClickGoToRegisterScreen();
            homeScreen.WaitSeconds(4);
            registerScreen.AndroidRegister(registerNewUserLowerCase.firstName,
                                           registerNewUserLowerCase.lastName,
                                           registerNewUserLowerCase.email,
                                           registerNewUserLowerCase.password,
                                           registerNewUserLowerCase.rePassword);
            homeScreen.WaitSeconds(4);
            loginScreen.AndroidLogin(registerNewUserLowerCase.email, registerNewUserLowerCase.password);
            homeScreen.WaitSeconds(4);
            homeScreen.SignOutButton.Should();
            navigationScreen.HomeTab.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();
            navigationScreen.SearchbarTab.Should();
        }

        [Test, Order(5), Property("caseid", "7346")]
        [Description("Register a new user with unmatching passwords ")]
        public void Test_Register_Unmatching_Passwords()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);

            homeScreen.WaitSeconds(50);
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            loginScreen.ClickGoToRegisterScreen();
            homeScreen.WaitSeconds(4);
            registerScreen.AndroidRegister(registerNewUserUnmatchingPasswords.firstName,
                                             registerNewUserUnmatchingPasswords.lastName,
                                             registerNewUserUnmatchingPasswords.email,
                                             registerNewUserUnmatchingPasswords.password,
                                             registerNewUserUnmatchingPasswords.rePassword);
            homeScreen.WaitSeconds(4);
            registerScreen.GetInnerText_ErrorMessage().Should().Be("Passwords don't match.");
        }

        [Test, Order(6), Property("caseid", "7347")]
        [Description("Register user with numbers")]
        public void Test_Register_User_With_Numbers()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);

            //AllScreens allScreens = new AllScreens(builder);

            homeScreen.WaitSeconds(50);
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            loginScreen.ClickGoToRegisterScreen();
            // loginScreen.GoToRegisterScreen.AndroidClick();
            homeScreen.WaitSeconds(4);
            registerScreen.AndroidRegister(registerNewUserNumbers.firstName,
                                           registerNewUserNumbers.lastName,
                                           registerNewUserNumbers.email,
                                           registerNewUserNumbers.password,
                                           registerNewUserNumbers.rePassword);
            homeScreen.WaitSeconds(4);
            registerScreen.GetInnerText_ErrorMessage().Should().Be("Please fill in a correct email-adress.");


        }

        [Test, Order(7), Property("caseid", "7348")]
        [Description("Register user lead with a spacebar in the inputfields ")]
        public void Test_Register_User_Lead_With_Spacebar()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);

            homeScreen.WaitSeconds(50);
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            loginScreen.ClickGoToRegisterScreen();
            homeScreen.WaitSeconds(4);
            registerScreen.AndroidRegister(registerNewUserLeadingSpacebar.firstName,
                                             registerNewUserLeadingSpacebar.lastName,
                                             registerNewUserLeadingSpacebar.email,
                                             registerNewUserLeadingSpacebar.password,
                                             registerNewUserLeadingSpacebar.rePassword);
            homeScreen.WaitSeconds(4);
            loginScreen.AndroidLogin(registerNewUserLeadingSpacebar.email, registerNewUserLeadingSpacebar.password);
            homeScreen.WaitSeconds(4);
            homeScreen.SignOutButton.Should();
            navigationScreen.HomeTab.Should();
            navigationScreen.MyMoviesTab.Should();
            navigationScreen.ProfileTab.Should();
            navigationScreen.SearchbarTab.Should();
        }

        [Test, Order(8), Property("caseid", "7349")]
        [Description("Register user with special characters")]
        public void Test_Register_User_With_Special_Characters()
        {
            RegisterScreen registerScreen = new RegisterScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            HomeScreen homeScreen = new HomeScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);

            homeScreen.WaitSeconds(50);
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            loginScreen.ClickGoToRegisterScreen();
            homeScreen.WaitSeconds(4);
            registerScreen.AndroidRegister(registerNewUserSpecialCharacters.firstName,
                                             registerNewUserSpecialCharacters.lastName,
                                             registerNewUserSpecialCharacters.email,
                                             registerNewUserSpecialCharacters.password,
                                             registerNewUserSpecialCharacters.rePassword);
            homeScreen.WaitSeconds(4);
           
          
            bool result;
            try
            { loginScreen.AndroidLogin(registerNewUserSpecialCharacters.email, registerNewUserSpecialCharacters.password);
            homeScreen.WaitSeconds(4);
                homeScreen.SignOutButton.Should();
                navigationScreen.HomeTab.Should();
                navigationScreen.MyMoviesTab.Should();
                navigationScreen.ProfileTab.Should();
                navigationScreen.SearchbarTab.Should();
                result = false;

            }
            catch (System.Exception)
            {
                result = true;

            }
            if (result)
                Assert.Pass();
            Assert.Fail();

        }

        //Error message element changes based on view, can't run this test
        //[Test]
        //[Description("Register user with few open fields ")]
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
        //[Description("Register with only 1 character in every inputfield ")]
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
        [Test, Order(9), Property("caseid", "7355")]
        [Description("Delete registered Users for continious testing")]
        public void Test_RemoveRegisteredUsers()
        {
            builder.BuildDriver(PlatformType.Desktop);
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ScaleScreen("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userAdminExist.email, userAdminExist.password);

     
            navigation.SettingsButton.ClickOnElement();

            AdminPanelPage adminPanelPage = new AdminPanelPage(builder);
            adminPanelPage.UsersMenu.ClickOnElement();
            adminPanelPage.WaitSeconds(1);
            adminPanelPage.RemoveUserByEmail(registerNewUser.email);
            adminPanelPage.RemoveUserByEmail("nami@brightest.be");
            adminPanelPage.RemoveUserByEmail(registerNewUserLowerCase.email);
            adminPanelPage.RemoveUserByEmail(registerNewUserUpperCase.email);
            adminPanelPage.RemoveUserByEmail(registerNewUserSpecialCharacters.email);
            adminPanelPage.WaitSeconds(1);
            builder.CloseDriver(PlatformType.Desktop);
        }

    }
}
