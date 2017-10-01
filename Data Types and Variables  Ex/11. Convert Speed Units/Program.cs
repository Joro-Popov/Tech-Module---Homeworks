using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());

            float TimeInHours = float.Parse(Console.ReadLine());
            float TimeInMinutes = float.Parse(Console.ReadLine());
            float TimeInSeconds = float.Parse(Console.ReadLine());

            //Speed in meters per second

            float speedInSeconds = 0f;
            float allTimeInSeconds = (TimeInHours * 60 * 60) + (TimeInMinutes * 60) + TimeInSeconds;
            speedInSeconds = distanceInMeters / allTimeInSeconds;

            //Speed kilometers per hour

            float speedInHours = 0f;
            float allTimeInMinutes = (TimeInHours * 60) + TimeInMinutes + (TimeInSeconds / 60);
            float distancePerMinute = distanceInMeters / (allTimeInMinutes);
            speedInHours = distancePerMinute * 60 / 1000;


            //Speed in miles per hour

            float speedInMiles = 0f;
            float distanceInMiles = distanceInMeters / 1609;
            float allTimeInMinutesM = (TimeInHours * 60) + TimeInMinutes + (TimeInSeconds / 60);
            float distancePerMinuteM = distanceInMiles / (allTimeInMinutes);
            speedInMiles = distancePerMinuteM * 60;

            //Printing results

            Console.WriteLine(speedInSeconds);
            Console.WriteLine(speedInHours);
            Console.WriteLine(speedInMiles);

        }
    }
}
