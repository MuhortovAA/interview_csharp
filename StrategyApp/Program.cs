using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp
{
    class Program
    {
        private static bool result;

        static void Main(string[] args)
        {
            result = true;
            myStrategy strategy = new myStrategy();
            switch (result)
            {
                case true:
                    strategy.Do(new ExecuteA());
                    break;
                case false:
                    strategy.Do(new ExecuteB());
                    break;
            }
        }
    }
}
