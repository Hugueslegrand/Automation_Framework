
using Automation_Framework.Tests.Screens;

using NUnit.Framework;

namespace Automation_Framework.Tests.Tests.TestMobile
{
    public class TestSearchBarScreen : BaseTest
    {

        [Test]
        [Description("")]
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
