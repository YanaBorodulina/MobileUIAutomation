using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public class SummarySelectors
    {
        public static string CheckInOutDate => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_check_in_out_date";
        public static string NumberOfGuests => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_no_of_guests";
        public static string ConfirmButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_confirm";
        public static string DataPrivacyLink => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/summary_txt_terms";
    }
}