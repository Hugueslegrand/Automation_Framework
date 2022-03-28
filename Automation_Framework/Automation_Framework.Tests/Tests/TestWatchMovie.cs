using Automation_Framework.Tests.Pages;
using FluentAssertions;
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
            //loginPage.ScreenShot();

            navigation.ClickMyMovie();
            //Thread.Sleep(2000);
           
            MyMoviesPage watchMovie = new MyMoviesPage(builder);
            watchMovie.ClickWatchNow();
            //Thread.Sleep(2000);

            watchMovie.ClickCloseModal();
        }

        [Test]
        [Description("Test: Visual Layout Of Order Page")]
        public void Test_Visual_Layout_Of_Order_Page()
        {
            Navigation navigation = new Navigation(builder);
          
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            //loginPage.Login("brent.dar@ap.be", "hond");
            loginPage.Login("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");


            navigation.ClickMyMovie();

            MyMoviesPage watchMovie = new MyMoviesPage(builder);

            watchMovie.GetInnerText_MovieTitle().Should().Be("ROALD DAHL'S THE WITCHES");
            watchMovie.GetInnerText_MovieAvailableDate().Should().Be("AVAILABLE UNTIL: 04/04/2022");
            watchMovie.ClickWatchNow();
            //Thread.Sleep(2000);

            watchMovie.ClickCloseModal();
        }


    }
}


