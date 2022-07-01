using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;

namespace Sample.Mobile.Core.Extensions
{
    public static class WebDriverExtensions
    {
        public static void Swipe(this IPerformsTouchActions driver, int xStart = 100, int yStart = 1500, int xEnd = 100, int yEnd = 300, int wait = 200)
        {
            ITouchAction touchAction = new TouchAction(driver);
            touchAction.Press(xStart, yStart).Wait(wait).MoveTo(xEnd, yEnd).Release();
            touchAction.Perform();
        }
    }
}