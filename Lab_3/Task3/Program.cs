using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateService.GetDay("24.03.2022"));

            int day, month, year, day1, month1, year1;
            while (!int.TryParse(Console.ReadLine(), out day) || day > 31) 
                Console.WriteLine("Неправильный ввод");
            while (!int.TryParse(Console.ReadLine(), out month) || month > 12)
                Console.WriteLine("Неправильный ввод");
            while (!int.TryParse(Console.ReadLine(), out year) || year > 9999)
                Console.WriteLine("Неправильный ввод");
            while (!int.TryParse(Console.ReadLine(), out day1) || day1 > 31)
                Console.WriteLine("Неправильный ввод");
            while (!int.TryParse(Console.ReadLine(), out month1) || month1 > 12)
                Console.WriteLine("Неправильный ввод");
            while (!int.TryParse(Console.ReadLine(), out year1) || year1 > 9999)
                Console.WriteLine("Неправильный ввод");


            Console.WriteLine(DateService.GetDaysSpan(day, month, year, day1, month1, year1));
        }
    }
}