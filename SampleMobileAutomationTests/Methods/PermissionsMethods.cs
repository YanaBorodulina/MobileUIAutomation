using SampleMobileAutomationTests.Pages;

namespace SampleMobileAutomationTests.Methods
{
    public class PermissionsMethods
    {
        private readonly PermissionScreen _permissionScreen;

        public PermissionsMethods()
        {
            _permissionScreen = new PermissionScreen();
        }

        //TODO rewrite for different types of permissions
        public void SetUpLocationPermissions(string permissionType)
        {
            _permissionScreen.WhileUsingTheApp.Element.Click();
        }
    }
}