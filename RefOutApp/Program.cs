using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutApp
{
    class Program
    {
        static void Main(string[] args)
        {
            myNextClass mn = new myNextClass() { Name = "1" };
            myClass mc = new myClass();
            mc.Get(out mn);
            Console.WriteLine(mn.Name);
            Console.ReadLine();
        }
    }

    class myClass
    {
        public void Get(out myNextClass mn)
        {
            mn = new myNextClass() { Name = "3" };
            mn.Name = "2";
        }
    }
    class myNextClass
    {
        public string Name { get; set; }
    }
}
