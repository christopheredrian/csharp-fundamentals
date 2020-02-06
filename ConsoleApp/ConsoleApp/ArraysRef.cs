using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ArraysRef
    {

        public static void Run()
        {

            ArraysRef.MultiDimensionalArrays();
        }

        public static void MultiDimensionalArrays()
        {

           

            var matrixA = new int[3, 5]
            {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15},
            };

            var numbers = new int[3]; // 3 rows 5 columns
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine(numbers.Length);
            var index = Array.IndexOf(numbers, 2);

            // clear
            Console.WriteLine(index);
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Numbers: ");
            Arrays.PrintArray(numbers);

            // copy
            int[] source = new int[] { 1, 2, 3 };
            int[] dest = new int[3];
            Array.Copy(source, dest, 3);

            Console.WriteLine("Numbers: ");
            Arrays.PrintArray(dest);

            Console.WriteLine("Numbers: ");
            Array.Sort<int>(source, new Comparison<int>((a, b) =>  b.CompareTo(a)));
            Arrays.PrintArray(source);

        }
    }
}
