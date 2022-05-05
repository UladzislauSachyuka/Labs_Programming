using Xunit;
using Task1;

namespace Task1_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Equation equation1 = new Equation(1, 2, 1);
            Equation equation2 = new Equation(1, 2, 1);
            Assert.True(equation1 == equation2);
        }

        [Fact]
        public void Test2()
        {
            Equation equation1 = new Equation(4, 7, 2);
            Equation equation2 = new Equation(3, 2, 1);
            Assert.False(equation1 == equation2);
        }
    }
}