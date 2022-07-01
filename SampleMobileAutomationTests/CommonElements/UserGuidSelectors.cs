using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.CommonElements
{
    public class UserGuidSelectors
    {
        public static string FirstLoginInfo => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/img_bottom_nav_cm";
        public static string RoomsScreenInfo => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_c_m_booking_history";
        public static string SearchRoomsScreenInfo => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/img_left_hand_current_booking";
        public static string SelectRoomsScreenInfo => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_tap_book_to_proceed";
        public static string SearchPackageScreenInfo => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_tap_book_to_proceed";
        public static string AdditionalServicesScreenInfo => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_c_m_other_service";
        public static string PaymentMethodsScreenInfo => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/ll_see_saved_cards";
        public static string SkipStep => TestConfig.PlatformName == "IOS" ? "" : "//android.widget.TextView[contains(text(),'Tap to skip this step')]";
    }
}