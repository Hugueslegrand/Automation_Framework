using Automation_Framework.Tests.Pages;
using NUnit.Framework;

using FluentAssertions;
using Automation_Framework.Tests.Models;


namespace Automation_Framework.Tests.Tests
{
    [TestFixture]
    
    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestAdminPanel : BaseTest
    {

        User userAdminExist = new User("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        [Test, Order(1), Property("caseid", "7287")]
        [Description("Test: Set-Up for Testing by setting of all Bugs")]
        public void Test_AdminPanel_BugsOFf()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userAdminExist.email, userAdminExist.password);

            navigation.SettingsButton.Should();
            navigation.SettingsButton.ClickOnElement();
            navigation.WaitSeconds(6);


            AdminPanelPage adminPanelPage = new AdminPanelPage(builder);
            adminPanelPage.AllBugsOff.ClickOnElement();
        }

        [Test, Property("caseid", "7289")]
        [Description("Asserting presence of all neccesary elements in the AdminPanelPage")]
        public void Test_AdminPanel()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userAdminExist.email, userAdminExist.password);

            navigation.SettingsButton.Should();
            navigation.SettingsButton.ClickOnElement();
            navigation.WaitSeconds(6);


            AdminPanelPage adminPanelPage = new AdminPanelPage(builder);
            adminPanelPage.AllBugsOff.Should();
            adminPanelPage.AllBugsOn.Should();
            adminPanelPage.TableHeadBugsName.Should();
            adminPanelPage.TableHeadBugsDescription.Should();
            adminPanelPage.TableHeadBugsInfo.Should();
            adminPanelPage.TableHeadBugsFunctionality.Should();
            adminPanelPage.TableHeadBugsComponent.Should();
            adminPanelPage.TableHeadBugsDifficulty.Should();
            adminPanelPage.TableHeadBugsToggle.Should();
            adminPanelPage.WaitSeconds(2);

            adminPanelPage.HamburgerMenu.Should();
            adminPanelPage.HamburgerMenu.ClickOnElement();
            adminPanelPage.LogsMenu.ClickOnElement();
            adminPanelPage.TableHeadLogsType.Should();
            adminPanelPage.TableHeadLogsMethod.Should();
            adminPanelPage.TableHeadLogsResponse.Should();
            adminPanelPage.TableHeadLogsMessage.Should();
            adminPanelPage.TableHeadLogsPath.Should();
            adminPanelPage.TableHeadLogsDate.Should();
            adminPanelPage.WaitSeconds(2);

            adminPanelPage.UsersMenu.ClickOnElement();
            adminPanelPage.TableHeadUsersID.Should();
            adminPanelPage.TableHeadUsersFirstName.Should();
            adminPanelPage.TableHeadUsersLastName.Should();
            adminPanelPage.TableHeadUsersEmail.Should();
            adminPanelPage.TableHeadUsersRole.Should();
            adminPanelPage.TableHeadUsersCredits.Should();
            adminPanelPage.TableHeadUsersEdit.Should();
            adminPanelPage.TableHeadUsersRemove.Should();
        }

        [Test, Property("caseid", "7290")]
        [Description("Test: Editing an user's credit amount by email")]
        public void Test_EditCreditsByEmail()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userAdminExist.email, userAdminExist.password);

            navigation.SettingsButton.Should();
            navigation.SettingsButton.ClickOnElement();
            navigation.WaitSeconds(6);


            AdminPanelPage adminPanelPage = new AdminPanelPage(builder);
            adminPanelPage.UsersMenu.ClickOnElement();
            adminPanelPage.EditUserByEmaill("vader@ap.be");
            adminPanelPage.WaitSeconds(3);
            adminPanelPage.EditCredits("5");
            adminPanelPage.WaitSeconds(3);
            adminPanelPage.SaveButton.ClickOnElement();


        }

    }
}