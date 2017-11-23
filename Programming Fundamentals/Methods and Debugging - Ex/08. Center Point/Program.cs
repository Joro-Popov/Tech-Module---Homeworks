using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void PrintClosestPoint(double X1, double Y1, double X2, double Y2)
        {
            if (Math.Abs(X1) <= Math.Abs(X2) && Math.Abs(Y1) <= Math.Abs(Y2))
            {
                Console.WriteLine($"({X1}, {Y1})");
            }
            else
            {
                Console.WriteLine($"({X2}, {Y2})");
            }
        }
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            PrintClosestPoint(X1, Y1, X2, Y2);
        }
    }
}
