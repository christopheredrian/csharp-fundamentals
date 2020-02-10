using System;
using System.Text;

namespace AdvancedRef.Lambda
{
    class LambdaRunner
{
    public static void Run()
    {
            //BasicUsage();
            var bookRepo = new BookRepository();
            var books = bookRepo.GetBooks();

            BookRepository.PrintBooks(books);
            Console.WriteLine();

            var booksLessThanFifty = books.FindAll(b => b.Price < 50);
            BookRepository.PrintBooks(booksLessThanFifty);


    }

    public static void BasicUsage()
    {

        // with lambda
        // in, out
        Func<int, int> square = number => number * number;
        // () => ..
        // x => ...
        // (x, y, z) => ...
        Console.WriteLine(square(5));

        const int factor = 5;
        Func<int, int> multiplier = n => n * factor;

        Console.WriteLine(multiplier(2));
    }

    // square a number
    public static int Square(int num)
    {
        return num * num;
    }
}
}
