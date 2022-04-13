﻿using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;

namespace Automation_Framework.Tests.Screens
{
    public class HomeScreen : BasePage
    {
        public HomeScreen(DriverBuilder driver) : base(driver) { }

        //Android element
        public IAndroidElement Logo => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"logo\"]/android.widget.ImageView", MobileSelector.Xpath);
        public IAndroidElement SignInButton => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"loginIcon\"]/android.widget.TextView", MobileSelector.Xpath);
        public IAndroidElement SignOutButton => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"logoutIcon\"]/android.widget.TextView", MobileSelector.Xpath);
        public IAndroidElement SettingsButton => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"settingsIcon\"]/android.widget.TextView", MobileSelector.Xpath);


        public IAndroidElement MovieTitle => new MobileElement(AndroidDriver, "(//android.view.ViewGroup[@content-desc=\"moviesRow\"])[1]/android.widget.TextView", MobileSelector.Xpath);
        public IAndroidElement MovieBanner => new MobileElement(AndroidDriver, "(//android.view.ViewGroup[@content-desc=\"moviePoster\"])[1]/android.widget.ImageView", MobileSelector.Xpath);


        //Android functions
        public void ClickLogo() => Logo.AndroidClick();
        public void ClickSignInButton() => SignInButton.AndroidClick();
        public void ClickSignOutButton() => SignOutButton.AndroidClick();
        public void ClickSettingsButton() => SettingsButton.AndroidClick();
    }
}
