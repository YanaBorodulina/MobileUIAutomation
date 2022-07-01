using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.CommonElements
{
    public class InlineMessageSelectors
    {
        public static string InlineMessage => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txtErrorText";
    }
}