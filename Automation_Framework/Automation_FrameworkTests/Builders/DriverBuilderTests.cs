using Microsoft.VisualStudio.TestTools.UnitTesting;
using Automation_Framework.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Moq;

namespace Automation_Framework.Builders.UnitTests
{
    [TestClass()]
    public class DriverBuilderTests
    {
        [TestMethod()]
        public void BuildWebDriverTest()
        {
            DriverBuilder driverBuilder = new DriverBuilder();
            driverBuilder.BuildDriver(Enums.PlatformType.Desktop);
            var runningDriver = driverBuilder._webDriver;
            
            Assert.IsNotNull(runningDriver);
        }
        [TestMethod()]
        public void BuildAndroidDriverTest()
        {
            DriverBuilder driverBuilder = new DriverBuilder();
            driverBuilder.BuildDriver(Enums.PlatformType.Android);
            var runningDriver = driverBuilder._androidDriver;
        
            Assert.IsNotNull(runningDriver);
        }
        [TestMethod()]
        public void CloseWebDriverTest()
        {
            DriverBuilder driverBuilder = new DriverBuilder();
            driverBuilder.BuildDriver(Enums.PlatformType.Desktop);
          
            var runningDriver = driverBuilder._webDriver;


             driverBuilder.CloseDriver(Enums.PlatformType.Desktop);
            
            try
            {
                string title = runningDriver.Title;
                Assert.Fail();
            }
            catch (WebDriverException)
            {

                return;
            }
           
            
        }
        [TestMethod()]
        public void CloseAndroidDriverTest()
        {
            DriverBuilder driverBuilder = new DriverBuilder();
            driverBuilder.BuildDriver(Enums.PlatformType.Android);

            var runningDriver = driverBuilder._androidDriver;


            driverBuilder.CloseDriver(Enums.PlatformType.Android);
            try
            {
                string title = runningDriver.Title;
                Assert.Fail();
            }
            catch (WebDriverException)
            {

                return;
            }
        }
        [TestMethod()]
        public void CloseAllDriverTest()
        {
            DriverBuilder driverBuilder = new DriverBuilder();
            driverBuilder.BuildDriver(Enums.PlatformType.Android);
            driverBuilder.BuildDriver(Enums.PlatformType.Desktop);
            var runningDriver = driverBuilder._webDriver;
            var runningAndroidDriver = driverBuilder._androidDriver;


            driverBuilder.CloseAllDrivers();
            try
            {
                string title = runningDriver.Title;
                string androidTitle = runningAndroidDriver.Title;
                Assert.Fail();
            }
            catch (WebDriverException)
            {

                return;
            }

        }
    }
}