using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovariantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransaction<Account> accTransaction = new Transaction<Account>();
            accTransaction.DoOperation(new Account(), 400);

            ITransaction<DepositAccount> depAccTransaction = new Transaction<Account>();
            depAccTransaction.DoOperation(new DepositAccount(), 450);

            Console.Read();
        }
    }
    interface ITransaction<in T>
    {
        void DoOperation(T account, int sum);
    }

    class Transaction<T> : ITransaction<T> where T : Account
    {
        public void DoOperation(T account, int sum)
        {
            account.DoTransfer(sum);
        }
    }
class Account
{
    public virtual void DoTransfer(int sum)
    {
    Console.WriteLine($"Клиент положил на счет {sum} долларов");
    }
}
class DepositAccount : Account
{
    public override void DoTransfer(int sum)
    {
        Console.WriteLine($"Клиент положил на депозитный счет {sum} долларов");
    }
}
}
