using System;

namespace ConsoleApp_калькулятор_Туленцева
{
    public class Calculator
    {
        public double Plus(double a, double b)
        {
            double result = a + b;
            return result;
        }
        public double Minus(double a, double b)
        {
            double result = a - b;
            return result;
        }
        public double Multiplication(double a, double b)
        {
            double result = a * b;
            return result;
        }
        public double Divide(double a, double b)
        {
            double result = a / b;
            return result;
        }

        public double TriangleSquare(double a, double h)
        {
            double result = 0.5d * a * h;
            return result;
        }

        public double RoundSquare(double r)
        {

            double result = Math.PI * r * r;
            return result;
        }

        public double Average(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        //public double Average(double[] array)
        //{
        //    double sum = array.Sum();
        //    return sum / array.Length;
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double res = calc.Plus(1, 6);
            Console.WriteLine($"Результат: {res}");
        }
    }
}