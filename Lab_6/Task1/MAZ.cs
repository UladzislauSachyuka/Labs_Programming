using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    sealed public class MAZ : Auto
    {
        private static int max_speed = 80;
        public MAZ()
        {
            Console.WriteLine("MAZ constructor");
        }
        ~MAZ()
        {
            Console.WriteLine("MAZ destructor");
        }
        public override string name()
        {
            return "MAZ";
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
