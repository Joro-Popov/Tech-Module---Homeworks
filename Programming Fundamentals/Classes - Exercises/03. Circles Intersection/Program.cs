using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }
    }
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
        static Circle ReadCircle()
        {
            List<int> Tokens = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int x = Tokens[0];
            int y = Tokens[1];
            int radius = Tokens[2];

            Point center = new Point(x, y);
            Circle circle = new Circle(center, radius);

            return circle;
        }
        static int CalcDistance(Point point1, Point point2)
        {
            int distance = 0;

            int sideA = Math.Abs(point1.X - point2.X);
            int sideB = Math.Abs(point1.Y - point2.Y);

            distance = (int)Math.Sqrt((sideA * sideA) + (sideB * sideB));

            return distance;
        }
        static bool Intersect(Circle Circle1, Circle Circle2)
        {
            bool intersect = false;

            int distance = CalcDistance(Circle1.Center, Circle2.Center);

            if (distance <= (Circle1.Radius + Circle2.Radius))
            {
                intersect = true;
            }

            return intersect;
        }

        static void Main(string[] args)
        {
            Circle Circle1 = ReadCircle();
            Circle Circle2 = ReadCircle();

            if (Intersect(Circle1,Circle2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
