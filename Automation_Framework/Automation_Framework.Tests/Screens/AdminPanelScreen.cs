using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;

namespace Automation_Framework.Tests.Screens
{
    public class AdminPanelScreen : BasePage
    {
        public AdminPanelScreen(DriverBuilder driver) : base(driver) { }

        //Android elements
        public IAndroidElement AndroidBrightestLogo => new MobileElement(AndroidDriver, "logo", MobileSelector.AccessibilityID);
        public IAndroidElement AndroidLogoutButton => new MobileElement(AndroidDriver, "logoutIcon", MobileSelector.AccessibilityID);
        public IAndroidElement AndroidHomeButton => new MobileElement(AndroidDriver, "homeIcon", MobileSelector.AccessibilityID);

        public IAndroidElement AndroidBugsButton => new MobileElement(AndroidDriver, "BUGS, tab, 1 of 3", MobileSelector.AccessibilityID);
        public IAndroidElement AndroidUsersButton => new MobileElement(AndroidDriver, "USERS, tab, 2 of 3", MobileSelector.AccessibilityID);
        public IAndroidElement AndroidLogsButton => new MobileElement(AndroidDriver, "LOGS, tab, 3 of 3", MobileSelector.AccessibilityID);



    }
}
