using Automation_Framework.Base;
using Automation_Framework.Enums;
using Automation_Framework.Builders;
using Automation_Framework.WebElementModels;
using Automation_Framework.Extensions.WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Pages
{
    public class ProfilePage : BasePage
    {
        public ProfilePage(DriverBuilder driver) : base(driver) { }

        public IButton AddCreditsButton => new WebElement(Driver, "//button[normalize-space()='add credits']",Selector.Xpath);
        public IButton BuyCreditsButton => new WebElement(Driver, "//button[normalize-space()='buy']",Selector.Xpath);
        public IButton CancelPaymentButton => new WebElement(Driver, "//a[normalize-space()='Cancel payment']", Selector.Xpath);
        public IInputField AmountOfCredits => new WebElement(Driver, "//input[@placeholder='5']", Selector.Xpath);




        //Functions


        public void ClickAddCredits() => AddCreditsButton.ClickOnElement();
        public void ClickBuyCredits() => BuyCreditsButton.ClickOnElement();
        public void ClickCancelPayment() => CancelPaymentButton.ClickOnElement();
        public void ClickAmountOfCredits() => AmountOfCredits.ClickOnElement();
        public void FillAmountOfCredits(string amountOfCredits) => AmountOfCredits.SendKeys(amountOfCredits);


    }
}
