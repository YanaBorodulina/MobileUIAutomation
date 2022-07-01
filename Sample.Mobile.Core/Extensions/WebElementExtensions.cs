using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Sample.Mobile.Core.Extensions
{
    public static class WebElementExtensions
    {
        public static AppiumWebElement TypeInto(this AppiumWebElement element, string text)
        {
            element.Clear();

            if (!string.IsNullOrEmpty(text))
            {
                element.SendKeys(text);
            }

            return element;
        }

        public static void ClearBackspace(this AppiumWebElement elem)
        {
            var length = elem.GetValue().Length;

            while (length != 0)
            {
                elem.SendKeys(Keys.Backspace);
                length--;
            }
        }

        public static string GetValue(this AppiumWebElement element) => element.GetAttribute("value");
    }
}