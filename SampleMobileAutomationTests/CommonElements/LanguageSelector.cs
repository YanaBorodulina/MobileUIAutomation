using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using Sample.Mobile.Core.WebDriver;

namespace SampleMobileAutomationTests.CommonElements
{
    public class LanguageSelector
    {
        public AppiumWebElement GetLanguage(string language)
        {
            //TODO should be changed now get first in a list 
            return Driver.Instance.FindElement(By.Id($"com.solaireresort.mysolairemobileapp:id/language_text_view"));
        }
    }
}