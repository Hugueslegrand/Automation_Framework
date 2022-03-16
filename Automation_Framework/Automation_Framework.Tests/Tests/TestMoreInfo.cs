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
    public class TestMoreInfo : BaseTest
    {
        [Test]
        [Description("Test: MoreInfo")]
        public void Test_MoreInfo()
        {
            Navigation navigation = new Navigation(Driver);
            navigation.surfToUrl();
            Thread.Sleep(2000);
            navigation.WaitTemp();
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.Login("brent.dar@ap.be", "hond");

            HomePage homePage = new HomePage(Driver);
            Thread.Sleep(2000);
            homePage.ClickMovieBanner();
            Thread.Sleep(2000);
            homePage.ClickMoreInfo();

            Thread.Sleep(3000);


          //  Thread.Sleep(2000);
          //  navigation.ClickSearchBar();
          //  navigation.FillSearchBar("A Whisker Away");
          //
          //  Thread.Sleep(4000);
          


        }
    }
}
