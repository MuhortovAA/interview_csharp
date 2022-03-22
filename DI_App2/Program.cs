using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_App2
{
    class Program
    {
        static void Main(string[] args)
        {
            dbWork db1 = new dbWork(new UserMSQL());
            dbWork db2 = new dbWork(new UserOracle());

            db1.ToDo();
            db2.ToDo();
            Console.Read();

        }
    }
    interface Idb
    {
        void ToDo();
        
    }
    class UserMSQL : Idb
    {
        public void ToDo()
        {
            Console.WriteLine("MSQLDB");
        }
    }
    class UserOracle : Idb
    {
        public void ToDo()
        {
            Console.WriteLine("ORACLE");

        }
    }

    class dbWork
    {
        private Idb rep;
        public dbWork(Idb _rep)
        {
            rep = _rep;
        }
        public void ToDo()
        {
            rep.ToDo();
        }
    }

}
