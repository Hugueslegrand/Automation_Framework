using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.TestRail.Service.Base.Entities
{
    public class Suite
    {
        public string description { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int project_id { get; set; }
        public string url { get; set; }
    }
}
