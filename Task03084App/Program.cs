using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task03084App
{
    class Program
    {
        static void Main(string[] args)
        {
            var state = new StateObject();
            for (int i = 0; i < 20; i++)
                new Task(new SampleThread().RaceCondition, state).Start();
            Thread.Sleep(1000);
        }
        public class StateObject
        {
            private int state = 7;
            public void ChangeState(int loop)
            {
                if (state == 7)
                {
                    state++;
                    Trace.Assert(state == 8, "Состязание за ресурсы возникло после " + loop + " циклов");
                    if (state == 8)
                    {
                        Console.WriteLine("Состязание за ресурсы возникло после " + loop + " циклов");
                        Console.ReadLine();
                    }

                }
                state = 7;
            }
        }

        public class SampleThread
        {
            public void RaceCondition(object obj)
            {
                Trace.Assert(obj is StateObject, "obj должен иметь тип StateObject");
                StateObject state = obj as StateObject;
                int i = 0;
                while (true)
                    state.ChangeState(i++);
            }
        }

    }
}
