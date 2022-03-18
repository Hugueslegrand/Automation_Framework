
using Automation_Framework.Base;
using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Tests
{
    public class TestRegister : BaseTest
    {
        [Test]
        [Description("Register an user")]
        public void Test_RegisterAnUser_POM()
        {
            Navigation navigation = new Navigation(builder);
            navigation.surfToUrl();
            Thread.Sleep(6000);
            navigation.ClickRegister();

            RegistrationPage registrationPage = new RegistrationPage(builder);

            registrationPage.Register("firstName", "lastName", "email@brightest.be", "passwoord", "passwoord");

        }
    }


}
