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
        public IAndroidElement Modal => new MobileElement(AndroidDriver, "/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup", MobileSelector.Xpath);
        public IAndroidElement ErrorMessage => new MobileElement(AndroidDriver, "/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.widget.TextView[4]", MobileSelector.Xpath);



        public string GetInnerText_ErrorMessage()
        {
            return ErrorMessage.Text;
        }

        //Android Functions

        public void ClickBackButton() => BackButton.AndroidClick();
        public void ClickFirstName() => AndroidRegisterFirstName.AndroidClick();
        public void ClickLastName() => AndroidRegisterLastName.AndroidClick();
        public void ClickEmail() => AndroidRegisterEmail.AndroidClick();
        public void ClickPassword() => AndroidRegisterPassword.AndroidClick();
        public void ClickRePassword() => AndroidRegisterRePassword.AndroidClick();
        public void ClickLoginButton() => AndroidRegisterButtonComplete.AndroidClick();
        public void ClickGoToSignInScreen() => AndroidGoToSignInScreen.AndroidClick();
        //public void SwipeModal(int horizontal, int vertical) => Modal.AndroidSwipe(horizontal, vertical);
        public void Swipe(int startX, int startY, int endX, int endY, int duration) => AndroidRegisterLastName.Swipe( startX,  startY,  endX,  endY,  duration);

        public void AndroidRegister(string firstName, string lastName, string email, string passwoord, string rePasswoord)
        {
            AndroidRegisterFirstName.AndroidSendKeys(firstName);
            Swipe(685, 1400, 685, 800, 500 );
            AndroidRegisterLastName.AndroidSendKeys(lastName);
            //SwipeModal(0, 10);
            AndroidRegisterEmail.AndroidSendKeys(email);
            AndroidRegisterPassword.AndroidSendKeys(passwoord);
            //Swipe(5, 10, 5, -5, 2000);
            AndroidRegisterRePassword.AndroidSendKeys(rePasswoord);
            AndroidRegisterButtonComplete.AndroidClick(); // Or ClickRegister();

        }
    }
}
