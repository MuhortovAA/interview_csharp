using Microsoft.VisualStudio.TestTools.UnitTesting;
using cTestApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cTestApp.Tests
{
    [TestClass()]
    public class WorkerTests
    {
        [TestMethod()]
        public void SetMessTest()
        {
            Worker worker = new Worker();
            worker.mess = "Hello";

            Assert.AreEqual("Hello", worker.mess);
        }
        [TestMethod()]
        public void GetMessageTest()
        {
            Worker worker = new Worker();
            worker.mess = "Hello";
            var result = worker.GetMessage();
            Assert.AreEqual("Hello 03-02-2022", result);
        }
    }
}