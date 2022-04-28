using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Car : Auto
    {
        private static int max_speed = 100;

        public Car()
        {
            Console.WriteLine("Car constructor");
        }
        ~Car()
        {
            Console.WriteLine("Car destructor");
        }
        public override string name()
        {
            return "Car";
        }
        public override int get_speed()
        {
            return max_speed;
        }
        public override void set_speed(int speed)
        {
            max_speed = speed;
        }
    }
}
