using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapsulateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.mypublic = 1;
            MyClass.mystatic = 2;
        }
    }
}
