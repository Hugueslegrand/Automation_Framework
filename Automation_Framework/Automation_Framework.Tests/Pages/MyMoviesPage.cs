using Automation_Framework.Base;
using Automation_Framework.Extensions.WebDriver;
using OpenQA.Selenium;
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




        //Functions

        public void ClickWatchNow() => WatchNowButton.ClickOnElement();
        public void ClickCloseModal() => CloseModalButton.ClickOnElement();

    }
}
