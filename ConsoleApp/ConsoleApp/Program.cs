using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Types.Variables();


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
