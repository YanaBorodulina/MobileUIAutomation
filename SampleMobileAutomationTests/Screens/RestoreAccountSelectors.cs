using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public class RestoreAccountSelectors
    {
        public static string LastNameField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_last_name";
        public static string FirstNameField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_first_name";
        public static string DateOfBirthField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_date_of_birth";
        public static string MobileNumberField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_mobile_number";
        public static string ResetPinButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_submit_pin_reset";
        public static string RetrievalAccountButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_submit_account_retrieval";
        public static string AccountNumberField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_account_number";
    }
}