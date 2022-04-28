using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract public class Auto
    {
        private int max_speed;

        public Auto()
        {
            Console.WriteLine("Auto constructor");
        }

        ~Auto()
        {
            Console.WriteLine("Auto destructor");
        }
        abstract public string name();
        public virtual int get_speed()
        {
            return 1;
        }

        public virtual void set_speed(int speed)
        {
            max_speed = speed;
        }
    }
}
