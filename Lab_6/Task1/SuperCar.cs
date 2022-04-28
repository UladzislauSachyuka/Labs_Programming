using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SuperCar : Car
    {
        private static int max_speed = 300;
        public SuperCar()
        {
            Console.WriteLine("SuperCar constructor");
        }
        ~SuperCar()
        {
            Console.WriteLine("SuperCar destructor");
        }
        public override string name()
        {
            return "SuperCar";
        }
        public new int get_speed()
        {
            return max_speed;
        }
        public override void set_speed(int speed)
        {
            max_speed = speed;
        }
    }
}
