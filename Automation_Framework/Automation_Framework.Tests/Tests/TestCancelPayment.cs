using Automation_Framework.Base;
using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Tests
{
    public class TestCancelPayment : BaseTest
    {
        [Test]
        [Description("Test: CancelPayment")]
        public void Test_CancelPayment()
        {
            Navigation navigation = new Navigation(Driver);
            navigation.surfToUrl();
            navigation.WaitTemp();
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.Login("brent.dar@ap.be", "hond");
            loginPage.ScreenShot();


            Thread.Sleep(2000);
            navigation.ClickProfile();
            //Thread.Sleep(2000);
            navigation.WaitTemp();
            ProfilePage profilePage = new ProfilePage(Driver);
            profilePage.ClickAddCredits();
            profilePage.ClickAmountOfCredits();
            profilePage.FillAmountOfCredits("30");
            Thread.Sleep(2000);
            profilePage.ClickCancelPayment();
            Thread.Sleep(2000);

        }
    }
}
