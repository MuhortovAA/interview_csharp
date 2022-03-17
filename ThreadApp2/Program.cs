using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> fun = (i) => { new Thread(() => Console.Write($"{i}")).Start(); return i; };


            //var result = Enumerable.Range(0, 10).Select(fun).ToArray();

            for (int i = 0; i < 10; i++)
            {
                new Thread(() => Console.Write(i)).Start();
            }
            
            
            Console.Read();


        }
    }
}
