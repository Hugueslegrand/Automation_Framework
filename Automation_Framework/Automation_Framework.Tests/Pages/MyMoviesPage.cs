﻿using Automation_Framework.Base;
using Automation_Framework.Extensions.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Pages
{
    public class MyMoviesPage : BasePage
    {
        public MyMoviesPage(IWebDriver driver) : base(driver)
        {
        }


        public Button WatchNowButton => new Button(Driver, By.XPath("//button[normalize-space()='Watch now']"));
        public Button CloseModalButton => new Button(Driver, By.XPath("//div[@class='css-ce9ngx']//button[@id='CloseModal']"));
        public Button HierLink => new Button(Driver, By.XPath("//a[normalize-space()='hier']"));




        //Functions

        public void ClickWatchNow() => WatchNowButton.ClickOnElement();
        public void ClickCloseModal() => CloseModalButton.ClickOnElement();
        public void ClickHierLink() => HierLink.ClickOnElement();
        public void ScreenShot() => ScreenshotTaker.TakeStandardScreenshot(Driver, "MyMoviesScreenshot");

    }
}
