using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            SuperCar superCar = new SuperCar();
            Console.WriteLine(superCar.get_speed());
            superCar.set_speed(399);
            Console.WriteLine(superCar.get_speed());
            Console.WriteLine(superCar.name());

            MAZ maz = new MAZ();
            Console.WriteLine(maz.get_speed());
            maz.set_speed(70);
            Console.WriteLine(maz.get_speed());
            Console.WriteLine(maz.name());
        }
    }
}