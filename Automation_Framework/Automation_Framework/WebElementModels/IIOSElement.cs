
using System.Drawing;

namespace Automation_Framework.WebElementModels
{
    public interface IIOSElement
    {
        string IOSTagName { get; }
        string IOSText { get; }
        bool IOSEnabled { get; }
        bool IOSSelected { get; }
        bool IOSDisplayed { get; }
        Size IOSSize { get; }
        Point IOSLocation { get; }

        void IOSClear();
        void IOSClick();
        void IOSSendKeys(string text);
    }
}
