using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public class BookingConfirmationSelectors
    {
        public static string ImageOk => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/img_ok";
        public static string UserMessage => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_user_msg";
        public static string YesButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_yes";
    }
}