using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAsyncAwaitApp
{
    class Program
    {
        private static int x;

        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(DoAsync(i));
            }
            Task t = Task.WhenAll(tasks);
            try
            {
                t.Wait();
            }
            catch (Exception)
            {

                throw;
            }
            if (t.Status == TaskStatus.RanToCompletion)
                Console.WriteLine("All ping attempts succeeded.");
            else if (t.Status == TaskStatus.Faulted)
                Console.WriteLine("ping attempts failed");

            Console.ReadLine();
        }

        private static async Task DoAsync(int num)
        {
            await Task.Run(() =>
            {
                x = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x} task:{num}");
                    x++;
                    Thread.Sleep(200);
                }
            });
        }
    }
}
