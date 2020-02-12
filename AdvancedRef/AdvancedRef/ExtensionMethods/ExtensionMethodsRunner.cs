using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdvancedRef.ExtensionMethods
{
    class ExtensionMethodsRunner
    {
        public static void Run()
        {
            string postTitle = "This is a long post title";
            var shortenedPost = postTitle.Shorten(3);
            System.Console.WriteLine(shortenedPost);

            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var biggestNumber = numbers.Max();
            var mean = numbers.Average();
            System.Console.WriteLine(mean);
            System.Console.WriteLine(biggestNumber);
        }
    }
}
