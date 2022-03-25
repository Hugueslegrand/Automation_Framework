using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.WebElementModels
{
    public interface IButton
    {
      
        void ClickOnElement();

        public string GetInnerHTML();

        public string GetAttribute(string attribute);

        public bool ElementIsVisible();

    }
}