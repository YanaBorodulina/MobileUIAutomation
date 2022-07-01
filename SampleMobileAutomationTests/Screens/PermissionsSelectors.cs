using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public static class PermissionsSelectors
    {
        public static string WhileUsingTheApp => TestConfig.PlatformName == "IOS" ? "" : "//android.widget.Button[contains(@id, 'permission_allow_foreground_only_button]";
    }
}