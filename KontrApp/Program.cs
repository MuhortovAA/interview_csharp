using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace KontrApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<BMW> bmws = new List<BMW> { new BMW() };
            //List<Car> cars = new List<Car>();
            //cars.Add(new Car());
            //cars.Add(new BMW());
            //cars.Add(new Lanos());
            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item.GetType().Name);
            //}
            //Console.Read();
            Hashtable ht = new Hashtable(10);
            ht.Add(new BMW(), new BMW());
            ht.Add(new BMW(), new BMW());
            ht.Add(new BMW(), new BMW());

            ICollection keys = ht.Keys;
            foreach (var s in keys)
                Console.WriteLine(s + ": " + ht[s]);
            Console.Read();

            ////
            ///
            IEnumerable<Car> cars = new List<Car> { new BMW(), new Lanos() };
            //IEnumerable<BMW> bmws = cars;
            //cars.Add(new Car());
            //cars.Add(new BMW());
            //cars.Add(new Lanos());
            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item.GetType().Name);
            //}







            //BMW[]  bmwarr = new BMW[] {new BMW() };
            //Car[] cararr = bmwarr;
            //IEnumerable<Car> cars = bmws;
            //ICollection<Car> carc2 = bmws;
            //IList<Car> carc3 = bmws;
        }
    }
    class Car
    {

    }
    class BMW : Car
    {

    }
    class Lanos : Car
    {

    }
}
