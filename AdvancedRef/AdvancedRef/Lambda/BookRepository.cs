using System.Collections.Generic;

namespace AdvancedRef.Lambda
{
    class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {Title = "Harry Potter", Price= 59.99M},
                new Book {Title = "Lord of the Rings", Price = 29.99M},
                new Book {Title = "The Lucky One", Price = 14.99M}
            };

        }

        /// <summary>
        /// Prints all the books 
        /// </summary>
        /// <param name="books"></param>
        public static void PrintBooks(List<Book> books) 
        {
            System.Console.WriteLine($"Printing {books.Count} books");

            foreach (var book in books)
            {
                System.Console.WriteLine(book.ToString());
            }
        }

    }
}
