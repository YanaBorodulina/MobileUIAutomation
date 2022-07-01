using System;

namespace Sample.Mobile.Core.Extensions
{
    public static class ValidateExtensions
    {
        public static T CheckNotNull<T>(this T value, string argumentName, string errorMessage = null)
        {
            if (value != null)
            {
                return value;
            }
            
            throw new ArgumentNullException(argumentName, errorMessage);
        }
    }
}