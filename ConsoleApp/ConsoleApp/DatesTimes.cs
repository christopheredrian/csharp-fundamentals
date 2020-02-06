using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DatesTimes
    {

        public static void Run()
        {

            var dateTime = new DateTime(2020, 2, 8);

            // Y m d H i s 
            var now = DateTime.Now;
            Console.WriteLine(now);

            // only the days, defaults to 12 AM for the time part 
            var today = DateTime.Today;
            Console.WriteLine(today);

            Console.WriteLine(now.Year);
            Console.WriteLine(now.Month);
            Console.WriteLine(now.Day);

            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.Second);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine($"Tomorrow: {tomorrow}");
            Console.WriteLine($"Yesterday: {yesterday}");

            // to string
            Console.WriteLine(now.ToLongDateString()); 
            Console.WriteLine(now.ToShortDateString()); 
            Console.WriteLine(now.ToLongTimeString()); 
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));

            //
            // Timespan
            //
            Console.WriteLine("- - -Timespan - - -");
            var timespan = new TimeSpan(1, 2, 3);
            timespan = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Duration: " + duration);

            // timespan properties
            Console.WriteLine(duration.Minutes);

            Console.WriteLine(duration.TotalMinutes);
            Console.WriteLine(duration.TotalSeconds);
            Console.WriteLine(duration.TotalMilliseconds);

            // add 
            var added = duration.Add(TimeSpan.FromMinutes(10));
            Console.WriteLine(added);

            var sub = duration.Add(TimeSpan.FromMinutes(-10));
            Console.WriteLine(sub);

            // ts to string 
            Console.WriteLine(sub.ToString());
            Console.WriteLine(TimeSpan.Parse("01:02:30"));

            Console.WriteLine(TimeSpan.FromHours(1));

        }
    }
}
