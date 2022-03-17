using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            TestyApp.MyProperty = 200;
            TestyApp tt = new TestyApp();

            Console.WriteLine(TestyApp.MyProperty);
            Console.ReadLine();
        }
    }
    class TestyApp
    {
        public static int MyProperty { get; set; }
        static TestyApp()
        {
            MyProperty = 100;
        }
        public TestyApp()
        {
            MyProperty = 300;
        }
    }
}
