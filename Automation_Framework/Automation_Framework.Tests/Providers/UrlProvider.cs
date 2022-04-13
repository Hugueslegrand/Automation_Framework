using Automation_Framework.Helpers;
using System;

namespace Automation_Framework.Tests.Providers
{
    //OBSOLETE CLASS
    public class UrlProvider
    {
        private static Uri BaseUrl => new Uri(Configuration.Environment.ApplicationUrl);
        public static Uri Login => new Uri(BaseUrl, "login");
    }
}
