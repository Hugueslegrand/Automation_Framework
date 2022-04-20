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
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string? rePassword { get; set; }

        public User(string firstName, string lastName, string email, string password, string rePassword)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.rePassword = rePassword;
            
        }

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public User(string firstName, string lastName, string email, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;

        }

    }
    
    
}
