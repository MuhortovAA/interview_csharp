using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task03082App
{
    class Program
    {
        private static object locker = new object();
        static int result = 0;

        static void Main(string[] args)
        {


            var res = new myResult();
            

            for (int i = 0; i < 10; i++)
            {
                //var t1 = Task.Run(() => res1.Count(1));
                var t1 = new Thread(new ThreadStart(res.Count));
                t1.Start();

            }
            int j = 10;
            do
            {

                //var t2 = Task.Run(() => res1.Count2(2));
                var t1 = new Thread(new ThreadStart(res.Count2));
                t1.Start();
                j--;
            } while (j > 0);
            Console.ReadLine();
            Console.WriteLine($"Result is {res.result}");
            Console.ReadLine();

        }
        public static void Count()
        {
            //lock (locker)
            //{
            result++;
            var str = $"Thread:{Thread.CurrentThread.ManagedThreadId} Task:{1} {result}";
            Console.WriteLine($"Task start {str}");
            //Thread.Sleep(1000);
            //}
        }
        public static void Count2()
        {
            //lock (locker)
            //{
            result++;
            var str = $"Thread:{Thread.CurrentThread.ManagedThreadId} Task:{2} {result}";
            Console.WriteLine($"Task start {str}");
            //Thread.Sleep(1000);
            //}
        }
    }
    public class myResult
    {
        public int result = 0;

        public void Count()
        {
            //lock (locker)
            //{
            

            result++;
            //var str = $"Thread:{Thread.CurrentThread.ManagedThreadId} Task:{1} {result}";
            //Console.WriteLine($"Task start {str}");
            //Thread.Sleep(1000);
            //}
        }
        public void Count2()
        {
            //lock (locker)
            //{
            var rnd = new Random();
            Thread.Sleep(rnd.Next(0, 1000));
            result++;
            //var str = $"Thread:{Thread.CurrentThread.ManagedThreadId} Task:{2} {result}";
            //Console.WriteLine($"Task start {str}");
            //Thread.Sleep(1000);
            //}
        }
    }
}
