using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myA a = new myB();
            //myB b = new myA();


        }
    }

    class myA {
        public int MyProperty { get; set; }
    }
    class myB : myA { }
}
