using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3App
{
    class Program
    {
        static void Main(string[] args)
        {

            B b = new B() { uselocalTime = false };
            try
            {

                var result = b.GetTime();
                Console.WriteLine(result.Result);

                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    class B
    {

        public bool uselocalTime = true;
        public IServerTimeProvider timeProvider = new A();
        public void Do()
        {

        }

        public string GetResult() => uselocalTime ? "true" : "false";
        //public Task<DateTime> GetTime() => !this.uselocalTime ? Task.FromResult<DateTime>(DateTime.Now) : Task.Run<DateTime>(async () => { return await this.timeProvider.Get(); });
        public async Task<DateTime> GetTime() => this.uselocalTime ? await Task.FromResult<DateTime>(DateTime.Now) : await this.timeProvider.Get();

        //public Task<DateTime> Get()
        //{
        //    return Task.FromResult<DateTime>(DateTime.Now);
        //}
        //Task<DateTime> GetTime() => this.useloaclTime ? DateTime.Now : await this.timeProvider.Get();

        //Task<DateTime> GetTime() => this.useloaclTime ? DateTime.Now : DateTime.Now;

    }

    class A : IServerTimeProvider
    {
        public Task<DateTime> Get()
        {
            return Task.FromResult<DateTime>(DateTime.Now);
        }
    }

    interface IServerTimeProvider
    {
        Task<DateTime> Get();
    }
}
