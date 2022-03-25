using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.WebElementModels
{
    public interface IInputField
    {
        void SendKeys(string text);
        void ClickOnElement();

        public string GetAttribute(string attribute);
    }
}
