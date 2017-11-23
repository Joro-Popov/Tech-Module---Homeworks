using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
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
    class Distance
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public decimal Dist { get; set; }

        public Distance(Point p1, Point p2, decimal dist)
        {
            Point1 = p1;
            Point2 = p2;
            Dist = dist;
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

            distance = (decimal)Math.Sqrt((sideA * sideA) + (sideB * sideB));

            return distance;
        }

        static void Main(string[] args)
        {
            List<Point> Points = new List<Point>();
            List<Distance> Distances = new List<Distance>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Point point = ReadPoint();
                Points.Add(point);
            }

            for (int i = 0; i <= Points.Count-1; i++)
            {
                Point point1 = Points[i];

                for (int j = 0; j <= Points.Count-1; j++)
                {
                    if (i != j)
                    {
                        Point point2 = Points[j];

                        decimal distance = CalcDistance(point1, point2);

                        Distance dist = new Distance(point1, point2, distance);
                        Distances.Add(dist);
                    }
                }
            }

            Distances = Distances
                .OrderBy(w => w.Dist)
                .Take(1)
                .ToList();

            foreach (var dist in Distances)
            {
                decimal distance = dist.Dist;
                Point point1 = dist.Point1;
                Point point2 = dist.Point2;

                Console.WriteLine($"{distance:f3}");
                Console.WriteLine($"({point1.X}, {point1.Y})");
                Console.WriteLine($"({point2.X}, {point2.Y})");
            }
        }
    }
}
