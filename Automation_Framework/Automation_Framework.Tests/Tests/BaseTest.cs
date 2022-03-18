using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Tests
{
    public class BaseTest
    {
        public DriverBuilder builder = new DriverBuilder();
    
        [SetUp]
        public void Setup()
        {
           builder.BuildDesktopDriver();
        }

        [TearDown]
        public void TearDown()
        {
            builder.CloseDriver();
        }
    }
}
