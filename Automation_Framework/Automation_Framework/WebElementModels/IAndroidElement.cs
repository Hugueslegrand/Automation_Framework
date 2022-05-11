

using System.Drawing;

namespace Automation_Framework.WebElementModels
{
    public interface IAndroidElement
    {
        string AndroidTagName { get; }
        string AndroidText { get; }
        bool AndroidEnabled { get; }
        bool AndroidSelected { get; }
        bool AndroidDisplayed { get; }
        Size AndroidSize { get; }
        Point AndroidLocation { get; }

        void AndroidClick();
        void AndroidClear();
        void AndroidSendKeys(string text);

        void Swipe(int startX, int startY, int endX, int endY, int duration);
    }
}
