using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.CommonElements
{
    public class AlertSelectors
    {
        public static string DialogOkButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_dialog_ok";
    }
}