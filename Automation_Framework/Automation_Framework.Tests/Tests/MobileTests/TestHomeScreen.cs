using Automation_Framework.Tests.Screens;
using Automation_Framework.Tests.Tests.MobileTests;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests.TestMobile
{
    [TestFixture]
    [Property("runname", "TestHomeScreen")]
    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestHomeScreen : MobileBaseTest
    {
        [Test, Property("caseid", "7325")]
        [Description("HomeScreen functionalities (Press a movie banner)")]
        public void Test_Press_A_Movie_Banner()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            DetailsScreen detailScreen = new DetailsScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.ClickMovieBanner();

            detailScreen.Swipe(685, 1400, 685, 800, 500);
            detailScreen.AndroidBackButton.Should();
            detailScreen.AndroidMovieTitle.Should();
            detailScreen.AndroidMovieDescription.Should();
            detailScreen.AndroidMoreInfo.Should();
            detailScreen.AndroidNameActorsTitle.Should();
            detailScreen.AndroidNameActor.Should();
            detailScreen.AndroidAvatarActor.Should();
            detailScreen.AndroidPrice.Should();
            detailScreen.AndroidGenres.Should();
            detailScreen.AndroidRentMovieButton.Should();
            detailScreen.ClickBackButton();

        }
        [Test, Property("caseid", "7326")]
        [Description("HomeScreen functionalities Horizontal and Vertical Swipe ")]
        public void Test_Swipe_Horizontal_And_Vertical()
        {
            HomeScreen homeScreen = new HomeScreen(builder);

            homeScreen.WaitSeconds(20);
            //Comedy Swipe left
            for (int i = 0; i < 4; i++)
                homeScreen.Swipe(1370, 870, 50, 870, 500);
            //Action Swipe left
            for (int i = 0; i < 4; i++)
                homeScreen.Swipe(1370, 1670, 50, 1670, 500);

            //Scroll UP
            homeScreen.Swipe(730, 2060, 730, 880, 500);

            //Romance Swipe left
            for (int i = 0; i < 4; i++)
                homeScreen.Swipe(1370, 1500, 50, 1500, 500);
            //Horror Swipe left
            for (int i = 0; i < 4; i++)
                homeScreen.Swipe(1370, 2300, 50, 2300, 500);

        }
    }
}
