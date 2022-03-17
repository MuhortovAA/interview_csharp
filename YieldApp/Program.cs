using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldApp
{
    class Program
    {
        public static IEnumerable<int> GetTwoInts()
        {
            yield return 1;
            yield return 2;
        }

        static void Main(string[] args)
        {
            var twoInts = GetTwoInts();
        }
    }
}
