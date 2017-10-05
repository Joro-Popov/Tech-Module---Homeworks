using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static bool IsSymetric(int num)
        {
            string numbers = num.ToString();
            bool isSymetric = false;

            for (int i = 0; i < numbers.Length/2; i++)
            {
                int first = numbers[i] - 48;
                int second = numbers[numbers.Length - 1 - i] - 48;

                if (first == second)
                {
                    isSymetric = true;
                }
                else
                {
                    isSymetric = false;
                    break;
                }
            }

            return isSymetric;
        }
        static bool IsDivisible(int num)
        {
            bool IsDivisible = false;

            string numbers = num.ToString();
            List<int> nums = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int CurrentNum = numbers[i] - 48;
                nums.Add(CurrentNum);
            }

            if (nums.Sum() % 7 == 0)
            {
                IsDivisible = true;
            }

            return IsDivisible;
        }
        static bool ContainsEvenDigit(int num)
        {
            string numbers = num.ToString();
            bool containsEven = false;

            foreach (var number in numbers)
            {
                int currentNum = number - 48;

                if (currentNum % 2 == 0)
                {
                    containsEven = true;
                    break;
                }
            }
            return containsEven;
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (IsSymetric(i) && IsDivisible(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
