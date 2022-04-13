using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.WebElementModels
{
    public interface IInputField
    {
        string TagName { get; }
        string Text { get; }
        bool Enabled { get; }
        bool Selected { get; }
        bool Displayed { get; }


        void GetCssValue(string propertyName);
        void GetAttribute(string attributeName);
        void GetProperty(string propertyName);
        void SendKeys(string text);
        void ClickOnElement();
        void ClearInput();

        IWebElement getElement();
        IList<IWebElement> getElements();



        void Clear();

    }
    
}
