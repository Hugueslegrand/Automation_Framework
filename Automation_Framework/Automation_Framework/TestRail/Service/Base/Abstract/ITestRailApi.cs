using Automation_Framework.TestRail.Service.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.TestRail.Service.Base.Abstract
{
    public interface ITestRailApi
    {
        int CreateRun(Run run);
        void AddResultsForCases(int runId, List<Result> results);
    }
}
