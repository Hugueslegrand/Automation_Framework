

namespace Automation_Framework.WebElementModels
{
    public interface IAndroidElement
    {
        string TagName { get; }
        string Text { get; }
        bool Enabled { get; }
        bool Selected { get; }
        bool Displayed { get; }


        void AndroidClick();
        void AndroidClear();
        void AndroidSendKeys(string text);

        void Swipe(int startX, int startY, int endX, int endY, int duration);
    }
}
