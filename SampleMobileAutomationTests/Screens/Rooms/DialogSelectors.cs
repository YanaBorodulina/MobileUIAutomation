using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public class DialogSelectors
    {
        public static string DialogButtonAdd => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_dialog_plus_button";
        public static string DialogNumberOfSelectedItems => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_dialog_number";
        public static string DialogButtonOk => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_dialog_ok";
        public static string DialogButtonCancel => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_dialog_cancel";
        public static string ErrorMessage => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_error";
        public static string DialogMessage => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_solaire_dialog_message";
    }
}