using System;
using Utilities;

namespace IntermediateRefresher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person.Run();
            // Customer.Run();
            //Point.Run();
            // Calculator.Run();
            //HttpCookieIndexer.Run();
            //Exercises.Stopwatch.Run();
            //Exercises.Post.Run();
            //ClassAssoc.InheritanceRunner.Run();
            UtilityPersonRunner();
            Console.WriteLine("...");
            Console.ReadLine();
        }

        public static void UtilityPersonRunner()
        {
            var utilPerson = new UtilityPerson();
            utilPerson.Promote();

        }
    }
}
