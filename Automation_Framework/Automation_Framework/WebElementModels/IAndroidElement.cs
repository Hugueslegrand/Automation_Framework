using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        void AndroidSendKeys(string text);
        void AndroidSwipe(int horizontal, int vertical);
        void Swipe(int startX, int startY, int endX, int endY, int duration);
    }
}
