﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.WebElementModels
{
    public interface IIOSElement
    {
        void IOSClick();
        void IOSSendKeys(string text);
    }
}