using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static long GetVirusStrength(string virus)
        {
            long strength = 0;

            foreach (var letter in virus)
            {
                strength += letter;
            }

            return strength / 3;
        }

        static void Main(string[] args)
        {
            Dictionary<string, long> Viruses = new Dictionary<string, long>();

            long initialHealth = long.Parse(Console.ReadLine());
            long imunneSystemHealth = initialHealth;
            string virus = Console.ReadLine();

            while (virus != "end")
            {
                long virusStrength = GetVirusStrength(virus);
                long timeToDefeatVirusSeconds = virusStrength * virus.Length;
                long minutes = timeToDefeatVirusSeconds / 60;
                long seconds = timeToDefeatVirusSeconds % 60;

                if (!Viruses.ContainsKey(virus))
                {
                    Viruses[virus] = timeToDefeatVirusSeconds;
                }
                else
                {
                    Viruses[virus] = (virusStrength * virus.Length) / 3;
                    minutes = Viruses[virus] / 60;
                    seconds = Viruses[virus] % 60;
                }

                if (imunneSystemHealth > Viruses[virus])
                {
                    imunneSystemHealth = imunneSystemHealth - Viruses[virus];

                    Console.WriteLine($"Virus {virus}: {virusStrength} => {Viruses[virus]} seconds\r\n" +
                        $"{virus} defeated in {minutes}m {seconds}s.\r\n" +
                        $"Remaining health: {imunneSystemHealth}");

                }
                else
                {
                    Console.WriteLine($"Virus {virus}: {virusStrength} => {Viruses[virus]} seconds\r\n" +
                        $"Immune System Defeated.");
                    return;
                }

                long regeneration = (long)(imunneSystemHealth * 0.20);
                imunneSystemHealth += regeneration;

                if (imunneSystemHealth > initialHealth)
                {
                    imunneSystemHealth = initialHealth;
                }

                virus = Console.ReadLine();
            }

            Console.WriteLine($"Final Health: {imunneSystemHealth}");
        }
    }
}
