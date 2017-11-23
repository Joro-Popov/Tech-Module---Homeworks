using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Working_Days
{
    class Program
    {
        static bool IsNotWorkDay(DateTime currentDate)
        {
            DateTime[] holidays = new DateTime[11];
           
            holidays[0] = DateTime.ParseExact("01-01-2016","dd-MM-yyyy",null);
            holidays[1] = DateTime.ParseExact("03-03-2016","dd-MM-yyyy",null);
            holidays[2] = DateTime.ParseExact("01-05-2016","dd-MM-yyyy",null);
            holidays[3] = DateTime.ParseExact("06-05-2016","dd-MM-yyyy",null);
            holidays[4] = DateTime.ParseExact("24-05-2016","dd-MM-yyyy",null);
            holidays[5] = DateTime.ParseExact("06-09-2016","dd-MM-yyyy",null);
            holidays[6] = DateTime.ParseExact("22-09-2016","dd-MM-yyyy",null);
            holidays[7] = DateTime.ParseExact("01-11-2016","dd-MM-yyyy",null);
            holidays[8] = DateTime.ParseExact("24-12-2016","dd-MM-yyyy",null);
            holidays[9] = DateTime.ParseExact("25-12-2016","dd-MM-yyyy",null);
            holidays[10] = DateTime.ParseExact("26-12-2016", "dd-MM-yyyy", null);

            bool IsNotWorkDay = true;

            if (holidays.Any(d => d.Month == currentDate.Month && d.Day == currentDate.Day) || currentDate.DayOfWeek.ToString() == "Saturday" || currentDate.DayOfWeek.ToString() == "Sunday")
            {
                IsNotWorkDay = false;
                
            }
            return IsNotWorkDay;
        }
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

            DateTime secondDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

            int workDays = 0;

            for (DateTime i = firstDate; i <= secondDate; i = i.AddDays(1))
            {
                DateTime currentDate = i;

                if (IsNotWorkDay(currentDate))
                {
                    workDays++;
                }
            }

            Console.WriteLine(workDays);
        }
    }
}
