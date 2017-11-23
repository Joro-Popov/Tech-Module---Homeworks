using System;

namespace _03._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = string.Empty;
            decimal hallPrice = 0;
            decimal totalPrice = 0;
            decimal pricePerPerson = 0;
            decimal priceAfterDiscount = 0;

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                hallPrice = 2500;

                if (package == "Normal")
                {
                    totalPrice = hallPrice + 500;
                    priceAfterDiscount = totalPrice - (totalPrice * 0.05m);
                    pricePerPerson = priceAfterDiscount / groupSize;
                }
                else if (package == "Gold")
                {
                    totalPrice = hallPrice + 750;
                    priceAfterDiscount = totalPrice - (totalPrice * 0.10m);
                    pricePerPerson = priceAfterDiscount / groupSize;
                }
                else if (package == "Platinum")
                {
                    totalPrice = hallPrice + 1000;
                    priceAfterDiscount = totalPrice - (totalPrice * 0.15m);
                    pricePerPerson = priceAfterDiscount / groupSize;
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                hallPrice = 5000;

                if (package == "Normal")
                {
                    totalPrice = hallPrice + 500;
                    priceAfterDiscount = totalPrice - (totalPrice * 0.05m);
                    pricePerPerson = priceAfterDiscount / groupSize;
                }
                else if (package == "Gold")
                {
                    totalPrice = hallPrice + 750;
                    priceAfterDiscount = totalPrice - (totalPrice * 0.10m);
                    pricePerPerson = priceAfterDiscount / groupSize;
                }
                else if (package == "Platinum")
                {
                    totalPrice = hallPrice + 1000;
                    priceAfterDiscount = totalPrice - (totalPrice * 0.15m);
                    pricePerPerson = priceAfterDiscount / groupSize;
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                hallPrice = 7500;

                if (package == "Normal")
                {
                    totalPrice = hallPrice + 500;
                    priceAfterDiscount = totalPrice - (totalPrice * 0.05m);
                    pricePerPerson = priceAfterDiscount / groupSize;
                }
                else if (package == "Gold")
                {
                    totalPrice = hallPrice + 750;
                    priceAfterDiscount = totalPrice - (totalPrice * 0.10m);
                    pricePerPerson = priceAfterDiscount / groupSize;
                }
                else if (package == "Platinum")
                {
                    totalPrice = hallPrice + 1000;
                    priceAfterDiscount = totalPrice - (totalPrice * 0.15m);
                    pricePerPerson = priceAfterDiscount / groupSize;
                }
            }
            else
            {
                Console.WriteLine($"We do not have an appropriate hall.");
                return;
            }

            Console.WriteLine($"We can offer you the {hall}\r\nThe price per person is {pricePerPerson:f2}$");
        }
    }
}
