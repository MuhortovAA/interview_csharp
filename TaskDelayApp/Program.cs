using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDelayApp
{
    class Program
    {
        private static string result;
        static void Main(string[] args)
        {
            int i = 1;
            int j = i;
            j = 2;
            Console.WriteLine($"i:{i} j:{j}");


            string a = "a";
            string b = a;
            b = "b";
            Console.WriteLine(a);
            Console.WriteLine(b);
            //Console.WriteLine("Start App");
            //DoAsync2();
            //Console.WriteLine(result);
            Console.ReadLine();
        }

        private static async Task<string> DoAsync2()
        {
            Thread.Sleep(5);
            result = "Hello world!";
            return "something";
        }
        private static async Task<string> DoAsync()
        {
            await Task.Delay(5);
            result = "Hello world!";
            return "something";
        }
    }
}
