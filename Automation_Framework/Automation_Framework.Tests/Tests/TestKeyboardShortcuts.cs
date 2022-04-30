﻿using Automation_Framework.Tests.Pages;
using NUnit.Framework;

using FluentAssertions;
using Automation_Framework.Tests.Models;


namespace Automation_Framework.Tests.Tests
{
    [TestFixture]
    [Property("suiteid", "2")]
    [Property("projectid", "1")]
    public class TestKeyboardShortcuts : BaseTest
    {
        User userAdminExist = new("brent.dar@ap.be", "hond123");

        [Test, Property("caseid", "2")]
        [Description("Login as an existing user only using keyboard")]
        public void Test_KeyboardShortcuts()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.PressTab();
            navigation.PressTab();
            navigation.PressTab();
            navigation.PressTab();
            navigation.PressTab();
            navigation.PressEnter();
           
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Should();
            navigation.PressTab();
            navigation.PressTab();
            navigation.PressTab();
            loginPage.PressTab();
            loginPage.SignInEmail.SendKeys(userAdminExist.email);
            loginPage.PressEnter();
            loginPage.SignInPassword.SendKeys(userAdminExist.password);
            loginPage.PressEnter();
            navigation.SignOutButton.Should();
            navigation.MyMovieButton.Should();
            navigation.ProfileButton.Should();

        }
    }
}
