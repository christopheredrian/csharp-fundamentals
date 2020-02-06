using System;
using System.Text;

namespace ConsoleApp
{
    class StringBuilderRef
    {
        public static void Run()
        {

            var testString = " hello World! ";

            // useful string methods
            Console.WriteLine(testString.ToLower());
            Console.WriteLine(testString.ToUpper());
            Console.WriteLine(testString.Trim());
            Console.WriteLine(testString.IndexOf("World"));
            Console.WriteLine(testString.LastIndexOf("World"));
            Console.WriteLine(testString.Substring(0, 3));
            Console.WriteLine(testString.Replace("World", "Earth"));

            if (string.IsNullOrEmpty(""))
            {
                Console.WriteLine("WS");
            }

            if (string.IsNullOrWhiteSpace(""))
            {
                Console.WriteLine("WS");
            }

            var explodedStr = testString.Split(' ');
            Console.WriteLine(explodedStr);

            var thisIsANumber = "123";

            // string to number 
            var parsedNumber = Convert.ToInt32(thisIsANumber);
            Console.WriteLine(parsedNumber);

            // num to string
            var i = 123.23;

            // currency
            Console.WriteLine(i.ToString("C"));

            // no decimal
            Console.WriteLine(i.ToString("C0"));

            // one decimal
            Console.WriteLine(i.ToString("C1"));

            Console.WriteLine(string.Join(",", explodedStr));

            // StringBuilder - represents mutable string
            // fast to create and manipulate string 
            var builder = new StringBuilder();
            builder.Append('-', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 10)
            .Insert(0, new string('=', 11) + "\n")
            .Remove(0, 1);

            Console.WriteLine(builder);

        }
    }
}
