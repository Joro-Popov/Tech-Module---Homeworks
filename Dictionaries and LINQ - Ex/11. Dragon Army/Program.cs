using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Status
    {
        public int damage { get; set; }
        public int health { get; set; }
        public int armor { get; set; }

        public Status(int Damage, int Health, int Armor)
        {
            damage = Damage;
            health = Health;
            armor = Armor;
        }
    }
    class Program
    {
        static void GetAverageStats(ref double averageDamage, ref double averageHealth, ref double averageArmor, Dictionary<string, Status> status)
        {
            foreach (var stat in status)
            {
                Status Current = stat.Value;

                averageDamage += Current.damage;
                averageHealth += Current.health;
                averageArmor += Current.armor;
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,Status>> Dragons =
            new Dictionary<string,Dictionary<string,Status>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                List<string> DragonInfo = Console.ReadLine().Split(' ').ToList();

                string type = DragonInfo[0];
                string name = DragonInfo[1];
                int damage = 0;
                int health = 0;
                int armor = 0;

                if (DragonInfo[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(DragonInfo[2]);
                }
                if (DragonInfo[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(DragonInfo[3]);
                }
                if (DragonInfo[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(DragonInfo[4]);
                }

                Status currentStatus = new Status(damage, health, armor);

                if (!Dragons.ContainsKey(type))
                {
                    Dragons[type] = new Dictionary<string, Status>();
                }
                Dragons[type][name] = currentStatus;
            }

            double averageDamage = 0;
            double averageHealth = 0;
            double averageArmor = 0;

            foreach (var Type in Dragons)
            {
                string type = Type.Key;
                Dictionary<string, Status> status = Type.Value;

                GetAverageStats(ref averageDamage, ref averageHealth, ref averageArmor, status);

                Console.WriteLine($"{type}::({(averageDamage/status.Keys.Count):f2}/{(averageHealth/status.Keys.Count):f2}/{(averageArmor/status.Keys.Count):f2})");

                foreach (var stat in status.OrderBy(w => w.Key))
                {
                    string name = stat.Key;
                    Status currentStatus = stat.Value;

                    Console.WriteLine($"-{name} -> damage: {currentStatus.damage}, health: {currentStatus.health}, armor: {currentStatus.armor}");
                }

                 averageDamage = 0;
                 averageHealth = 0;
                 averageArmor = 0;
            }
        }

       
    }
}
