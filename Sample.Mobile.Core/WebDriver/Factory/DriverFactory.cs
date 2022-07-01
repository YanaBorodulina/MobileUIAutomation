using System;

namespace Sample.Mobile.Core.WebDriver
{
    public class DriverFactory
    {
        public static IDriverCreator GetDriverCreator(string driverType)
        {
            return driverType switch
            {
                "IOS" => new IOsDriverCreator(),
                "Android" => new AndroidDriverCreator(),
                _ => throw new NotImplementedException($"{driverType} doesn't supported.")
            };
        }
    }
}