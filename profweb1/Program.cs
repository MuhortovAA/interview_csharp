using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profweb1
{
    class Program
    {
        static void Main(string[] args)
        {
            UI user1 = new UI();
            user1.Name = "Alexandr";
            user1[5] = "Dmitryi";
            user1[10] = "Alexey";
            Console.WriteLine(user1[5]);

            Console.ReadLine();
        }
    }
    interface IUserInfo
    {
        string Name
        {
            get;
            set;
        }

        string this[int index]
        {
            get;
            set;
        }
    }

    class UI : IUserInfo
    {
        string myName;

        public string Name
        {
            set
            {
                myName = value;
            }

            get
            {
                return myName;
            }
        }

        public string this[int index]
        {
            set { myName = value; }
            get { return myName; }
        }
    }
}
