using System;

namespace _06._Calculate_Triangle_Area
{
    class Program
    {
        static double GetTriangleArea(double width, double height)
        {
            double area = width * height / 2;
            return area;
        }
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(GetTriangleArea(width,height));
        }
    }
}
