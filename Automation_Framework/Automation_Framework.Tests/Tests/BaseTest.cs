using Automation_Framework.Builders;
using Automation_Framework.Enums;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Automation_Framework.Tests.Tests
{
    [TestFixture]
    //[AllureNUnit]
    public class BaseTest
    {
        public DriverBuilder builder = new DriverBuilder();
    
        [SetUp]
        public void Setup()
        {
           //builder.BuildDriver(PlatformType.Desktop);
           builder.BuildDriver(PlatformType.Android);
        }

        [TearDown]
        public void TearDown()
        {
            //builder.CloseDriver(PlatformType.Desktop);
            builder.CloseDriver(PlatformType.Android);
        }
    }
}
