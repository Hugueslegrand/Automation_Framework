﻿using Automation_Framework.Tests.Pages;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;

namespace Automation_Framework.Tests.Screens
{
    public class LoginScreen : BasePage
    {
        public LoginScreen(DriverBuilder driver) : base(driver) { }

        //Android elements

        public IAndroidElement BackButton => new MobileElement(AndroidDriver, "//android.widget.Button[@content-desc=\"goBack\"]/android.widget.TextView", MobileSelector.Xpath);

        //public IAndroidElement AndroidSignInEmail => new MobileElement(AndroidDriver, "//android.widget.EditText[@content-desc=\"emailTxt\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidSignInEmail => new MobileElement(AndroidDriver, "emailTxt", MobileSelector.AccessibilityID);
        public IAndroidElement AndroidSignInPassword => new MobileElement(AndroidDriver, "//android.widget.EditText[@content-desc=\"passwordTxt\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidSignInButtonComplete => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"submitBtn\"]", MobileSelector.Xpath);
        public IAndroidElement GoToRegisterScreen => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"not registered yet button\"]/android.widget.TextView", MobileSelector.Xpath);

        //Android functions

        public IAndroidElement LoginWarning => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"mainContent\"]/android.view.ViewGroup/android.widget.TextView[3]", MobileSelector.Xpath);

        public string GetInnerText_Warning()
        {
            return LoginWarning.Text;
        }

        public void ClickBackButton() => BackButton.AndroidClick();
        public void ClickEmail() => AndroidSignInEmail.AndroidClick();
        public void ClickPassword() => AndroidSignInPassword.AndroidClick();
        public void ClickLoginButton() => AndroidSignInButtonComplete.AndroidClick();
        public void ClickGoToRegisterScreen() => GoToRegisterScreen.AndroidClick();

        public void AndroidLogin(string userName, string password)
        {
             AndroidSignInEmail.AndroidSendKeys(userName);
            AndroidSignInPassword.AndroidSendKeys(password);
            AndroidSignInButtonComplete.AndroidClick();

        }
    }
}
