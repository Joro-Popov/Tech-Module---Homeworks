using System;

namespace _07._Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            byte IDcounts = byte.Parse(Console.ReadLine());
            long maxValue = 0;
            long currentDff = long.MaxValue;

            if (numeralType == "sbyte")
            {
                maxValue = sbyte.MaxValue;
            }

            if (numeralType == "int")
            {
                maxValue = int.MaxValue;
            }

            if (numeralType == "long")
            {
                maxValue = long.MaxValue;
            }

            long TheifID = 0;

            for (int i = 0; i < IDcounts; i++)
            {
                long currentID = long.Parse(Console.ReadLine());

                if (Math.Abs(currentID - maxValue) < currentDff && currentID <= maxValue)
                {
                    currentDff = Math.Abs(currentID - maxValue);
                    TheifID = currentID;
                }
            }

            Console.WriteLine(TheifID);
        }
    }
}
