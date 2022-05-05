using System;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Equation equation = new Equation(1, 2, 1);
            Console.WriteLine(equation.ToString());
            equation.solve();
        }
    }
}