using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DebuggingRef
    {
        public static void Run()
        {
            var numbers = new List<int> { 5, 4, 3, 2, 1 };

            var smallests = GetSmallest(numbers, 3);

            foreach (var number in smallests)
            {
                Console.WriteLine(number);
            }

        }
        /// <summary>
        /// Get n smallest numbers on the list passed
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="count">number of smallest numbers to get</param>
        /// <returns></returns>
        public static List<int> GetSmallest(List<int> numbers, int count)
        {
            numbers.Sort();
            var smallestList = numbers.GetRange(0, count);
            return smallestList;
        }
    }
}
