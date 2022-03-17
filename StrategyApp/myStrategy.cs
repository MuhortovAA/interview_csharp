using System;

namespace StrategyApp
{
    internal class myStrategy
    {
        public myStrategy()
        {
        }

        internal void Do(IJob job)
        {
            job.ToDoJob();
        }
    }
}