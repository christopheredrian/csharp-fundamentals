using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace AdvancedRef.LINQ
{
    class LinqRunner
    {
        public static void Run()
        {
            //Basics();

            var books = new BookRepository().GetBooks();
            //var lotr = books.Single(book => book.Title == "Lord of the Rings");
            var lotr = books.SingleOrDefault(book => book.Title == "Lord of the Rings");

            Console.WriteLine(lotr);

            var firstCsAdvanceTopicBook = books.FirstOrDefault(b => b.Title == "C# Advance Topics");
            Console.WriteLine(firstCsAdvanceTopicBook);


            var lastCsAdvanceTopicBook = books.LastOrDefault(b => b.Title == "C# Advance Topics");
            Console.WriteLine(lastCsAdvanceTopicBook);

            Console.WriteLine("---");
            var threeBooks = books.Skip(2)
                .Take(3);

            PrintCollection(threeBooks);
            Console.WriteLine("---");

            Console.WriteLine(books.Count());
            Console.WriteLine("---");

            var highestPrice = books.Max(b => b.Price);
            Console.WriteLine(highestPrice);

            Console.WriteLine("---");
            var totalPrices = books.Sum(b => b.Price);
            Console.WriteLine(totalPrices);
        }

        public static void Basics()
        {
            // LINQ - Language Integration Query
            // Objects in memory - LINQ to Objects
            // Databases - LINQ to Entities
            // XML - LINQ to XML
            // ADO.Net Datasets - LINQ to DataSets
            var books = new BookRepository().GetBooks();

            // LINQ Query Operator
            var cheaperBooksQueryOp = from b in books
                                      where b.Price < 20
                                      orderby b.Title descending
                                      select b.Title;

            PrintCollection(cheaperBooksQueryOp);

            Console.WriteLine("----");

            // LINQ Extension Methods
            var cheapBooks = books.Where(book => book.Price < 20)
                .OrderByDescending(book => book.Title)
                .Select(book => book.Title);

            PrintCollection(cheapBooks);

        }

        public static void PrintCollection(IEnumerable enumerable)
        {
            foreach (var item in enumerable)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
