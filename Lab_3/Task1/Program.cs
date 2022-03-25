using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double x1;
            Console.WriteLine("Введите координату точки а");
            
            while (!double.TryParse(Console.ReadLine(), out x1))
            {
                Console.WriteLine("Неправильный ввод");
            }

            double x2;
            Console.WriteLine("Введите координату точки b");

            while(!double.TryParse(Console.ReadLine(), out x2))
            {
                Console.WriteLine("Неправильный ввод");
            }
            
            Console.WriteLine("Значение функции в точке а = " + Func.f(x1));
            Console.WriteLine("Значение функции в точке b = " + Func.f(x2));

            if (Func.f(x1) < Func.f(x2))
                Console.WriteLine("Функция принимает наименьшее значение в точке а");
            else if (Func.f(x1) > Func.f(x2))
                Console.WriteLine("Функция принимает наименьшее значение в точке b");
            else
                Console.WriteLine("Значения равны");
        }
    }
}
