using System;
using Utilities;
using Utilities.Vehicles;

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
            //UtilityPersonRunner();
            VehicleRunner();
            Console.WriteLine("...");
            Console.ReadLine();
        }

        public static void UtilityPersonRunner()
        {
            var utilPerson = new UtilityPerson();
            utilPerson.Promote();
        }

        public static void VehicleRunner()
        {
            var car = new Car("ABC123");
            Console.WriteLine(car.GetType());

            Vehicle carVehicle = car; 
            Console.WriteLine(carVehicle.GetType());
        }
    }
}
