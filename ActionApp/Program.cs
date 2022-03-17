using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myint = new int[] { 1, 2, 3, 4, 5 };
            var mystr = new string[] { "1", "2" };
            
            List<string> Geek = new List<string>();
            Geek.Add("ABCD");
            Geek.Add("QRST");
            Geek.Add("XYZ");
            Geek.Add("IJKL");
            Geek.Sort();
            //int index = Geek.BinarySearch("EFGH");
            int index = Geek.BinarySearch("X");
            if (index < 0)
            {

                Geek.Insert(~index, "EFGH");
            }



            var c1 = new myClass();
            c1.Evt += (msg) =>
            {
                Console.WriteLine(1);
                Console.WriteLine(2);
            };
        }
    }
    class myClass
    {
        public event Action<string> Evt;
    }
    abstract class myClass2 : myClass
    {

    }
}
