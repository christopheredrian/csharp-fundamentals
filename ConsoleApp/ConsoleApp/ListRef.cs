using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class ListRef
    {

        public static void Run()
        {
            var numbers = new List<int>();
            numbers.Add(1);
            numbers.AddRange(new int[] { 2, 3, 4 });

            Utilities.PrintArray(numbers);
            Console.WriteLine(numbers.IndexOf(44));
            Console.WriteLine(numbers.Count);
        }

    }
}
