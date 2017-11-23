using System;

namespace _06._Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            byte IDcounts = byte.Parse(Console.ReadLine());
            long maxValue = 0;
            long theifID = 0;
            long diff = long.MaxValue;

            for (int i = 0; i < IDcounts; i++)
            {
                if (numeralType == "sbyte")
                {
                    maxValue = sbyte.MaxValue;
                }
                else if (numeralType == "int")
                {
                    maxValue = int.MaxValue;
                }
                else if (numeralType == "long")
                {
                    maxValue = long.MaxValue;
                }

                long ID = long.Parse(Console.ReadLine());

                long currentDiff = Math.Abs((ID - maxValue));

                if (currentDiff < diff)
                {
                    diff = currentDiff;
                    theifID = ID;
                }
            }

            Console.WriteLine(theifID);
        }
    }
}
