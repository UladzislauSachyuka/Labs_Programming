using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            double z;
            Console.WriteLine("Введите z");

            while (!double.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("Неправильный ввод");
            }

            Func func = new Func();
            func.y(z);
        }
    }
}