using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{

    public class myBase
    {

        internal int Width { get; set; }
        public myBase()
        {
            Width = 10;
        }
    }

    public class mySquar : myBase
    {
        public int id;

        //public mySquar()
        //{
        //    //id = base.Width;
        //}
        public mySquar(int _id)
        {
            base.Width = _id;

        }
    }
}
