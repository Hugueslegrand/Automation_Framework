using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using System.Threading;


namespace Automation_Framework.Tests.Tests
{
    public class TestLogin : BaseTest
    {


        [Test]
        [Description("Login as administrator")]
        public void Test_LoginAsAdmin_POM()
        {
            Navigation navigation = new Navigation(builder);
            navigation.surfToUrl();
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login("brent.dar@ap.be", "hond");

        }
      /*  [Test]
        public void LoginWithAdmin()
        {
            Thread.Sleep(10000);
            HomePage homeScreen = new HomePage(AndroidDriver);
            homeScreen.ClickSignInButton();

            LoginPage loginScreen = new LoginPage(AndroidDriver);
            loginScreen.Login1("brent.dar@ap.be", "hond");
        }*/
    }
}
