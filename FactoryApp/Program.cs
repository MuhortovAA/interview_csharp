using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>();
            CreatorA ca = new CreatorA();
            var pa = ca.FactoryMethod();
            products.Add(pa);
            CreatorB cb = new CreatorB();
            var pb = cb.FactoryMethod();
            products.Add(pb);

        }
    }
    //товары
    abstract class Product { }
    class ProductA : Product { }
    class ProductB : Product { }
    // производство
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
    class CreatorA : Creator
    {
        public override Product FactoryMethod() => new ProductA();
    }
    class CreatorB : Creator
    {
        public override Product FactoryMethod() => new ProductB();
    }
}
