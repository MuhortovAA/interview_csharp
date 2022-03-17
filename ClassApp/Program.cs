using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myt = new myTest(1);
            //mySquar sq = new mySquar(20);
            //sq.id = 10;
            //sq.Width = 30;
            //Console.WriteLine(sq.Width);


            Console.ReadLine();
        }
    }

    partial class myBase
    {
        public Person person { get; set; }
        internal int Width { get; set; }
        public myBase()
        {
            Width = 10;
        }
    }
    struct Person
    {

    }
    //    class mySquar : myBase
    //    {
    //        public int id;

    //        //public mySquar()
    //        //{
    //        //    //id = base.Width;
    //        //}
    //        public mySquar(int _id)
    //        {
    //            base.Width = _id;

    //        }
    //}
    class myTest
{
    public int pet;
    public string btr;
    public myTest()
    {
        pet = 2;
        btr = "Hello";
    }
    public myTest(int i) : this("test") => pet = i;

    public myTest(string b) : this() => btr = b;
    public myTest(int i, string b) : this(i)
    {
        btr = "World";
    }




}
}
