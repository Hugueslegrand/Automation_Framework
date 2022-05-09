﻿using Automation_Framework.Tests.Pages;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;

namespace Automation_Framework.Tests.Screens
{
    public class ProfileScreen : BasePage
    {
        public ProfileScreen(DriverBuilder driver) : base(driver) { }

        //Android elements
        public IAndroidElement AndroidYellowModalContainer => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"yellow box\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidLabelTitle => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"yellow box\"]/android.widget.TextView[1]", MobileSelector.Xpath);
        public IAndroidElement AndroidAvatar => new MobileElement(AndroidDriver, "//android.widget.ImageView[@content-desc=\"avatar\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidLabelFirstName => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"yellow box\"]/android.widget.TextView[2]", MobileSelector.Xpath);
        public IAndroidElement AndroidLabelLastName => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"yellow box\"]/android.widget.TextView[4]", MobileSelector.Xpath);
        public IAndroidElement AndroidLabelEmail => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"yellow box\"]/android.widget.TextView[6]", MobileSelector.Xpath);
        public IAndroidElement AndroidLabelCredits => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"yellow box\"]/android.widget.TextView[8]", MobileSelector.Xpath);
        public IAndroidElement AndroidFirstName => new MobileElement(AndroidDriver, "//android.widget.TextView[@content-desc=\"firstname\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidLastName => new MobileElement(AndroidDriver, "//android.widget.TextView[@content-desc=\"lastname\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidEmail => new MobileElement(AndroidDriver, "//android.widget.TextView[@content-desc=\"email\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidCredits => new MobileElement(AndroidDriver, "//android.widget.TextView[@content-desc=\"credits\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidAddCreditsButton => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"add credits button\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidCancelPaymentButton => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"close credits box\"]/android.widget.TextView", MobileSelector.Xpath);
        public IAndroidElement AndroidAmountOfCredits => new MobileElement(AndroidDriver, "//android.widget.EditText[@content-desc=\"credits amount\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidBuyCreditsButton => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"submitBtn\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidProfileFullScreen => new MobileElement(AndroidDriver, "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout", MobileSelector.Xpath);




        public string GetInnerText_AndroidProfileFullScreen()
        {
            return AndroidProfileFullScreen.Text;
        }

        public string GetInnerText_AndroidLabelTitle()
        {
            return AndroidLabelTitle.Text;
        }
        public string GetInnerText_AndroidLabelFirstName()
        {
            return AndroidLabelFirstName.Text;
        }
        public string GetInnerText_AndroidLabelLastName()
        {
            return AndroidLabelLastName.Text;
        }
        public string GetInnerText_AndroidLabelEmail()
        {
            return AndroidLabelEmail.Text;
        }
        public string GetInnerText_AndroidLabelCredits()
        {
            return AndroidLabelCredits.Text;
        }
        public string GetInnerText_AndroidFirstName()
        {
            return AndroidFirstName.Text;
        }
        public string GetInnerText_AndroidLastName()
        {
            return AndroidLastName.Text;
        }
        public string GetInnerText_AndroidEmail()
        {
            return AndroidEmail.Text;
        }
        public string GetInnerText_AndroidCredits()
        {
            return AndroidCredits.Text;
        }





        //Android Functions
        public void ClickAddCreditsButton() => AndroidAddCreditsButton.AndroidClick();

        public void ClickCancelPaymentButton() => AndroidCancelPaymentButton.AndroidClick();
        public void AndroidFillAmountOfCredits(string amountOfCredits) => AndroidAmountOfCredits.AndroidSendKeys(amountOfCredits);
        public void ClickBuyCreditsButton() => AndroidBuyCreditsButton.AndroidClick();


    }
}
