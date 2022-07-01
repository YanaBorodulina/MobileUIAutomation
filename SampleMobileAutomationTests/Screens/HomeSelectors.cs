using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public class HomeSelectors
    {
        public static string PlayNowButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_know_more_label";
    }
}