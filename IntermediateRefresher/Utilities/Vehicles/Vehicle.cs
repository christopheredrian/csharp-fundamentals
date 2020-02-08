using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Vehicles
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        
        public Vehicle(string registrationNumber)
        {
            Console.WriteLine($"@Vehicle {registrationNumber}");
            this.registrationNumber = registrationNumber;
        }

    }
}
