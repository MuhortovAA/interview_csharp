using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> fun = (i) => { if (i % 2 == 0) Console.WriteLine($"Result:{i}"); return i; };

            GC.Collect();
            var result = Enumerable.Range(0, 1000)
                .Select(fun).ToArray();
            Console.Read();
        }
    }
}
