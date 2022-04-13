using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using System.Threading;
using FluentAssertions;
using Automation_Framework.Tests.Models;


namespace Automation_Framework.Tests.Tests
{
    public class TestSearchBar : BaseTest
    {
        User normalUser = new("Pirate@King.com", "onepiece111");
        User admin = new("Brent.dar@ap.be", "hond123");


        [Test]
        [Description("Check if searchbar is active and available for all types of users")]
        public void Test_SearchBar_Available()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.SearchBar.Should();
            navigation.SearchBar.ClickOnElement();
            navigation.ClickSignIn();
            LoginPage loginPage = new LoginPage(builder);
            loginPage.Login(normalUser.email, normalUser.password);
            navigation.SearchBar.Should();
            navigation.SearchBar.ClickOnElement();
            navigation.ClickSignOut();
            navigation.ClickSignIn();
            loginPage.Login(admin.email, admin.password);
            navigation.SearchBar.Should();
            navigation.SearchBar.ClickOnElement();
           
        }

        [Test]
        [Description("Check if searchbar filters the right movie with different types of input")]
        public void Test_SearchBar_Functionality()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.SearchBar.Should();
            navigation.SearchBar.ClickOnElement();

            navigation.SearchBarDropDown.Should();
            navigation.SearchBarDropDown.ClickOnElement();

            navigation.SearchBarDropDown.SendKeys("A Whisker Away");
            navigation.DropdownAWhiskerAway.Should();
            navigation.SearchBarDropDown.Clear();

            navigation.SearchBarDropDown.SendKeys("Taxi 5");
            navigation.DropdownNoOption.Should();
            navigation.SearchBarDropDown.Clear();

            navigation.SearchBarDropDown.SendKeys("a whisker away");
            navigation.DropdownAWhiskerAway.Should();
            navigation.SearchBarDropDown.Clear();

            navigation.SearchBarDropDown.SendKeys("A WHISKER AWAY");
            navigation.DropdownAWhiskerAway.Should();
            navigation.SearchBarDropDown.Clear();

            navigation.SearchBarDropDown.SendKeys("Dèmön släyër thé mövïë: mùgèn tràïn");
            navigation.DropdownDemonSlayer.Should();
            navigation.SearchBarDropDown.Clear();

        }
    }
}