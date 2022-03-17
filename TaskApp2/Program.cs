using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = Task.Run(() => {
                Thread.Sleep(5000);
                Console.WriteLine("Task Run"); });
            task.Wait();
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }
    }
}
