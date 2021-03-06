﻿using System;
using AdvancedRef.Delegates;

namespace AdvancedRef
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunDelegate();
            //Lambda.LambdaRunner.Run();
            //Events.EventRunner.Run();
            //Events.Center.Run();
            //ExtensionMethods.ExtensionMethodsRunner.Run();
            //LINQ.LinqRunner.Run();
            //NullableTypes.NullableTypesRunner.Run();
            //ComparingObjects.CompareRunner.Run();
            //ExceptionHandling.ExceptionHandlingRunner.Run();
        }

        public static void RunDelegate()
        {
            var processor = new PhotoProcessor();

            PhotoFilters filters = new PhotoFilters();

            // these are like callback functions that will be passed 
            // on the filterHandler call inside the process function
            // similar to js callback functions
            Action<Photo> filterHandler = filters.ApplyBrightness;
            // add another delegate 
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpeg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photos)
        {
            Console.WriteLine("Applying red eye filter.");
        }


        static void Sepia()
        {
            Console.WriteLine("Applying Sepia filter");
        }
    }
}
