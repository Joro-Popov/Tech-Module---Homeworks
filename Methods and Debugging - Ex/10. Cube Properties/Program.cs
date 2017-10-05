using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void PrintFace(double cubeSide)
        {
            double faceDiagonal = Math.Sqrt(2 * (cubeSide * cubeSide));
            Console.WriteLine($"{faceDiagonal:f2}");
        }
        static void PrintSpace(double cubeSide)
        {
            double spaceDiagonal = Math.Sqrt(3 * (cubeSide * cubeSide));
            Console.WriteLine($"{spaceDiagonal:f2}");
        }
        static void PrintVolume(double cubeSide)
        {
            double volume = cubeSide * cubeSide * cubeSide;
            Console.WriteLine($"{volume:f2}");
        }
        static void PrintArea(double cubeSide)
        {
            double area = 6 * (cubeSide * cubeSide);
            Console.WriteLine($"{area:f2}");
        }

        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                PrintFace(cubeSide);
            }
            else if (parameter == "space")
            {
                PrintSpace(cubeSide);
            }
            else if (parameter == "volume")
            {
                PrintVolume(cubeSide);
            }
            else if (parameter == "area")
            {
                PrintArea(cubeSide);
            }
        }
    }
}
