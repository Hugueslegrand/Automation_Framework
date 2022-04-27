using Automation_Framework.TestRail.Service.Base.Entities;
using System.Collections.Generic;


namespace Automation_Framework.TestRail.Service.Base.Abstract
{
    public interface ITestRailApi
    {
        int CreateRun(Run run);
        void AddResultsForCases(int runId, List<Result> results);
    }
}
