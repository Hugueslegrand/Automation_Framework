using Automation_Framework.Builders;
using Automation_Framework.Base;
using Automation_Framework.Enums;
using Automation_Framework.Models;
using Automation_Framework.Utilities;
using Automation_Framework.TestRail.Service;
using Automation_Framework.Tests.Pages;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Automation_Framework.Tests.Tests.MobileTests
{
    public class MobileBaseTest : TestRailBaseTest
    {

        public DriverBuilder builder = new DriverBuilder();


        [SetUp]
        public void Setup()
        {
            builder.BuildDriver(PlatformType.Android);
            Log.StartTestCase((string)TestContext.CurrentContext.Test.Properties.Get("Description"));
            // initPages();
        }

        [TearDown]
        public void TearDown()
        {

            builder.BuildDriver(PlatformType.Android);
            Log.EndTestCase(TestContext.CurrentContext.Result.Message);
        }
    }
}
