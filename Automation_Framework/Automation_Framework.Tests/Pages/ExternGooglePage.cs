using Automation_Framework.Base;
using Automation_Framework.Extensions.WebDriver;
using Automation_Framework.Tests.Providers;
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
        public ExternGooglePage(IWebDriver driver) : base(driver)
        {

        }

        String target_xpath = "//*[@id=\"rso\"]/div[1]/div/div[1]/div/a/h3";

        public Button IkGaAkoordBtn => new Button(Driver, By.Id("L2AGLb"));
        public InputField GoogleSearchbar => new InputField(Driver, By.Name("q"));
        public Button RandomLink => new Button(Driver, By.XPath(target_xpath));


        public void ClickIkGaAkoordBtn() => IkGaAkoordBtn.ClickOnElement();
        public void FillGoogleSearchbar(string text) 
        {
            GoogleSearchbar.SendKeys(text + Keys.Enter);
        }
        public void ClickRandomLink() => RandomLink.ClickOnElement();

        public void surfToUrl() => Driver.OpenLink(UrlProvider.Default);

    }
}
