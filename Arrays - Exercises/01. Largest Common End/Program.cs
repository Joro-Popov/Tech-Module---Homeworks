using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstList = Console.ReadLine().Split(' ').ToList();
            List<string> secondList = Console.ReadLine().Split(' ').ToList();

            int cntLeft = 0;
            int cntRight = 0;

            if (firstList.Count <= secondList.Count)
            {
                //Scan from Left to Right
                for (int i = 0; i < firstList.Count; i++)
                {
                    if (firstList[i] == secondList[i])
                    {
                        cntLeft++;
                    }
                    else
                    {
                        break;
                    }
                }
                //Scan from Right to Left
                for (int i = 0; i < firstList.Count; i++)
                {
                    if (firstList[firstList.Count-1-i] == secondList[secondList.Count-1-i])
                    {
                        cntRight++;
                    }
                }
                //Print result
                if (cntLeft >= cntRight)
                {
                    Console.WriteLine(cntLeft);
                }
                else
                {
                    Console.WriteLine(cntRight);
                }
            }
            else
            {
                //Scan from Left to Right
                for (int i = 0; i < secondList.Count; i++)
                {
                    if (secondList[i] == firstList[i])
                    {
                        cntLeft++;
                    }
                    else
                    {
                        break;
                    }
                }
                //Scan from Right to Left
                for (int i = 0; i < secondList.Count; i++)
                {
                    if (secondList[secondList.Count-1-i] == firstList[firstList.Count-1-i])
                    {
                        cntRight++;
                    }
                }
                //Print result
                if (cntLeft >= cntRight)
                {
                    Console.WriteLine(cntLeft);
                }
                else
                {
                    Console.WriteLine(cntRight);
                }
            }
        }
    }
}
