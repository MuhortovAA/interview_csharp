using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int external = 0;
            Func<int, bool> fun = x => x > 2;
            external = 10;
            int[] barr = arr.Where(fun).ToArray();
            var barr2 = arr.Select(fun).ToArray();


            Func<int, bool> f = i => i > 0;
            var result = f(1);
            Console.WriteLine(result);
            Console.ReadLine();

        }


    }
}
