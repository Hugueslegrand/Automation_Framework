using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using System.Threading;

namespace Automation_Framework.Tests.Tests
{
    public class TestWatchMovie : BaseTest
    {
        [Test]
        [Description("Test: WatchMovie")]
        public void Test_WatchMovie()
        {
            Navigation navigation = new Navigation(builder);
            navigation.surfToUrl();
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login("brent.dar@ap.be", "hond");
            //loginPage.ScreenShot();

            
          
            navigation.ClickMyMovie();
            //Thread.Sleep(2000);
           
            MyMoviesPage watchMovie = new MyMoviesPage(builder);
            watchMovie.ClickWatchNow();
            //Thread.Sleep(2000);

            watchMovie.ClickCloseModal();
        }
    }
}


