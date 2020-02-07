using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Types.Variables();
            //RunPerson();
            //RunCalculator();
            //RunBook();
            //Arrays.Run();
            //Strings.Run();
            //Enums.Enums.Run();
            //ValidInvalid.Run();
            //RandomRef.Run();
            //ArraysRef.Run();
            //ListRef.Run();
            //Exercises.ExArrays.Run();
            //DatesTimes.Run();
            //StringBuilderRef.Run();
            //FilesRef.Run();
            //Exercises.ExFiles.Run();
            DebuggingRef.Run();
        }

        static void RunBook()
        {
            var theLuckyOne = new Book();
            theLuckyOne.Title = "The Lucky One";
            theLuckyOne.Author = "Nicholas Spakrs";
            theLuckyOne.NumberOfPages = 300;

            Console.WriteLine(theLuckyOne);
        }

        static void RunCalculator()
        {
            var calculator = new Calculator();
            var onePlusTwo = calculator.Add(1, 2);
            Console.WriteLine(onePlusTwo);
        }

        static void RunPerson()
        {
            var bob = new Person();
            bob.FirstName = "Bob";
            bob.LastName = "Marley";
            bob.Introduce();
        }

    }

}
