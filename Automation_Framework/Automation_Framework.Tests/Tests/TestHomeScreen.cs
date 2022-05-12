using Automation_Framework.Tests.Models;
using Automation_Framework.Tests.Pages;
using FluentAssertions;
using NUnit.Framework;


namespace Automation_Framework.Tests.Tests
{
    public class TestHomeScreen : BaseTest
    {
        User userAdminExist = new User("Stage", "Admin", "stageadmin@stageadmin.stageadmin", "StageAdmin0221!");

        [Test, Property("caseid", "7292")]
        [Description("Verify the homepage contains 4 selections by genre of differen movies")]
        public void Test_AvailableGenres_HomePage()
        {
            

        }

        

    }
}