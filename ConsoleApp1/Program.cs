using ConsoleApp1.Util;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;

namespace ConsoleApp1
{
    class B
    {
        public void Process(string message)
        {
            message = "message";
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            string messager = new string(new char[] { 'a', 'b', 'c' });
            string messager2 = String.Copy(messager);

            Console.WriteLine(object.ReferenceEquals(messager, messager2));
            String.Intern(messager2.ToString());
            Console.WriteLine(object.ReferenceEquals(String.Intern(messager), String.Intern(messager2)));
            Console.WriteLine(string.Join("  ", messager));
            Console.ReadLine();
        }

    }
}
