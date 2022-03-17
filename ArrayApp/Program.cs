using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            Console.WriteLine(list.First(s => s > 5).ToString());
            Console.Read();
        }
    }
}
