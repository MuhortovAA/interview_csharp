using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<myClass> my = new ObservableCollection<myClass>();
            int[] numbers = { 1, 2, 3, 4, 5 };
            var result = numbers.Where(i => i > 3);
            IQueryable<int> coll = numbers.AsQueryable();

            numbers[2] = numbers[2] + 3;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            numbers[2] = numbers[2] - 3;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }



        class myClass : IQueryable
        {
            public Expression Expression => throw new NotImplementedException();

            public Type ElementType => throw new NotImplementedException();

            public IQueryProvider Provider => throw new NotImplementedException();

            public System.Collections.IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
}
