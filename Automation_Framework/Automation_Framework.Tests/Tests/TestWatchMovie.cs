﻿using Automation_Framework.Base;
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
    public class TestWatchMovie : BaseTest
    {
        [Test]
        [Description("Test: WatchMovie")]
        public void Test_WatchMovie()
        {
            Navigation navigation = new Navigation(Driver);
            navigation.surfToUrl();
            Thread.Sleep(6000);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.Login("brent.dar@ap.be", "hond");

            Thread.Sleep(2000);
            navigation.ClickMyMovie();
            Thread.Sleep(2000);

            MyMoviesPage watchMovie = new MyMoviesPage(Driver);
            watchMovie.ClickWatchNow();
            Thread.Sleep(2000);

            watchMovie.ClickCloseModal();
        }
    }
}


