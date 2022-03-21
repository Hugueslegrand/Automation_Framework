using Automation_Framework.Tests.Models;
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
    public class TestMovieModal : BaseTest
    {
        public User UserAdminLogin_Exist()
        {
            return new User
            {
                email = "brent.dar@ap.be",
                password = "hond",
            };
        }
        [Test]
        [Description("Test: MoreInfo")]
        public void Test_MoreInfo()
        {
            User user = UserAdminLogin_Exist();
            Navigation navigation = new Navigation(builder);

            Thread.Sleep(6000);

            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(user.email, user.password);

            HomePage homePage = new HomePage(builder);
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

        [Test]
        [Description("Test: RentMovieButton")]
        public void Test_RentMovieButton()
        {
            User user = UserAdminLogin_Exist();
            Navigation navigation = new Navigation(builder);

            Thread.Sleep(6000);

            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);

            loginPage.Login(user.email, user.password);

            HomePage homePage = new HomePage(builder);
            Thread.Sleep(2000);
            homePage.ClickMovieBanner();
            Thread.Sleep(2000);
            homePage.ClickRentThisMovie();

            Thread.Sleep(3000);


            //  Thread.Sleep(2000);
            //  navigation.ClickSearchBar();
            //  navigation.FillSearchBar("A Whisker Away");
            //
            //  Thread.Sleep(4000);
        }
    }
}
