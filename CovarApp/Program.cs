using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bear[] bear = new Bear[100];
            Animal[] animal = bear;
            Camel[] camel = new Camel[99];
            animal = camel;
            //--------------------------
            //Stack<Bear> bears = new Stack<Bear>();
            //Stack<Animal> animals = bears; 
            //---------------------------
            Stack<Bear> bears = new Stack<Bear>();
            bears.Push(new Bear());
            IPoppable<Animal> animals = (IPoppable<Animal>)bears;
            

        }
        class Animal { }
        class Bear : Animal { }
        class Camel : Animal { }
        public class Stack<T>
        {
            int position;
            T[] data = new T[100];
            public void Push(T obj) => data[position++] = obj;
            public T Pop() => data[--position];
        }
        public class Stack2<T> : IPoppable<T>
        {
            int position;
            T[] data = new T[100];
            public void Push(T obj) => data[position++] = obj;
            public T Pop() => data[--position];

        }
        public interface IPoppable<out T> { T Pop(); }

    }
}
