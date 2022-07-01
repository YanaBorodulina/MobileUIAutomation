using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.Pages
{
    public class Dialog
    {
        public CustomWebElement DialogButtonAdd => new(By.Id(DialogSelectors.DialogButtonAdd));
        public CustomWebElement DialogNumberOfSelectedItems => new(By.Id(DialogSelectors.DialogNumberOfSelectedItems));
        public CustomWebElement DialogButtonOk => new(By.Id(DialogSelectors.DialogButtonOk));
        public CustomWebElement DialogButtonCancel => new(By.Id(DialogSelectors.DialogButtonCancel));
        public CustomWebElement ErrorMessage => new(By.Id(DialogSelectors.ErrorMessage));
        public CustomWebElement DialogMessage => new(By.Id(DialogSelectors.DialogMessage));
    }
}