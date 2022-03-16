using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using static Task1.Program;

namespace Task1_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double expected = 8;
            double actual = func(1, 4, 2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            double expected = 16;
            double actual = func(4, 8, 3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            double expected = 5;
            double actual = func(1, 3, 1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            double expected = 20;
            double actual = func(10, 10, 2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test5()
        {
            double expected = 12;
            double actual = func(1, 4, 1);
            Assert.Equal(expected, actual);
        }
    }
}