using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public class YourDetailsSelectors
    {
        public static string TitleDropDown => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/spinner_title";
        public static string FirstNameField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_first_name";
        public static string LastNameField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_last_name";
        public static string PhoneNumberField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_phone_number";
        public static string EmailField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_email";
        public static string CountryOfResidenceDropDown => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/spinner_country";
        public static string ProceedButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_proceed";
        public static string TermAndConditionLink => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/your_details_txt_terms";
        public static string ErrorMessage => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_error";
    }
}