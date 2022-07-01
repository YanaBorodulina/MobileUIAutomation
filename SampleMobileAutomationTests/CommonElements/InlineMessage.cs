using OpenQA.Selenium;
using Sample.Mobile.Core.WebElement;

namespace SampleMobileAutomationTests.CommonElements
{
    public class InlineMessage
    {
        public readonly CustomWebElement InlineError = new CustomWebElement(By.Id(InlineMessageSelectors.InlineMessage));

        public string GetErrorText()
        {
            return InlineError.Element.Text;
        }
    }
}