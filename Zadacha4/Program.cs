using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("A");
            await Say();
            Console.WriteLine("B");
            Console.ReadLine();
        }
        static async Task Say()
        {
            Console.WriteLine("C");
             Task.Delay(5);
            Console.WriteLine("D");
        }
    }
}
