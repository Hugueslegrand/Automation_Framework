using Automation_Framework.Builders;
using Automation_Framework.TestRail.Service;
using Automation_Framework.Utility;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Base
{
    [TestFixture]
    [AllureNUnit]
    public class BaseTest: TestRailBaseTest
    {

        public DriverBuilder builder = new DriverBuilder();

        [SetUp]
        public void Setup()
        {

            Log.StartTestCase((string)TestContext.CurrentContext.Test.Properties.Get("Description"));
       
        
        }

        [TearDown]
        public void TearDown()
        {
            Log.EndTestCase(TestContext.CurrentContext.Result.Message);
        
        }
    }
}
