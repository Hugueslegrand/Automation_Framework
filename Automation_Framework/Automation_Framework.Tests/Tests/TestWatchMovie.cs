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
          
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login("brent.dar@ap.be", "hond");


            
          
            navigation.ClickMyMovie();
    
           
            MyMoviesPage watchMovie = new MyMoviesPage(builder);
            watchMovie.ClickWatchNow();
        

            watchMovie.ClickCloseModal();
        }
    }
}


