using Automation_Framework.Tests.Screens;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Tests.TestMobile
{
    public class TestHomeScreen : BaseTest
    {
        [Test]
        [Description("HomeScreen functionalities (Press a movie banner) [1.1]")]
        public void Test_Press_A_Movie_Banner()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            DetailsScreen detailScreen = new DetailsScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.ClickMovieBanner();

            detailScreen.AndroidBackButton.Should();
            detailScreen.AndroidMovieTitle.Should();
            detailScreen.AndroidMovieDescription.Should();
            detailScreen.AndroidMoreInfo.Should();
            detailScreen.AndroidNameActorsTitle.Should();
            detailScreen.AndroidNameActor.Should();
            detailScreen.AndroidAvatarActor.Should();



            //detailScreen.AndroidPrice.Should();
            //detailScreen.AndroidGenres.Should();
            //detailScreen.AndroidRentMovieButton.Should();
            detailScreen.ClickBackButton();

        }
        [Test]
        [Description("HomeScreen functionalities Horizontal and Vertical Swipe [1.2]")]
        public void Test_Swipe_Horizontal_And_Vertical()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            DetailsScreen detailScreen = new DetailsScreen(builder);

            homeScreen.WaitSeconds(20);
            homeScreen.ClickMovieBanner();
            
           

        }
    }
}
