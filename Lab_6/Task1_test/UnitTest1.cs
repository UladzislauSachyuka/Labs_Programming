using Xunit;
using Task1;

namespace Task1_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            SuperCar superCar = new SuperCar();
            Assert.Equal(300, superCar.get_speed());
            Assert.Equal("SuperCar", superCar.name());

            superCar.set_speed(350);
            Assert.Equal(350, superCar.get_speed());

            MAZ maz = new MAZ();
            Assert.Equal(80, maz.get_speed());
            Assert.Equal("MAZ", maz.name());
        }
    }
}