using System;

namespace _09._Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;

            for (int i = 0; i < 100; i++)
            {
                string input = Console.ReadLine();
                try
                {
                    int num = int.Parse(input);
                    cnt++;
                }
                catch (Exception)
                {

                    break;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
