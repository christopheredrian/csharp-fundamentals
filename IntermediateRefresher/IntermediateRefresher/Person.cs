using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediateRefresher
{
    class Person : Object
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; private set; }

        public int Age { 
            get {
                var timeSpan = DateTime.Today - Birthdate;
                return timeSpan.Days / 365;
            }
         }

         public Person(DateTime birthDate)
         {
             Birthdate = birthDate;
         }


        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to} I am {FirstName} {LastName}");
        }

        public static Person Parse(DateTime birthDate, string firstName, string lastName)
        {
            var person = new Person(birthDate)
            {
                FirstName = firstName,
                LastName = lastName
            };
            return person;
        }

        public static void Run()
        {
            var person = new Person(new DateTime(2001, 1, 1)) { FirstName = "Bob", LastName = "Marley" };
            person.Introduce("Joe");

            var george = Person.Parse(new DateTime(1995, 06,05), "George", "Alo");
            george.Introduce("Joe");

            System.Console.WriteLine(george.Birthdate);
            System.Console.WriteLine(george.Age);

        }
    }
}
