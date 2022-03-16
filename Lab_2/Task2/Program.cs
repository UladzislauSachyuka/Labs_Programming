using System;

namespace Task2
{
    public class Program
    {
        public static string func(double x, double y)
        {
            string answer1 = "Да", answer2 = "Нет", answer3 = "На границе";
            if (Math.Sqrt(x * x + y * y) < 15 || Math.Sqrt(x * x + y * y) > 25)
            {
                return answer1;
            }
            else if (Math.Sqrt(x * x + y * y) == 15 || Math.Sqrt(x * x + y * y) == 25)
            {
                return answer3;
            }
            else
            {
                return answer2;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите х");
                double x = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите у");
                double y = double.Parse(Console.ReadLine());

                Console.WriteLine(func(x, y));

                Console.WriteLine("1 - продолжить, любая другая кнопка - закончить");
                char ch = char.Parse(Console.ReadLine());
                bool flag = false;

                switch(ch)
                {
                    case '1':
                        flag = true;
                        break;
                    default:
                        break;
                }

                if (!flag) break;
            }
        }
    }
}