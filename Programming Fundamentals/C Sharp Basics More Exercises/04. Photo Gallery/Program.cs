using System;

namespace _04._Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            decimal photoSize = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heigh = int.Parse(Console.ReadLine());

            
            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");

            if (photoSize < 1000)
            {
                Console.WriteLine($"Size: {photoSize}B");
            }
            else if (photoSize >= 1000 && photoSize < 1000000)
            {
                photoSize = photoSize / 1000;
                Console.WriteLine($"Size: {photoSize}KB");
            }
           
            else if (photoSize >= 100000)
            {
                photoSize = photoSize / 1000000;
                Console.WriteLine($"Size: {photoSize}MB");
            }

            if (width > heigh)
            {
                Console.WriteLine($"Resolution: {width}x{heigh} (landscape)");
            }
            else if (width < heigh)
            {
                Console.WriteLine($"Resolution: {width}x{heigh} (portrait)");
            }
            else if (width == heigh)
            {
                Console.WriteLine($"Resolution: {width}x{heigh} (square)");
            }
        }
    }
}
