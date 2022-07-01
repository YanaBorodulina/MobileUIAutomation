using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public class SearchPackageSelectors
    {
        public static string OtherPackageButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_search_room_other_packages";
        public static string FeaturesButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_search_room_features";
        public static string RateDetailsButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_search_room_rate_details";
        public static string Title => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/title";
    }
}