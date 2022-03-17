using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesApp
{
    class Program
    {
        private int myproperty;
        public int MyProperty { get { return myproperty; } set { myproperty = value; } }
        [ObsoleteAttribute("This property is obsolete. Use NewProperty instead.", false)]
        public static string OldProperty { get { return "The old property value."; } }
        static void Main(string[] args)
        {

            Console.WriteLine(OldProperty);
            Console.WriteLine("test");


        }
    }
}
