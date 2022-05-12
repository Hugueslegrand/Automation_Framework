
using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using Automation_Framework.Tests.Tests.MobileTests;
using FluentAssertions;
using NUnit.Framework;

namespace Automation_Framework.Tests.Tests.TestMobile
{
    [TestFixture]
    [Property("runname", "TestAdminPanelScreen")]
    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestAdminPanelScreen : MobileBaseTest
    {
        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        [Test, Property("caseid", "7322")]
        [Description("Admin is able to navigate to admin panel and the necessary elements are present.")]
        public void Test_AdminPanel_elements_are_present()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);


            homeScreen.SettingsButton.AndroidClick();

            AdminPanelScreen adminPanelScreen = new AdminPanelScreen(builder);
            adminPanelScreen.BrightestLogo.Should();
            adminPanelScreen.LogoutButton.Should();
            adminPanelScreen.HomeButton.Should();
            adminPanelScreen.BugsButton.Should();
            adminPanelScreen.UsersButton.Should();
            adminPanelScreen.LogsButton.Should();
            adminPanelScreen.BugsButton.AndroidClick();
            adminPanelScreen.FirstBugName.Should();
            adminPanelScreen.FirstBugDescription.Should();
            adminPanelScreen.FirstBugInfoIcon.Should();
            adminPanelScreen.FirstBugToggleBug.Should();
            adminPanelScreen.AllBugsOff.Should();
            adminPanelScreen.AllBugsOn.Should();

            adminPanelScreen.LogsButton.AndroidClick();
            adminPanelScreen.DeleteAllLogs.Should();
            adminPanelScreen.FirstLogToggleInfo.AndroidClick();
            adminPanelScreen.FirstLogDate.Should();
            adminPanelScreen.FirstLogMethod.Should();
            adminPanelScreen.FirstLogType.Should();
            adminPanelScreen.FirstLogCode.Should();
            adminPanelScreen.FirstLogPath.Should();

            adminPanelScreen.UsersButton.AndroidClick();
            adminPanelScreen.FirstUserToggleInfo.AndroidClick();
            adminPanelScreen.FirstUserEmail.Should();
            adminPanelScreen.FirstUserID.Should();
            adminPanelScreen.FirstUserFirstName.Should();
            adminPanelScreen.FirstUserLastName.Should();
            adminPanelScreen.FirstUserRole.Should();
            adminPanelScreen.FirstUserCredits.Should();
            adminPanelScreen.EditRoleField.Should();
            adminPanelScreen.FirstUserDeleteButton.Should();

        }

        [Test, Property("caseid", "7321")]
        [Description("Admin Bugs Screen (functional tests)")]
        public void Test_AdminPanel_bugs_funtionality()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);


            homeScreen.SettingsButton.AndroidClick();

            AdminPanelScreen adminPanelScreen = new AdminPanelScreen(builder);
            adminPanelScreen.BugsButton.AndroidClick();
            adminPanelScreen.AllBugsOn.AndroidClick();
            adminPanelScreen.FirstBugToggleBug.AndroidText.Should().Be("ON");
            adminPanelScreen.AllBugsOff.AndroidClick();
            adminPanelScreen.FirstBugToggleBug.AndroidText.Should().Be("OFF");
            adminPanelScreen.FirstBugToggleBug.AndroidClick();
            adminPanelScreen.FirstBugToggleBug.AndroidText.Should().Be("ON");
            adminPanelScreen.FirstBugToggleBug.AndroidClick();
            adminPanelScreen.FirstBugToggleBug.AndroidText.Should().Be("OFF");
            adminPanelScreen.AllBugsOff.AndroidClick();
        }

        //This test will delete logs up to the given date.
        [Test, Property("caseid", "7323")]
        [Description("Admin Logs Screen (functional tests)")]
        public void Test_AdminPanel_logs_funtionality()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);


            homeScreen.SettingsButton.AndroidClick();

            AdminPanelScreen adminPanelScreen = new AdminPanelScreen(builder);
            adminPanelScreen.LogsButton.AndroidClick();
            adminPanelScreen.DeleteAllLogs.Should();
            adminPanelScreen.FirstLogToggleInfo.AndroidClick();
            adminPanelScreen.FirstLogDate.Should();
            adminPanelScreen.FirstLogMethod.Should();
            adminPanelScreen.FirstLogType.Should();
            adminPanelScreen.FirstLogCode.Should();
            adminPanelScreen.FirstLogPath.Should();
            adminPanelScreen.DeleteAllLogs.AndroidClick();
            adminPanelScreen.SelectDate.Should();
            adminPanelScreen.DeleteAllLogYes.Should();
            adminPanelScreen.DeleteAllLogNo.Should();
            adminPanelScreen.SelectDate.AndroidClick();
            adminPanelScreen.Date.AndroidClick();
            adminPanelScreen.OKButton.AndroidClick();
            adminPanelScreen.DeleteAllLogs.AndroidClick();
            adminPanelScreen.DeleteAllLogNo.AndroidClick();

        }

        [Test, Property("caseid", "7324")]
        [Description("Edit first user credits")]
        public void Test_AdminPanel_user_Credits()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(20);
            homeScreen.SignInButton.Should();
            homeScreen.ClickSignInButton();

            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);


            homeScreen.SettingsButton.AndroidClick();

            AdminPanelScreen adminPanelScreen = new AdminPanelScreen(builder);
            adminPanelScreen.UsersButton.AndroidClick();
            adminPanelScreen.FirstUserToggleInfo.AndroidClick();
            adminPanelScreen.FirstUserEditButton.AndroidClick();
            adminPanelScreen.EditCreditsField.AndroidClick();
            adminPanelScreen.EditCreditsField.AndroidClear();
            adminPanelScreen.EditCreditsField.AndroidSendKeys("200");
            adminPanelScreen.SubmitButton.AndroidClick();
            adminPanelScreen.FirstUserCredits.AndroidText.Should().Be("Credits: 200");

        }
    }
}
