using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new B();
            b.DoSomething();
            var c = new C();
            c.DoSomething();
            A a = b;
            a.DoSomething();
            
            Console.Read();
        }
    }
    abstract class A
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("Class A");
        }
    }
    class B : A
    {
        public override void DoSomething()
        {
            Console.WriteLine("Class B");
        }
    }
    class C:B
    {
        public void DoSomething()
        {
            Console.WriteLine("Class C");
        }
    }
}
