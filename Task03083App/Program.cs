using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task03083App
{
    class Program
    {
        static void Main(string[] args)
        {

            SomeFoo();
            Console.WriteLine("Finished...");
        }

        static void SomeFoo()
        {
            var result = new MyClass();
            result.Foo();
        }


    }
}
