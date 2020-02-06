using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleApp
{
    class Utilities
    {

        public static void PrintArray(int[] ar)
        {
            foreach (var item in ar)
            {
                WriteLine(item);
            }
        }

        public static void PrintArray(IEnumerable enumerable)
        {
            foreach (var item in enumerable)
            {
                WriteLine(item);
            }
        }
    }
}
