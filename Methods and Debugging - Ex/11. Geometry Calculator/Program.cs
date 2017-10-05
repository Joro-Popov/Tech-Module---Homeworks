using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void PrintTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = (side * height) / 2;

            Console.WriteLine($"{Math.Round(area,2)}");
        }
        static void PrintSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;

            Console.WriteLine($"{Math.Round(area,2)}");
        }
        static void PrintRectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;

            Console.WriteLine($"{Math.Round(area,2)}");
        }
        static void PrintCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * (radius * radius);

            Console.WriteLine($"{Math.Round(area,2)}");
        }

        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "triangle")
            {
                PrintTriangleArea();
            }
            else if (figureType == "square")
            {
                PrintSquareArea();
            }
            else if (figureType == "rectangle")
            {
                PrintRectangleArea();
            }
            else if (figureType == "circle")
            {
                PrintCircleArea();
            }
        }
    }
}
