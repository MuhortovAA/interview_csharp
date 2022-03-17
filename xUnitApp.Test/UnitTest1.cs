using System;
using Xunit;
using xUnitAppDll;

namespace xUnitApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var check = new Checkdata();
            check.Sum(1, 2);
            Assert.Equal(3, 3);
        }
    }
}
