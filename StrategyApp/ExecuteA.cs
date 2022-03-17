namespace StrategyApp
{
    internal class ExecuteA:IJob
    {


        public void ToDoJob()
        {
            System.Console.WriteLine("ExecuteA");
        }
    }
    internal class ExecuteB : IJob
    {

        public void ToDoJob()
        {
            System.Console.WriteLine("ExecuteB");

        }
    }
}