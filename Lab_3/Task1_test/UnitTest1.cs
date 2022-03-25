using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using static Task1.Func;

namespace Task1_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double expected = 0;
            double actual = f(System.Math.PI / 2);
            Assert.Equal(expected, actual, 1);
        }

        [Fact]
        public void Test2()
        {
            double expected = -1;
            double actual = f(System.Math.PI);
            Assert.Equal(expected, actual, 1);
        }

        [Fact]
        public void Test3()
        {
            double expected = 1;
            double actual = f(2 * System.Math.PI);
            Assert.Equal(expected, actual, 1);
        }

        [Fact]
        public void Test4()
        {
            double expected = -1;
            double actual = f(3 * System.Math.PI);
            Assert.Equal(expected, actual, 1);
        }

        [Fact]
        public void Test5()
        {
            double expected = 1;
            double actual = f(0);
            Assert.Equal(expected, actual, 1);
        }


    }
}