using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Airport airport = new Airport();
            airport.create("sdf", 300, 200, 150);

            Console.WriteLine(airport.getName());

            airport.increase_price(30);
            Console.WriteLine(airport.getPrice());

            
        }
    }
}
