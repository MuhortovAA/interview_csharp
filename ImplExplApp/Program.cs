using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplExplApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myA = new A() { Id = 1, Name = "Test" };

            var myB = (B)myA;
            //неявно
            myB = myA;
            //явно
            myA = (A)myB;
            var myC = (B)myA;
            //as
            myB = myC as B;
            myC = myB as C;
            //is
            var resultC = myB is C;
            var resultB = myC is B;
            //

        }
    }
    class A
    {
        public static implicit operator B(A param)
        {
            // логика преобразования
            return new B() { Id = param.Id, Name = param.Name };
        }
        public static explicit operator A(B param)
        {
            // логика преобразования
            return new A() { Id = param.Id, Name = param.Name };
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class B
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class C : B
    {

    }
}
