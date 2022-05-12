
using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Screens;
using Automation_Framework.Tests.Tests.MobileTests;
using FluentAssertions;
using NUnit.Framework;

namespace Automation_Framework.Tests.Tests.TestMobile
{
  
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
            homeScreen.WaitSeconds(50);
            
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(5);

            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);
            homeScreen.WaitSeconds(5);

            homeScreen.SettingsButton.AndroidClick();

            AdminPanelScreen adminPanelScreen = new AdminPanelScreen(builder);
            homeScreen.WaitSeconds(4);
            adminPanelScreen.BrightestLogo.Should();
            adminPanelScreen.LogoutButton.Should();
            adminPanelScreen.HomeButton.Should();
            adminPanelScreen.BugsButton.Should();
            adminPanelScreen.UsersButton.Should();
            adminPanelScreen.LogsButton.Should();
            adminPanelScreen.BugsButton.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.FirstBugName.Should();
            adminPanelScreen.FirstBugDescription.Should();
            adminPanelScreen.FirstBugInfoIcon.Should();
            adminPanelScreen.FirstBugToggleBug.Should();
            adminPanelScreen.AllBugsOff.Should();
            adminPanelScreen.AllBugsOn.Should();

            adminPanelScreen.LogsButton.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.DeleteAllLogs.Should();
            adminPanelScreen.FirstLogToggleInfo.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.FirstLogDate.Should();
            adminPanelScreen.FirstLogMethod.Should();
            adminPanelScreen.FirstLogType.Should();
            adminPanelScreen.FirstLogCode.Should();
            adminPanelScreen.FirstLogPath.Should();

            adminPanelScreen.UsersButton.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.FirstUserToggleInfo.AndroidClick();
            homeScreen.WaitSeconds(4);
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
            homeScreen.WaitSeconds(50);
           
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(5);
            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);

            homeScreen.WaitSeconds(4);
            homeScreen.SettingsButton.AndroidClick();
            homeScreen.WaitSeconds(4);
            AdminPanelScreen adminPanelScreen = new AdminPanelScreen(builder);
            adminPanelScreen.BugsButton.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.AllBugsOn.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.FirstBugToggleBug.AndroidText.Should().Be("ON");
            adminPanelScreen.AllBugsOff.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.FirstBugToggleBug.AndroidText.Should().Be("OFF");
            adminPanelScreen.FirstBugToggleBug.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.FirstBugToggleBug.AndroidText.Should().Be("ON");
            adminPanelScreen.FirstBugToggleBug.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.FirstBugToggleBug.AndroidText.Should().Be("OFF");
            adminPanelScreen.AllBugsOff.AndroidClick();
            homeScreen.WaitSeconds(4);
        }

        //This test will delete logs up to the given date.
        [Test, Property("caseid", "7323")]
        [Description("Admin Logs Screen (functional tests)")]
        public void Test_AdminPanel_logs_funtionality()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(50);
          
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);

            homeScreen.WaitSeconds(4);
            homeScreen.SettingsButton.AndroidClick();
            homeScreen.WaitSeconds(4);
            AdminPanelScreen adminPanelScreen = new AdminPanelScreen(builder);
            adminPanelScreen.LogsButton.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.DeleteAllLogs.Should();
            adminPanelScreen.FirstLogToggleInfo.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.FirstLogDate.Should();
            adminPanelScreen.FirstLogMethod.Should();
            adminPanelScreen.FirstLogType.Should();
            adminPanelScreen.FirstLogCode.Should();
            adminPanelScreen.FirstLogPath.Should();
            adminPanelScreen.DeleteAllLogs.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.SelectDate.Should();
            adminPanelScreen.DeleteAllLogYes.Should();
            adminPanelScreen.DeleteAllLogNo.Should();
            adminPanelScreen.SelectDate.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.Date.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.OKButton.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.DeleteAllLogs.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.DeleteAllLogNo.AndroidClick();
            homeScreen.WaitSeconds(1);

        }

        [Test, Property("caseid", "7324")]
        [Description("Edit first user credits")]
        public void Test_AdminPanel_user_Credits()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            homeScreen.WaitSeconds(50);
          
            homeScreen.ClickSignInButton();
            homeScreen.WaitSeconds(4);
            LoginScreen loginScreen = new LoginScreen(builder);
            loginScreen.AndroidLogin(userAdminExist.email, userAdminExist.password);

            homeScreen.WaitSeconds(4);
            homeScreen.SettingsButton.AndroidClick();
            homeScreen.WaitSeconds(4);
            AdminPanelScreen adminPanelScreen = new AdminPanelScreen(builder);
            adminPanelScreen.UsersButton.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.FirstUserToggleInfo.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.FirstUserEditButton.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.EditCreditsField.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.EditCreditsField.AndroidClear();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.EditCreditsField.AndroidSendKeys("200");
            adminPanelScreen.SubmitButton.AndroidClick();
            homeScreen.WaitSeconds(4);
            adminPanelScreen.FirstUserCredits.AndroidText.Should().Be("Credits: 200");

        }
    }
}
