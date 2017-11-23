using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void PrintDayName(int day)
        {
            string[] weekDays =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine(weekDays[day-1]);
        }
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                PrintDayName(day);
            }
        }
    }
}
