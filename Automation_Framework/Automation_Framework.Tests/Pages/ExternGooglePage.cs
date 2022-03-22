using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.Extensions.WebDriver;

using Automation_Framework.WebElementModels;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Pages
{
    public class ExternGooglePage : BasePage
    {
        public ExternGooglePage(DriverBuilder driver) : base(driver)
        {

        }

        String target_xpath = "//*[@id=\"rso\"]/div[1]/div/div[1]/div/a/h3";

        public IButton IkGaAkoordBtn => new WebElement(Driver, "L2AGLb", Selector.Id);
        public IInputField GoogleSearchbar => new WebElement(Driver, "q",Selector.Name);
        public IButton RandomLink => new WebElement(Driver, target_xpath, Selector.Xpath);


        public void ClickIkGaAkoordBtn() => IkGaAkoordBtn.ClickOnElement();
        public void FillGoogleSearchbar(string text) 
        {
            GoogleSearchbar.SendKeys(text + Keys.Enter);
        }
        public void ClickRandomLink() => RandomLink.ClickOnElement();

     

    }
}
