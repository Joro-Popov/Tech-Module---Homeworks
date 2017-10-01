using System;

namespace _03._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int waterTank = 255;
            int pouredLiters = 0;

            for (int i = 0; i < num; i++)
            {
                short liters = short.Parse(Console.ReadLine());

                if (liters <= waterTank)
                {
                    waterTank = waterTank - liters;
                    pouredLiters += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(pouredLiters);
        }
    }
}
