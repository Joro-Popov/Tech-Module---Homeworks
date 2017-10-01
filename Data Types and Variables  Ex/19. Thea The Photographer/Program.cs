using System;

namespace _19._Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPictures = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            double uploadTime = double.Parse(Console.ReadLine());

            double usefullPictures = Math.Ceiling((numberOfPictures * filterFactor)/100.0);
            double totalPicturesTime = numberOfPictures * filterTime;
            double all = (numberOfPictures * filterTime) + (usefullPictures * uploadTime);
            TimeSpan time = TimeSpan.FromSeconds((ulong)all);
            Console.WriteLine($"{time.Days}:{time.Hours:d2}:{time.Minutes:d2}:{time.Seconds:d2}");
      
        }
    }
}
