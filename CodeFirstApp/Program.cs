using CodeFirstApp.Context;
using CodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ApplicationContext())
            {
                var person1 = new Personal { Id = 1, Age = 45, Email = "alex@post.by", Phone = "+375297507898", FIO = "Иванов Иван Иванович", IdOrder=1 };
                db.Personals.Add(person1);
                db.SaveChanges();
                Console.WriteLine("Save success!");
                var personals = db.Personals;
                Console.WriteLine("List of items:");
                foreach (var person in personals)
                {
                    Console.WriteLine($"{person.Id} {person.FIO} - {person.Age}");
                }
            }
            Console.Read();
        }
    }
}
