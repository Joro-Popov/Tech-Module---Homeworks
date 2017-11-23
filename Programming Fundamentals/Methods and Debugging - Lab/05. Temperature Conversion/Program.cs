using System;

namespace _05._Temperature_Conversion
{
    class Program
    {
        static double celsius(double farenheit)
        {
            double result = (farenheit - 32) * 5 / 9;
            return result;
        }
        static void Main(string[] args)
        {
            double farenheit = double.Parse(Console.ReadLine());
            Console.WriteLine($"{celsius(farenheit):f2}");
        }
    }
}
