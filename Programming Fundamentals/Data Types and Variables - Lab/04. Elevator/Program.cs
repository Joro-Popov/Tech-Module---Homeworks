using System;

namespace _04._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)people / elevatorCapacity);

            Console.WriteLine(courses);
        }
    }
}
