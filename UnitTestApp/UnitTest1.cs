using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using xUnitApp;

namespace UnitTestApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var check = new Checkdata();
            check.Sum(1, 2);
            Assert.AreEqual(3, 3);
        }
    }
}
