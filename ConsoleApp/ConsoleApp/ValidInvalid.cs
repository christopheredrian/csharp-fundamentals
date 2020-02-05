using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ValidInvalid
    {
        public static void Run()
        {

            do {
                Console.Write("Enter value from 1 to 10 (Newline to exit): ");
                var line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                {
                    break;
                }

                try
                {
                    var number = int.Parse(line);

                    if (number < 0 || number > 10)
                    {
                        throw new Exception("Number is not from 1 to 10");
                    }

                    Console.WriteLine("Number is valid");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);


        }
    }
}
