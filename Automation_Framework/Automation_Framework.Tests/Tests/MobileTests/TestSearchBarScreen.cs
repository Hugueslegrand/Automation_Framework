
using Automation_Framework.Tests.Screens;

using NUnit.Framework;

namespace Automation_Framework.Tests.Tests.MobileTests
{
    public class TestSearchBarScreen : BaseTest
    {

        [Test]
        [Description("Visual layout of profile screen [3.1]")]
        public void Test_Visual_Layout_Of_ProfileScreen()
        {
            HomeScreen homeScreen = new HomeScreen(builder);
            LoginScreen loginScreen = new LoginScreen(builder);
            NavigationScreen navigationScreen = new NavigationScreen(builder);
            ProfileScreen profileScreen = new ProfileScreen(builder);

            navigationScreen.SearchbarTab.AndroidClick();
        }
    }
}
