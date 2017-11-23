using System;

namespace _15._Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDamage = int.Parse(Console.ReadLine());
            int GoshoDamage = int.Parse(Console.ReadLine());

            int PeshoHealth = 100;
            int GoshoHealth = 100;
            int rounds = 0;

            for (int i = 1; i <= 100; i++)
            {
                rounds ++;

                if (i % 2 == 1)
                {
                    if (GoshoHealth > PeshoDamage)
                    {
                        GoshoHealth = GoshoHealth - PeshoDamage;
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Pesho won in {rounds}th round.");
                        return;
                    }
                }
                else if (i % 2 == 0)
                {
                    if (PeshoHealth > GoshoDamage)
                    {
                        PeshoHealth = PeshoHealth - GoshoDamage;
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Gosho won in {rounds}th round.");
                        return;
                    }
                }
                if (rounds % 3 == 0)
                {
                    PeshoHealth += 10;
                    GoshoHealth += 10;
                }
            }
        }
    }
}
