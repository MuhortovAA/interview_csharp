using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myt = new Thread(new ThreadStart(Count));
            myt.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main thread:{i * i}");
                Thread.Sleep(300);

            }
            Console.ReadLine();
        }

        private static void Count()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Second thread:{i*i}");
                Thread.Sleep(400);
            }
        }
    }
}
