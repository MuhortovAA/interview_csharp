using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLockApp
{
    class Program
    {
        //private static int locker = 1;
        private static object locker = new object();
        private static int x;

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread myt = new Thread(Count);
                myt.Name = $"Thread:{i}";
                myt.Start();
            }
            Console.ReadLine();
        }

        private static void Count()
        {
            lock (locker)
            {
                x = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                    x++;
                    Thread.Sleep(200);
                }
            }
        }
    }
}
