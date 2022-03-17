using System;

namespace ConsoleApp2
{
    class Program
    {
        public record Person(string FirstName, string LastName);
        static void Main(string[] args)
        {
            Person person = new("Nancy", "Davolio");
            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}
