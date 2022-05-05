using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Equation
    {
        private int a, b, c;

        public int A { get { return a; } set { a = value; } }   
        public int B { get { return b; } set { b = value; } }
        public int C { get { return c; } set { c = value; } }
        public Equation() { }
        public Equation(int _a = 0, int _b = 0, int _c = 0)
        {
            a = _a;
            b = _b;
            c = _c;
        }
        public static Equation operator+(Equation eq, int val)
        {
            eq.C += val;
            return eq;
        }
        public static Equation operator+(Equation eq1, Equation eq2)
        {
            eq1.A += eq2.A;
            eq1.B += eq2.B;
            eq1.C += eq2.C;
            return eq1;
        }
        public static Equation operator-(Equation eq, int val)
        {
            eq.C -= val;
            return eq;
        }
        public static Equation operator-(Equation eq1, Equation eq2)
        {
            eq1.A -= eq2.A;
            eq1.B -= eq2.B;
            eq1.C -= eq2.C;
            return eq1;
        }
        public static Equation operator++(Equation eq)
        {
            eq.C++;
            return eq;
        }
        public static Equation operator--(Equation eq)
        {
            eq.C--;
            return eq;
        }
        public static Equation operator*(Equation eq, int val)
        {
            eq.A *= val;
            eq.B *= val;
            eq.C *= val;
            return eq;
        }
        public static Equation operator/(Equation eq, int val)
        {
            eq.A /= val;
            eq.B /= val;
            eq.C /= val;
            return eq;
        }
        public static explicit operator double(Equation eq)
        {
            return eq.A;
        }
        public static bool operator true(Equation eq)
        {
            return eq.B * eq.B - 4 * eq.A * eq.C >= 0;
        }
        public static bool operator false(Equation eq)
        {
            return eq.B * eq.B - 4 * eq.A * eq.C < 0;
        }
        public static bool operator ==(Equation eq1, Equation eq2)
        {
            return eq1.A == eq2.A && eq1.B == eq2.B && eq1.C == eq2.C;
        }
        public static bool operator !=(Equation eq1, Equation eq2)
        {
            return eq1.A != eq2.A || eq1.B != eq2.B || eq1.C != eq2.C;
        }
        public new string ToString()
        {
            string str = "";
            if (a != 0)
                str += a.ToString() + "x^2";
            if (b != 0)
            {
                if (b > 0)
                    str += "+";
                str += b.ToString() + "x";
            }
            if (c != 0)
            {
                if (c > 0)
                    str += "+";
                str += c.ToString();
            }
            if (str == "")
                str = "0x^2+0x+0";

            str += "=0";
            return str;
        }
        public void solve()
        {
            if (a != 0 && b != 0 && c != 0)
            {
                double d = b * b - 4 * a * c;
                if (d < 0)
                {
                    Console.WriteLine("Уравнение не имеет решения");
                }
                else if (d == 0)
                {
                    double x1 = -b / (2 * a);
                    Console.WriteLine("Корень уравнения: " + x1);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("Корни уравнения: x1 = " + x1 + " x2 = " + x2);
                }
            }
            else if (a == 0 && b != 0 && c != 0)
            {
                double x1 = -c / b;
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
                    double x1 = Math.Sqrt(-c / a);
                    double x2 = -Math.Sqrt(-c / a);
                    Console.WriteLine("Корни уравнения: x1 = " + x1 + " x2 = " + x2);
                }
            }
            else if (a != 0 && b != 0 && c == 0)
            {
                double x1 = 0;
                double x2 = -b / a;
                Console.WriteLine("Корни уравнения: x1 = " + x1 + " x2 = " + x2);
            }
            else if (a != 0 && b == 0 && c == 0)
            {
                double x1 = 0;
                Console.WriteLine("Корень уравнения: " + x1);
            }
            else if (a == 0 && b != 0 && c == 0)
            {
                double x1 = 0;
                Console.WriteLine("Корень уравнения: " + x1);
            }
            else { Console.WriteLine("Уравнение не имеет решения"); }
        }

    }
}
