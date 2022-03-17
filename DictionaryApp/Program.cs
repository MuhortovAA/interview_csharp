using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<int, string>();
            int result = int.MaxValue;

            for (int i = 0; i < 100000; i++)
            {
                dic.Add(i, $"test - {i}");
            }
            Console.WriteLine(dic[89]);

            //for (int i = 0; i < dic.Count; i++)
            //{
            //    var res = i % 1000;
            //    if (res==0) Console.WriteLine(dic[i]);
            //    //Console.WriteLine(dic[i]);
            //}
            Console.ReadLine();
        }
    }
}
