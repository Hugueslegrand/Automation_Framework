using Automation_Framework.Tests.Pages;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests
{

    public class TestWatchMovie : BaseTest
    {


        [Test]
        [Description("Test: WatchMovie")]
        public void Test_WatchMovie()
        {
            Navigation navigation = new Navigation(builder);

            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login("brent.dar@ap.be", "hond123");
            //loginPage.ScreenShot();

            navigation.MyMovieButton.ClickOnElement();
            //Thread.Sleep(2000);

            MyMoviesPage watchMovie = new MyMoviesPage(builder);
            watchMovie.WatchNowButton.ClickOnElement();
            //Thread.Sleep(2000);

            watchMovie.CloseModalButton.ClickOnElement();
        }

        [Test]
        [Description("Test: Visual Layout Of Order Page")]
        public void Test_Visual_Layout_Of_Order_Page()
        {
            Navigation navigation = new Navigation(builder);

            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.SignInButton.ClickOnElement();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login("brent.dar@ap.be", "hond123");
            //loginPage.Login("stageadmin@stageadmin.stageadmin", "StageAdmin0221!");


            navigation.MyMovieButton.ClickOnElement();

            MyMoviesPage watchMovie = new MyMoviesPage(builder);
            watchMovie.WaitSeconds(3);
            watchMovie.MovieTitle.Text.Should().Be("AVA");
            watchMovie.MovieAvailableDate.Text.Should().Be("AVAILABLE UNTIL: 02/05/2022");
            watchMovie.WatchNowButton.ClickOnElement();
            //Thread.Sleep(2000);

            watchMovie.CloseModalButton.ClickOnElement();
        }


    }
}