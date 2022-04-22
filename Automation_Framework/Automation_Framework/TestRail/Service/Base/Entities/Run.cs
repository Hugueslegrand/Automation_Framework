using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.TestRail.Service.Base.Entities
{
    public class Run
    {
        public int project_id { get; set; }
        public int suite_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int assignedto_id { get; set; }
        public bool include_all { get; set; }
        public List<int> case_ids { get; set; }
    }
}
