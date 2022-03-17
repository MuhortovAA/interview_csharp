using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            worker.mess = "Hello test";
            var result = worker.GetMessage();
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
    public class Worker
    {
        public string mess { get; set; }
        public string GetMessage()
        {
            Console.WriteLine(this.mess);
            return $"{this.mess} {DateTime.Now.ToString("dd-MM-yyyy")}";
        }
    }
}
