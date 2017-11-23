using System;

namespace _04._Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());
            decimal priceAfterDiscount = 0;

            decimal studioPrice = 0;
            decimal doublePrice = 0;
            decimal suitePrice = 0;

            if (month == "May")
            {
                //Studio 
                if (nightCount > 7)
                {
                    priceAfterDiscount = 50 - (50 * 0.05m);
                    studioPrice = nightCount * priceAfterDiscount;
                }
                else
                {
                    studioPrice = nightCount * 50;
                }

                //Double
                doublePrice = nightCount * 65;

                //Suite
                suitePrice = nightCount * 75;
            }
            else if (month == "October")
            {
                //Studio
                if (nightCount > 7)
                {
                    priceAfterDiscount = 50 - (50 * 0.05m);
                    studioPrice = (nightCount * priceAfterDiscount) - 50; ;
                }
                else
                {
                    studioPrice = nightCount * 50;
                }

                //Double
                doublePrice = nightCount * 65;

                //Suite
                suitePrice = nightCount * 75;
            }
            else if (month == "June")
            {
                //Studio
                studioPrice = nightCount * 60;

                //Double
                if (nightCount > 14)
                {
                    priceAfterDiscount = 72 - (72 * 0.10m);
                    doublePrice = nightCount * priceAfterDiscount;
                }
                else
                {
                    doublePrice = nightCount * 72;
                }
                //Suite
                suitePrice = nightCount * 82;
            }
            else if (month == "September")
            {
                //Studio
                if (nightCount > 7)
                {
                    studioPrice = (nightCount * 60) - 60;
                }
                else
                {
                    studioPrice = nightCount * 60;
                }

                //Double
                if (nightCount > 14)
                {
                    priceAfterDiscount = 72 - (72 * 0.10m);
                    doublePrice = nightCount * priceAfterDiscount;
                }
                else
                {
                    doublePrice = nightCount * 72;
                }

                //Suite
                suitePrice = nightCount * 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                //Studio
                studioPrice = nightCount * 68;

                //Double
                doublePrice = nightCount * 77;

                //Suite
                if (nightCount > 14)
                {
                    priceAfterDiscount = 89 - (89 * 0.15m);
                    suitePrice = nightCount * priceAfterDiscount;
                }
                else
                {
                    suitePrice = nightCount * 89;
                }
            }

            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}
