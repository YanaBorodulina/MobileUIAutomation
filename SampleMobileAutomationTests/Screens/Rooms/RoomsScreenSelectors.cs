using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public class RoomsScreenSelectors
    {
        public static string CheckInFiled => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_rooms_start_date";
        public static string CheckOutFiled => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_rooms_end_date";
        public static string RoomsFiled => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_rooms_count";
        public static string AdultsFiled => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_rooms_adult_count";
        public static string ChildrenFiled => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_rooms_child_count";
        public static string SelectRatePreferenceFiled => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/spinner_rate_preferences";
        public static string EnterCodeFiled => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edit_promo_code";
        public static string SearchRoomsButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_search_rooms";
        public static string SearchPackagesButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_search_pkg";
        public static string ViewMyBookingHistoryButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_view_booking_history";
        public static string MonthName => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/month_name";
        public static string NextMonth => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/next";
        public static string NumberOfSelectedRooms => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_room_badge";

    }
}