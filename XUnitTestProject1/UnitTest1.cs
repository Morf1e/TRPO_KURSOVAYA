using System;
using Xunit;
using Курсовая_ТРПО;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int x = 10;
            double y = 100;
            double exp = 10;
            SrVes c = new SrVes();
            double a = c.Sr(x, y);
            Assert.Equal(exp, a);
        }
    }
}
