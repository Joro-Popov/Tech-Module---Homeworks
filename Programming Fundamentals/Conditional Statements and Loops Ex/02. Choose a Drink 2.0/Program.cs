using System;

namespace _02._Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            string drink = string.Empty;
            decimal sum = 0;

            if (profession == "Athlete")
            {
                drink = "Water";
                sum = quantity * 0.70m;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
                sum = quantity * 1.00m;
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
                sum = quantity * 1.70m;
            }
            else
            {
                drink = "Tea";
                sum = quantity * 1.20m;
            }

            Console.WriteLine($"The {profession} has to pay {sum:f2}.");
        }
    }
}
