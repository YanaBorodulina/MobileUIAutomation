using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.Pages
{
    public class SearchPackageScreen
    {
        public CustomWebElement OtherPackageButton => new(By.Id(SearchPackageSelectors.OtherPackageButton));
        public CustomWebElement FeaturesButton => new(By.Id(SearchPackageSelectors.FeaturesButton));
        public CustomWebElement RateDetailsButton => new(By.Id(SearchPackageSelectors.RateDetailsButton));
        public CustomWebElement Title => new(By.Id(SearchPackageSelectors.Title));
    }
}