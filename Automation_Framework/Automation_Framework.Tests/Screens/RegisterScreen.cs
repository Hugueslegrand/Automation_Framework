using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;

namespace Automation_Framework.Tests.Screens
{
    public class RegisterScreen : BasePage
    {
        public RegisterScreen(DriverBuilder driver) : base(driver) { }

        //Android elements
        public IAndroidElement BackButton => new MobileElement(AndroidDriver, "//android.widget.Button[@content-desc=\"goBack\"]/android.widget.TextView", MobileSelector.Xpath);
        public IAndroidElement AndroidRegisterFirstName => new MobileElement(AndroidDriver, "//android.widget.EditText[@content-desc=\"firstnameTxt\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidRegisterLastName => new MobileElement(AndroidDriver, "//android.widget.EditText[@content-desc=\"lastnameTxt\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidRegisterEmail => new MobileElement(AndroidDriver, "//android.widget.EditText[@content-desc=\"emailTxt\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidRegisterPassword => new MobileElement(AndroidDriver, "//android.widget.EditText[@content-desc=\"passwordTxt\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidRegisterRePassword => new MobileElement(AndroidDriver, "//android.widget.EditText[@content-desc=\"re_passwordTxt\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidRegisterButtonComplete => new MobileElement(AndroidDriver, "//android.view.ViewGroup[@content-desc=\"submitBtn\"]", MobileSelector.Xpath);
        public IAndroidElement AndroidGoToSignInScreen => new MobileElement(AndroidDriver, "//android.widget.TextView[@text = Sign in]", MobileSelector.Xpath);


        //Android Functions

        public void ClickBackButton() => BackButton.AndroidClick();
        public void ClickFirstName() => AndroidRegisterFirstName.AndroidClick();
        public void ClickLastName() => AndroidRegisterLastName.AndroidClick();
        public void ClickEmail() => AndroidRegisterEmail.AndroidClick();
        public void ClickPassword() => AndroidRegisterPassword.AndroidClick();
        public void ClickRePassword() => AndroidRegisterRePassword.AndroidClick();
        public void ClickLoginButton() => AndroidRegisterButtonComplete.AndroidClick();
        public void ClickGoToSignInScreen() => AndroidGoToSignInScreen.AndroidClick();

        public void AndroidRegister(string firstName, string lastName, string email, string passwoord, string rePasswoord)
        {
            AndroidRegisterFirstName.AndroidSendKeys(firstName);
            AndroidRegisterLastName.AndroidSendKeys(lastName);
            AndroidRegisterEmail.AndroidSendKeys(email);
            AndroidRegisterPassword.AndroidSendKeys(passwoord);
            AndroidRegisterRePassword.AndroidSendKeys(rePasswoord);
            AndroidRegisterButtonComplete.AndroidClick(); // Or ClickRegister();

        }
    }
}
