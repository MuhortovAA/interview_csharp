using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            //example.
        }

    }
    public  class Example
    {
        public event Action<int, string, bool> ActionEvent;
        public event Action<int, string, bool> ActionEvent2;
        //public  IObservable<(int, string, bool)> RxActionEvent(this TestConsoleApp.Example obj)
        //{
        //    if (obj == null) throw new ArgumentNullException(nameof(obj));
        //    return Observable.FromEvent<System.Action<int, string, bool>, (int, string, bool)>(
        //    conversion => (obj0, obj1, obj2) => conversion((obj0, obj1, obj2)),
        //    h => obj.ActionEvent += h,
        //    h => obj.ActionEvent -= h);
        //}
    }
}
