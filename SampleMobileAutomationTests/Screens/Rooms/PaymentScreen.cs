using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;
using SampleMobileAutomationTests.CommonElements;

namespace SampleMobileAutomationTests.Pages
{
    public class PaymentScreen
    {
        public CustomWebElement YourCardSection => new(By.Id(PaymentSelectors.YourCardSection));
        public CustomWebElement AddNewCardSection => new(By.Id(PaymentSelectors.AddNewCardSection));
        public CustomWebElement CardNumberFiled => new(By.Id(PaymentSelectors.CardNumberFiled));
        public CustomWebElement NameOnCardField => new(By.Id(PaymentSelectors.NameOnCardField));
        public CustomWebElement BillingAddressField => new(By.Id(PaymentSelectors.BillingAddressFiled));
        public CustomWebElement CityField => new(By.Id(PaymentSelectors.CityField));
        public CustomWebElement StateProvinceField => new(By.Id(PaymentSelectors.StateProvinceField));
        public CustomWebElement PostalZipCodeField => new(By.Id(PaymentSelectors.PostalZipCodeField));
        public DropDown ExpirationMonthDropDown => new(By.Id(PaymentSelectors.ExpirationMonthDropDown));
        public DropDown ExpirationYearDropDown => new(By.Id(PaymentSelectors.ExpirationYearDropDown));
        public CustomWebElement SaveCardCheckBox => new(By.Id(PaymentSelectors.SaveCardCheckBox));
        public CustomWebElement CompleteReservationButton => new(By.Id(PaymentSelectors.CompleteReservationButton));
        public CustomWebElement DataPrivacyAndSecurityPolicy => new(By.Id(PaymentSelectors.DataPrivacyAndSecurityPolicy));
    }
}