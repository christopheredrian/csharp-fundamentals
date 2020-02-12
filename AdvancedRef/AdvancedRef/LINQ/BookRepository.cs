using System.Collections.Generic;

namespace AdvancedRef.LINQ
{
    class BookRepository
    {

        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Lord of the Rings", Price = 20.73M},
                new Book() { Title = "Harry Potter", Price = 54.99M},
                new Book() { Title = "ADO.Net Step by Step", Price = 5.00M},
                new Book() { Title = "ASP.Net MVC", Price = 9.99M},
                new Book() { Title = "C# Advance Topics", Price = 7.00M},
                new Book() { Title = "C# Advance Topics", Price = 9.00M},
            };
        }
    }
}
