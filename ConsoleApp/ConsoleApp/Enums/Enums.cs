using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Enums
{
    class Enums
    {
        public static void Run()
        {
            var favoriteFruit = FruitsEnum.Mango;
            Console.WriteLine((int)favoriteFruit);

            var mango = 1;
            Console.WriteLine((FruitsEnum)mango);

            // enum to string
            Console.WriteLine(favoriteFruit.ToString()); ;

            // string to enum 
            var mangoString = "Mango";
            var mangoEnum = (FruitsEnum)Enum.Parse(typeof(FruitsEnum), mangoString);
            Console.WriteLine(mangoEnum);
        }
    }
}
