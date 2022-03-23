using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Models
{
    public class User
    {

       // public IButton GetUserFirstName(string firstName, IWebDriver Driver)
       // {
       //     IButton FirstName = new WebElement(Driver, $"//p[normalize-space()={this.firstName}]", Selector.Xpath);
       //     return FirstName;
       // }

        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string? rePassword { get; set; }
        public string? credits { get; set; }
    }
}
