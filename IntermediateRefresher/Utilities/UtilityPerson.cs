using System;

namespace Utilities
{
    public class UtilityPerson 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var newRate = calculator.Calculate(this);
            Console.WriteLine(newRate);
        }


    }
}
