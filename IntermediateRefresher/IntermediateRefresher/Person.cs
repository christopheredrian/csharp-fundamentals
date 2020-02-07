using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediateRefresher
{
    class Person
    {

        public string FirstName;
        public string LastName;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to} I am {FirstName} {LastName}");
        }

        public static Person Parse(string firstName, string lastName)
        {
            var person = new Person() 
            { 
                FirstName = firstName, 
                LastName = lastName 
            };
            return person;
        }

        public static void Run()
        {
            var person = new Person() { FirstName = "Bob", LastName = "Marley"};
            person.Introduce("Joe");

            var george = Person.Parse("George", "Alo");
            george.Introduce("Joe");

        }
    }
}
