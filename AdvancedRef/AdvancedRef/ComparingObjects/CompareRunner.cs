using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedRef.ComparingObjects
{
    class Alcohol: IComparable<Alcohol>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Alcohol alcohol)
        {
            return Price.CompareTo(alcohol.Price);
        }
    }

    class CompareRunner
    {
        public static void Run()
        {
            var rum = new Alcohol() { Name = "Tanduay", Price = 2.00M };
            var wine = new Alcohol() { Name = "Roscatto", Price = 12.49M };

            Console.WriteLine(wine.CompareTo(rum)); ;
        }
         
    }
}
