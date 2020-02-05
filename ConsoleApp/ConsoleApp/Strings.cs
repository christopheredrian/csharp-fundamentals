using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Strings
    {
        public static void Run()
        {
            string name = string.Format("{0} {1}", "Cee", "Esp");
            Console.WriteLine(name);

            // convert array into string
            string[] groups = new string[] { "alpha", "beta", "charlie" };
            var groupsCsv = string.Join(",", groups);
            Console.WriteLine(groupsCsv);

            // print all characters in a string
            var seriesName = "Money Heist";

            for (int i = 0; i < seriesName.Length; i++)
            {
                Console.WriteLine(seriesName[i]);
            }
            Console.WriteLine("--- ALTERNATIVELY ---");

            // alternatively
            foreach (var character in seriesName)
            {
                Console.WriteLine(character);
            }

            // verbatim strings
            string path = @"C:\Program Files";
            Console.WriteLine(path);

            // multi
            // line
            // strings
            var text = @"
                Hi!
                This is a 
                multi
                line
                string
            ";
            Console.WriteLine(text);
        }
    }
}
