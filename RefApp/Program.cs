using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fred = new Person("Fred", 12);
            Console.WriteLine("Before by value call, Person is:");
            fred.Display();
            SendAPersonByValue(fred);
            Console.WriteLine("After by value call, Person is:");
            fred.Display();
            Console.ReadLine();

        }
        static void SendAPersonByValue(Person p)
        {
            p.personAge = 99;
            p = new Person("Nikki", 97);
        }
    }
    class Person
    {
        public int personAge { get; set; }
        public string personName { get; set; }
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {personName}, Age: {personAge}");
        }
    }
}
