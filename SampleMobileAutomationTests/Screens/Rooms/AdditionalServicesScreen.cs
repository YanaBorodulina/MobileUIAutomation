using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.Pages
{
    public class AdditionalServicesScreen
    {
        public CustomWebElement  AdditionalServicesHeader => new(By.Id(AdditionalServicesSelectors.AdditionalServicesHeader));
        public CustomWebElement  AddButton => new(By.Id(AdditionalServicesSelectors.AddButton));
        public CustomWebElement  SkipButton => new(By.Id(AdditionalServicesSelectors.SkipButton));

    }
}