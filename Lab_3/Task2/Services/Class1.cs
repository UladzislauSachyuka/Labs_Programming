using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Func
    {
        public void y(double z)
        {
            double x, y;
            if (z < -1)
            {
                x = -z / 3;
                y = Math.Log(x + 0, 5) + (Math.Exp(x) - Math.Exp(-x));
                Console.WriteLine("y = " + y);
                Console.WriteLine("Вычисление производилось по первой ветке");
            }
            else if (z >= -1)
            {
                x = Math.Abs(z);
                y = Math.Log(x + 0, 5) + (Math.Exp(x) - Math.Exp(-x));
                Console.WriteLine("y = " + y);
                Console.WriteLine("Вычисление производилось по второй ветке");
            }
        }
    }
}
