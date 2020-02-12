using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedRef.NullableTypes
{
    class NullableTypesRunner
    {
        public static void Run()
        {
            //Nullable<DateTime> date = null;
            DateTime? date = null;
            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            //Console.WriteLine(date.Value);

            DateTime? anotherDate = null;
            var dateTwo = anotherDate ?? DateTime.Now;

            Console.WriteLine(dateTwo);

        }
    }
}
