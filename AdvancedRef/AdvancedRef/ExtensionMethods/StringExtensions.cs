using System;
using System.Linq;

namespace AdvancedRef.ExtensionMethods
{
    /// <summary>
    /// Extension methods are last resort
    /// </summary>
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords == 0)
                return str;

            var words = str.Split(" ");

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }

    }
}
