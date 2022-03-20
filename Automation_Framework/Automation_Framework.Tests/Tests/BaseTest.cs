using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class BaseTest
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
            builder.CloseDriver(PlatformType.Desktop);
        }
    }
}
