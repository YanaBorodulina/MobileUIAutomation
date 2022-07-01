using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public static class LoginSelectors
    {
        public static string UserNumberFiled => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_login_member_id";
        public static string PinField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_login_member_pin";
        public static string LoginButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_login_login";
        public static string ForgotAccountNumber => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_forgot_account_number";
        public static string ForgotPin => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_forgot_pin";
    }
}