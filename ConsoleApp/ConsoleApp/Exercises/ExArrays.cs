using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Exercises
{
    class ExArrays
    {
        public static void Run()
        {


            Names();

            // reverse input
            Console.Write("Enter one name and I'll reverse it for you: ");
            var name = Console.ReadLine();
            var nameArr = name.ToArray();

            // reverse string 
            Array.Reverse(nameArr);
            name = string.Join("", nameArr);
            Console.WriteLine(name);

            // csv parse
            Console.Write("Enter csv integers and will return the max: ");
            var intCsvs = Console.ReadLine();

            var numbersToGetMax = intCsvs.Split(new char[1] { ',' });

            var maxNumber = int.MinValue;

            foreach (var numString in numbersToGetMax)
            {
                var num = int.Parse(numString);

                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }

            Console.WriteLine($"Max number is {maxNumber}");

        }

        private static void Names()
        {
            List<string> names = new List<string>();

            do
            {
                Console.Write("Enter Name: ");
                var name = Console.ReadLine();

                if (String.IsNullOrEmpty(name))
                {
                    break;
                }

                names.Add(name);

            } while (true);

            if (names.Count > 0)
            {
                Console.WriteLine("Printing names: ");
                var namesCsv = String.Join(",", names.ToArray());
                Console.WriteLine(namesCsv);
            } else 
            {
                Console.WriteLine("No names given.");
            }

        }
    }
}
