using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => GetId(1));
            Thread.Sleep(1000);
            Task.Run(() => Console.WriteLine("Result"));
            Console.ReadLine();
        }
        public static async void GetId(int id)
        {
            await Task.Run(() => GetId2(id));
            Console.WriteLine($"1: Hello Task!");


        }
        public static void GetId2(int id)
        {
            //Task.Delay(1);
            Console.WriteLine($"2: Hello Task!");
        }
    }

}
