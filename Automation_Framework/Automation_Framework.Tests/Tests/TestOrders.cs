using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using System.Threading;
using FluentAssertions;
using Automation_Framework.Tests.Models;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Automation_Framework.Tests.Tests
{

    public class TestOrders : BaseTest
    {
        User userAdminExist = new("brent.dar@ap.be", "hond123");

        [Test]
        [Description("Login as an existing user")]
        public void Test_Orders()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.ClickSignIn();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(userAdminExist.email, userAdminExist.password);

            navigation.ClickMyMovie();
          
        }
    }
}
