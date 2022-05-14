
using Automation_Framework.Tests.Screens;
using Automation_Framework.Tests.Tests.MobileTests;
using NUnit.Framework;

namespace Automation_Framework.Tests.Tests.TestMobile
{

    [Property("suiteid", "344")]
    [Property("projectid", "174")]
    public class TestSearchBarScreen : MobileBaseTest
    {

        [Test, Property("caseid", "7352")]
        [Description("Searchbar filters movies accordingly")]
        public void Test()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            navigationScreen.SearchbarTab.AndroidClick();
        }
    }
}
