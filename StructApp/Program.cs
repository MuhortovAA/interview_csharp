using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var testStruct = new myStruct { MyProperty = "initial value" };
            //var tetstclass = new myClass { MyProperty = "initial value" };

            //ChangeMyStruct(testStruct);
            //ChangeMyClass(tetstclass);
            //Console.WriteLine($"{testStruct.MyProperty}:{tetstclass.MyProperty}");


            var my = new mystclass();

            //mystclass.MyProperty = 10;

            Console.WriteLine($"{mystclass.MyProperty}");
            Console.Read();
        }
        static void ChangeMyStruct(myStruct input)
        {
            input.MyProperty = "new value";
        }
        static void ChangeMyClass(myClass input)
        {
            input.MyProperty = "new value";
        }
    }
    internal struct myStruct : IDisposable
    {

        internal string MyProperty { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class myClass : IDisposable
    {
        public string MyProperty { get; set; }

        public myClass()
        {

        }
        static  myClass()
        {

        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class mystclass
    {
        static public int MyProperty = 0;
        public mystclass()
        {
            //this.MyProperty = 1;
        }
        static mystclass()
        {
            MyProperty = 2;
        }
    }
}
