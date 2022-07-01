using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public class TermAndConditionsSelectors
    {
        public static string XButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/img_dialog_read_more_close";
    }
}