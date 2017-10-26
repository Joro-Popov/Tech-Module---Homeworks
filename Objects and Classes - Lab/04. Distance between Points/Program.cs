using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

    }
    class Program
    {
        static Point ReadPoint()
        {
            List<int> coordinates = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int X = coordinates[0];
            int Y = coordinates[1];

            Point point = new Point(X, Y);

            return point;
        }

        static decimal CalcDistance(Point point1, Point point2)
        {
            decimal distance = 0;

            int sideA = Math.Abs(point1.X - point2.X);
            int sideB = Math.Abs(point1.Y - point2.Y);

            distance = (decimal)Math.Sqrt((sideA*sideA) + (sideB * sideB));

            return distance;
        }

        static void Main(string[] args)
        {
            Point point1 = ReadPoint();
            Point point2 = ReadPoint();

            decimal distance = CalcDistance(point1, point2);

            Console.WriteLine($"{distance:f3}");
        }
    }
}
