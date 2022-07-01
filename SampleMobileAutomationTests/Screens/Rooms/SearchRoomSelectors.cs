using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public class SearchRoomSelectors
    {
        public static string BookButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_book_room";
        public static string BookNowButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_book_now";
        public static string SelectRoomButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_book_room";

    }
}