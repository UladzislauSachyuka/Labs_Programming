using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using static Task2.Program;

namespace Task2_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string expected = "Да";
            string actual = func(5, 5);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            string expected = "Да";
            string actual = func(27, 10);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            string expected = "Да";
            string actual = func(0, 0);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            string expected = "Нет";
            string actual = func(16, 0);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test5()
        {
            string expected = "Нет";
            string actual = func(1, 17);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test6()
        {
            string expected = "Нет";
            string actual = func(19, 4);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test7()
        {
            string expected = "На границе";
            string actual = func(15, 0);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test8()
        {
            string expected = "На границе";
            string actual = func(0, 25);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test9()
        {
            string expected = "На границе";
            string actual = func(-25, 0);
            Assert.Equal(expected, actual);
        }
    }
}