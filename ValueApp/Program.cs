using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle("First", 10);
            Rectangle r2 = r1;

            r2.RectInfo.InfoString = "This is new info";
            r2.RectInfo = new ShapeInfo("This is my info");
            r2.RectTop = 20;
            r1.Display();
            r2.Display();
            Console.Read();
        }
    }
    class ShapeInfo
    {
        public string InfoString;

        public ShapeInfo(string info)
        {
            InfoString = info;
        }
    }
    struct Rectangle
    {
        public ShapeInfo RectInfo;
        public int RectTop;
        public Rectangle(string info, int top)
        {
            RectInfo = new ShapeInfo(info);
            RectTop = top;
        }
        public void Display()
        {
            Console.WriteLine($"String: {RectInfo.InfoString}, int: {RectTop}");
        }
    }
}
