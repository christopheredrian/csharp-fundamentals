using System;
namespace AdvancedRef.Generics
{
    public class GenericsRunner
    {
        public void Run()
        {
            var booksList = new GenericList<Book>();

            var hp = new Book { Isbn = "ISBN1", Title = "Harry Potter" };
            var lotr = new Book { Isbn = "ISBN 2", Title = "Lord of the Rings" };

            booksList.Add(hp);
            booksList.Add(lotr);

            var bookIsbnMap = new GenericDictionary<string, Book>();
            bookIsbnMap.Add(hp.Isbn, hp);
            bookIsbnMap.Add(lotr.Isbn, lotr);

        }
    }
}
