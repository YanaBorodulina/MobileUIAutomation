using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.CommonElements
{
    public class UserGuid
    {
        public CustomWebElement FirstLoginInfo => new(By.Id(UserGuidSelectors.FirstLoginInfo));
        public CustomWebElement SearchRoomsScreenInfo => new(By.Id(UserGuidSelectors.SearchRoomsScreenInfo));
        public CustomWebElement SelectRoomsScreenInfo => new(By.Id(UserGuidSelectors.SelectRoomsScreenInfo));
        public CustomWebElement SearchPackageScreenInfo => new(By.Id(UserGuidSelectors.SearchPackageScreenInfo));
        public CustomWebElement RoomsScreenInfo => new(By.Id(UserGuidSelectors.RoomsScreenInfo));
        public CustomWebElement AdditionalServicesScreenInfo => new(By.Id(UserGuidSelectors.AdditionalServicesScreenInfo));
        public CustomWebElement PaymentMethodsScreenInfo => new(By.Id(UserGuidSelectors.PaymentMethodsScreenInfo));
        public CustomWebElement SkipStep => new(By.XPath(UserGuidSelectors.SkipStep));
    }
}