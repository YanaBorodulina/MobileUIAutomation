using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.CommonElements
{
    public class BottomMenuSelectors
    {
        public static string RoomButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/roomsBtn";
 
    }
}