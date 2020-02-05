using System;
using static System.Console;

namespace ConsoleApp
{
    class Arrays
    {
        public static void Run()
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            PrintArray(numbers);

            int[] ages = new int[] { 22, 23, 24 };

            PrintArray(ages);

        }

        public static void PrintArray(int[] ar)
        {
            foreach (var item in ar)
            {
                WriteLine(item);
            }
        }
    }
}
