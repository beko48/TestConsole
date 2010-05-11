using System;
using TestClassLibrary;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person() { Name = "Bob" };
            Console.WriteLine(aPerson.Name + " is 20");
            Console.ReadKey();
        }
    }
}
