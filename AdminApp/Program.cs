using AdminApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new UserRepository();
            repo.Authorization("admin2", "11111111");
        }
    }
}
