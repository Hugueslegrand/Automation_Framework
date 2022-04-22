using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.TestRail.Model
{
    public class TestRailConfiguration
    {
        public string testrailurl { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool ignoreAddResults { get; set; }
    }
}
