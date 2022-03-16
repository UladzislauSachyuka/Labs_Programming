using System;

namespace Task1
{
    public class Program
    {
        public static double func(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                double x1, x2;

                Console.WriteLine("Введите a");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите b");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите c");
                double c = double.Parse(Console.ReadLine());

                if (a != 0 && b != 0 && c != 0)
                {
                    double d = func(a, b, c);
                    if (d < 0)
                    {
                        Console.WriteLine("Уравнение не имеет решения");
                    }
                    else if (d == 0)
                    {
                        x1 = -b / (2 * a);
                        Console.WriteLine("Корень уравнения: " + x1);
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - Math.Sqrt(d)) / (2 * a);
                        Console.WriteLine("Корни уравнения: x1 = " + x1 + " x2 = " + x2);
                    }
                }
                else if (a == 0 && b != 0 && c != 0)
                {
                    x1 = -c / b;
                    Console.WriteLine("Корень уравнения: " + x1);
                }
                else if (a != 0 && b == 0 && c != 0)
                {
                    if (-c / a < 0)
                    {
                        Console.WriteLine("Уравнение не имеет решения");
                    }
                    else
                    {
                        x1 = Math.Sqrt(-c / a);
                        x2 = -Math.Sqrt(-c / a);
                        Console.WriteLine("Корни уравнения: x1 = " + x1 + " x2 = " + x2);
                    }
                }
                else if (a != 0 && b != 0 && c == 0)
                {
                    x1 = 0;
                    x2 = -b / a;
                    Console.WriteLine("Корни уравнения: x1 = " + x1 + " x2 = " + x2);
                }
                else if (a != 0 && b == 0 && c == 0)
                {
                    x1 = 0;
                    Console.WriteLine("Корень уравнения: " + x1);
                }
                else if (a == 0 && b != 0 && c == 0)
                {
                    x1 = 0;
                    Console.WriteLine("Корень уравнения: " + x1);
                } 
                else { Console.WriteLine("Уравнение не имеет решения"); }

                Console.WriteLine("1 - продолжить, любая другая кнопка - закончить");

                char n = char.Parse(Console.ReadLine());
                bool flag = false;

                switch(n)
                {
                    case '1': flag = true;
                        break;
                    default:  
                        break;
                }

                if (!flag) break;
            }
        }
    }
}