using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryYacenko
{
    public class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Substract (double x, double y)
        {
            return y - x;
        }

        public static double Multiply(double x, double y)
        {
            return (x * y);
        }

        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Ошибка: " + new DivideByZeroException("На ноль делить нельзя"));
            }

            return x / y;
        }

        public static double Power(double x, double power)
        {
            return Math.Pow(x, power);
        }
        // 15х14х13х12х11х10х9х7х6х5х4х3х2х1
        public static double Factorial(int n)
        {
            int sum = 1;
            if(n > 0)
            {
                for(int i = 1; i <= n; i++)
                {
                    sum = sum * i; 
                }
            
            }
            return sum;
        }
        public static void SolveQuadratic(double a, double b, double c, out double? x1, out double? x2)
        {
            double discriminant = b * b - 4 * a * c;
            if (a == 0)
            {
                if (b != 0)
                {
                    x1 = -c / b;
                    x2 = null;
                }
                else
                {
                    x1 = null;
                    x2 = null;
                }
                return;
            }
            if (discriminant > 0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            else if (discriminant == 0)
            {
                x1 = -b / (2 * a);
                x2 = null;
            }
            else
            {
                x1 = null;
                x2 = null;
            }
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;
            int j = (int)Math.Sqrt(number);

            for (long i = 2; i <= j; i++) 
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
