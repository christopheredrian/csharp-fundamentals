using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Types
    {

        public static void Variables()
        {
            const double Pi = Math.PI;
            Console.WriteLine($"The value of PI is {Pi}");

            byte number = 5;
            Console.WriteLine(number);

            float totalPrice = 19.99f;
            Console.WriteLine(totalPrice);

            char character = 'A';
            Console.WriteLine(character);

            string firstName = "Chris";
            Console.WriteLine(firstName);

            bool isWorking = true;

            if (isWorking)
            {
                Console.WriteLine("Is working!!!");
                Console.WriteLine(isWorking);
            }


            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            float myFloat = 2.9f;
            int converted = (int)myFloat;
            Console.WriteLine(converted);

            double convertedInt = Convert.ToDouble("23.23");
            Console.WriteLine(convertedInt);

            int myInt = 2568;
            byte max = (byte)myInt;

            Console.WriteLine(max);


            try
            {
                Convert.ToDouble("25v");
            }
            catch (Exception)
            {
                Console.WriteLine(@"Can't convert 25v to a double");
            }

            // This is a 
            // multi-line comment 
            byte n = 255;
            n += 2;
            Console.WriteLine(n);
        }
    }
}
