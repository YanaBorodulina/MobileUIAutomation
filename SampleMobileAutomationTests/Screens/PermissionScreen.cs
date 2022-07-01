using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.Pages
{
    public class PermissionScreen
    {
        public  CustomWebElement WhileUsingTheApp => new CustomWebElement(By.XPath(PermissionsSelectors.WhileUsingTheApp));
    }
}