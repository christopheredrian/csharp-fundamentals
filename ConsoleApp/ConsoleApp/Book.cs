using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public struct Book
    {
        public string Title;
        public string Author;
        public int NumberOfPages;


        public override string ToString()
        {
            return String.Format("\"{0}\" by {1}. Number of pages {2}", Title, Author, NumberOfPages);
        }
    }
}
