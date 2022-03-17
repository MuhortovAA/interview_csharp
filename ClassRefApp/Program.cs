using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRefApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 30;
            SetInt(id);
            Console.WriteLine(id);
            Console.ReadLine();

            var data = new myData(10);
            Console.WriteLine(data.X);
            Console.ReadLine();
            Setdata(ref data);
            Console.WriteLine(data.X);
            Console.ReadLine();
        }

        public static void SetInt(int id)
        {
            id = 20;
        }

        public static void Setdata(ref myData data)
        {
            data.X = 20;
        }
    }
    public class myData
    {
        public myData(int x)
        {
            X = x;
        }
        public int X { get; set; }
    }
}
