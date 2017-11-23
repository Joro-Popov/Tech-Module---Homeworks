using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void PrintClosestPoint(double X1, double Y1, double X2, double Y2)
        {
            if (Math.Abs(X1) <= Math.Abs(X2) && Math.Abs(Y1) <= Math.Abs(Y2))
            {
                Console.WriteLine($"({X1}, {Y1})({X2}, {Y2})");
            }
            else
            {
                Console.WriteLine($"({X2}, {Y2})({X1}, {Y1})");
            }
        }
        static double GetLineLength(double X1, double Y1, double X2, double Y2)
        {
            double length = (Math.Abs(X1) + Math.Abs(X2)) + ((Math.Abs(X1) + Math.Abs(X2)) - (Math.Abs(Y1) + Math.Abs(Y2)));
            return length;
        }
        static void Main(string[] args)
        {
            //Reading first pair of points:
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            // Reading second pair of poins:
            double X3 = double.Parse(Console.ReadLine());
            double Y3 = double.Parse(Console.ReadLine());
            double X4 = double.Parse(Console.ReadLine());
            double Y4 = double.Parse(Console.ReadLine());

            double firstLength = GetLineLength(X1, Y1, X2, Y2);
            double secondLength = GetLineLength(X3, Y3, X4, Y4);

            if (firstLength >= secondLength)
            {
                PrintClosestPoint(X1, Y1, X2, Y2);
            }
            else
            {
                PrintClosestPoint(X3, Y3, X4, Y4);
            }
        }
    }
}
