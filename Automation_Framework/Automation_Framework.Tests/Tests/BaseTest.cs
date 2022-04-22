using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.Models;
using Automation_Framework.TestRail.Service;
using Automation_Framework.Tests.Pages;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Automation_Framework.Tests.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class BaseTest : TestRailBaseTest
    {
        public DriverBuilder builder = new DriverBuilder();
     

        [SetUp]
        public void Setup()
        {
            builder.BuildDriver(PlatformType.Desktop);
        }

        [TearDown]
        public void TearDown()
        {
            builder.CloseAllDrivers();
        }

    }
}
