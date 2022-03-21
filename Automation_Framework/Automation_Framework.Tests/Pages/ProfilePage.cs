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
    public class ProfilePage : BasePage
    {
        public ProfilePage(IWebDriver driver) : base(driver)
        {
        }

        public Button AddCreditsButton => new Button(Driver, By.XPath("//button[normalize-space()='add credits']"));
        public Button BuyCreditsButton => new Button(Driver, By.XPath("//button[normalize-space()='buy']"));
        public Button CancelPaymentButton => new Button(Driver, By.XPath("//a[normalize-space()='Cancel payment']"));
        public InputField AmountOfCredits => new InputField(Driver, By.XPath("//input[@placeholder='5']"));






        //Functions


        public void ClickAddCredits() => AddCreditsButton.ClickOnElement();
        public void ClickBuyCredits() => BuyCreditsButton.ClickOnElement();
        public void ClickCancelPayment() => CancelPaymentButton.ClickOnElement();
        public void ClickAmountOfCredits() => AmountOfCredits.ClickOnElement();
        public void FillAmountOfCredits(string amountOfCredits) => AmountOfCredits.SendKeys(amountOfCredits);

        public void ScreenShot() => ScreenshotTaker.TakeStandardScreenshot(Driver, "ProfileScreenshot");


    }
}
