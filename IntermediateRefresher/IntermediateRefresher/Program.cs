using System;
using Utilities;
using Utilities.Vehicles;
using Utilities.Shapes;
using System.Collections.Generic;

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
            //VehicleRunner();
            //Exercises.Stack<string>.Run();
            //RunCanvas();
            Exercises.Workflows.WorkFlowEngine.Run();
            Console.WriteLine("...");
            //Console.ReadLine();
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

            var carVehicle = (Vehicle)car;
            if (carVehicle is Car)
            {
                car = (Car)carVehicle;
            }

            //var carVehicle = car as Vehicle;

            //if (carVehicle != null)
            //{
            //    Console.WriteLine(carVehicle.GetType());
            //}
        }

        public static void RunCanvas()
        {
            var canvas = new Canvas();
            var shapes = new List<Shape>
            {
                new Circle() { Height= 100, Width = 200, Position= new Position {X = 0, Y = 0}},
                new Rectangle() { Height= 50, Width = 50 , Position= new Position {X = 50, Y = 25}}
            };
            canvas.DrawShapes(shapes);

        }
    }
}
