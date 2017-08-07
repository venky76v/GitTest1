using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // code was changed in github
            Console.WriteLine("Some code changed in github as a part of Git Fundamentals channel 9 msdn tutorial");
            Console.Read();
            // code to call feature 1
            var person = new Feature1();
            Console.WriteLine(person.FullName);
            person.LastName = "Skeet";
            person.FirstName = "Jon";
            Console.WriteLine(person.FullName);
        }
    }
}
