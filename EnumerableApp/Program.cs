﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<BMW> bmwl = new List<BMW> { new BMW() };
            IEnumerable<Car> carl = bmwl;
        }
    }
    class Car { }
    class BMW : Car
    {

    }
    class Lanos : Car
    {

    }
}
