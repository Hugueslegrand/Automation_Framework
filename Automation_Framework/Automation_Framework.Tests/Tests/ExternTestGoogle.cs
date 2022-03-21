﻿using Automation_Framework.Base;
using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Tests
{
    public class ExternTestGoogle : BaseTest
    {
        [Test]
        [Description("Test: GoogleSearch")]
        public void Test_GoogleSearch()
        {

            ExternGooglePage externGooglePage = new ExternGooglePage(builder);
            //externGooglePage.surfToUrl();
            externGooglePage.ClickIkGaAkoordBtn();
            externGooglePage.FillGoogleSearchbar("LambdaTest");
            externGooglePage.ClickRandomLink();

            Thread.Sleep(6000);


        }
    }
}
