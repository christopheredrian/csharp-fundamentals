using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Vehicles
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine($"@Car {registrationNumber}");
        }
    }
}
