using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public class AdditionalServicesSelectors
    {
        public static string AdditionalServicesHeader => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/title";
        public static string SkipButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_skip_services";
        public static string AddButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_add_services";
    }
}