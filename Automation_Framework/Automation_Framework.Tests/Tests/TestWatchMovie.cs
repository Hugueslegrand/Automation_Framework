
using Automation_Framework.Tests.Pages;
using Automation_Framework.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Automation_Framework.Base;

namespace Automation_Framework.Tests.Tests
{
    public class TestWatchMovie : BaseTest
    {
        [Test]
        [Description("Test: WatchMovie")]
        public void Test_WatchMovie()
        {
            Navigation navigation = new Navigation(builder._webDriver);
            navigation.surfToUrl();
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder._webDriver);

            loginPage.Login("brent.dar@ap.be", "hond");
            //loginPage.ScreenShot();

            
          
            navigation.ClickMyMovie();
            //Thread.Sleep(2000);
           
            MyMoviesPage watchMovie = new MyMoviesPage(builder._webDriver);
            watchMovie.ClickWatchNow();
            //Thread.Sleep(2000);

            watchMovie.ClickCloseModal();
        }
    }
}


