using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StaticApp2
{
    class Program
    {
        private static string result="";
        static void Main(string[] args)
        {
            Console.WriteLine("start app");
            Say();
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static async Task<string> Say()
        {
            await Task.Run(() => { Thread.Sleep(0); });
            result = "task";
            return "something";
        }
    }
}
