using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.WebElementModels
{
   public interface ILink
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
        void ClickOnElement();
        void OpenLinkInNewTab();


        IWebElement getElement();
        IList<IWebElement> getElements();
    }
}
