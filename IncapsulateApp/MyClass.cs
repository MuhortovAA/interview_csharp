using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapsulateApp
{
    public class MyClass
    {
        protected int myprotecte { get; set; }
        static int mystatic { get; set; }
        public int mypublic { get; set; }
        static MyClass()
        {
            mystatic = 1;
        }
        public MyClass()
        {
            myprotecte = 1;
        }
    }

    public class DeriveClass : MyClass
    {

    }

}
