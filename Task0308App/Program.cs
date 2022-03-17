using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task0308App
{
    class Program
    {
        static object locker = new object();
        static object locker2 = new object();
        static object lockerA = new object();
        static object lockerB = new object();


        static void Main(string[] args)
        {
            int result = 0;
            var res = Interlocked.Increment(ref result);

            List<Task> tasks = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                var str = $"Thread:{Thread.CurrentThread.ManagedThreadId} Task:1 {i}";
                var t1 = Task.Run(() => Count2(str));
                //tasks.Add(t1);
            }
            //Task.WaitAll(tasks.ToArray());
            //t.Wait();
            int j = 10;
            do
            {
                var str = $"Thread:{Thread.CurrentThread.ManagedThreadId} Task:2 {j}";

                var t2 = Task.Run(() => Count3(str));
                //tasks.Add(t2);
                j--;
            } while (j > 0);
            //Task.WaitAll(tasks.ToArray());

            Console.Read();

        }
        public static void Count(string str)
        {
            lock (locker)
            {
                Console.WriteLine($"Task start {str}");
                Thread.Sleep(1000);
            }
        }
        public static void Count2(string str)
        {
            lock (lockerA)
            {
                lock (lockerB)
                {
                    Console.WriteLine($"Task start {str}");
                    Thread.Sleep(1000);
                }
            }
        }
        public static void Count3(string str)
        {
            lock (lockerB)
            {
                lock (lockerA)
                {
                    Console.WriteLine($"Task start {str}");
                    Thread.Sleep(1000);
                }
            }
        }
    }


}
