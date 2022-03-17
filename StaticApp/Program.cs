using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticApp
{
    class Program
    {
        static string Name;
        static DateTime timer;
        static int i=default;
        static void Main(string[] args)
        {
            //Console.WriteLine(i == null ? "is null" : i.ToString());
            Console.WriteLine(Name == null ? "is null" : Name);
            Console.WriteLine(timer == null ? "is null" : timer.ToString());

            Console.ReadLine();
        }
    }
}
