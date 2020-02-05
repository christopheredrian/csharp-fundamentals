using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class RandomRef
    {
        public static void Run()
        {

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(generateRandomPassword(i));
            }

           
        }

        public static string generateRandomPassword(int length)
        {
            var random = new Random();

            StringBuilder builder = new StringBuilder(length);

            for (int i = 1; i <= length; i++)
            {
                builder.Append((char)('a' + random.Next(0, 26)));
            }

            return builder.ToString();
        }
    }
}
