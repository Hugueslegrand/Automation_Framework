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
    }
}
