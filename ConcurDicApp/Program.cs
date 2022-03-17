using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurDicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<string, string> dictionary = new ConcurrentDictionary<string, string>();




            Task t1 = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; ++i)
                {
                    if (i % 2 == 0)
                    {
                        dictionary.TryAdd(i.ToString(), i.ToString());
                        Console.WriteLine("Add:" + i.ToString() + "-" + i.ToString());
                    }

                    Thread.Sleep(100);
                }
            });
            Task t2 = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; ++i)
                {
                    if (i % 2 != 0)
                    {
                        dictionary.TryAdd(i.ToString(), i.ToString());
                        Console.WriteLine("Add:" + i.ToString() + "-" + i.ToString());
                    }

                    Thread.Sleep(100);
                }
            });
            Task t3 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);
                foreach (var item in dictionary)
                {
                    Console.WriteLine("view:"+ item.Key + "-" + item.Value);
                    Thread.Sleep(50);
                }
            });

            try
            {
                Task.WaitAll(t1, t2, t3);
            }
            catch (AggregateException ex) // No exception
            {
                Console.WriteLine(ex.Flatten().Message);
            }

            Console.Read();
        }
    }
}
