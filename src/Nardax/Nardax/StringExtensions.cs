using System;
using System.ComponentModel;

namespace Nardax
{
    public static class StringExtensions
    {

        // Klipp av en sträng från väster
        public static string TruncateLeft(this string value, int maxLength)
        {
            var startIndex = value.Length - maxLength;

            if (startIndex < 1)
            {
                return value;
            }

            return value.Substring(startIndex, maxLength);
        }

        
    }
}
