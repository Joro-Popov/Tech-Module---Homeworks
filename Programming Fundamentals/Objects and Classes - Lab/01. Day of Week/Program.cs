using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime InputDate = DateTime.ParseExact(Console.ReadLine(),
                "d-M-yyyy", null);
            Console.WriteLine(InputDate.DayOfWeek);
        }
    }
}
