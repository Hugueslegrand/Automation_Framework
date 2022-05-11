using OpenQA.Selenium;
using System.Collections.Generic;
using System.Drawing;

namespace Automation_Framework.WebElementModels
{
    public interface IInputField
    {
        string TagName { get; }
        string Text { get; }
        bool Enabled { get; }
        bool Selected { get; }
        bool Displayed { get; }
        Size Size { get; }
        Point Location { get; }

        string GetCssValue(string propertyName);
        string GetAttribute(string attributeName);
        string GetProperty(string propertyName);
        void SendKeys(string text);
        void ClickOnElement();
        void ClearInput();

        IWebElement GetElement();
        IList<IWebElement> GetElements();


    }
    
}
