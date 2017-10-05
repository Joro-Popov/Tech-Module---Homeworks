using System;

namespace _07._Math_Power
{
    class Program
    {
        static double RaiseToPower(double num1,double num2)
        {
            double result = Math.Pow(num1, num2);
            return result;
        }
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(num1,num2));
        }
    }
}
