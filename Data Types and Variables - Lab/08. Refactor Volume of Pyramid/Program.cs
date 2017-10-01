using System;

namespace _08._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigh = double.Parse(Console.ReadLine());

            double volume = (length * width * heigh) / 3;

            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:F2}");

        }
    }
}
