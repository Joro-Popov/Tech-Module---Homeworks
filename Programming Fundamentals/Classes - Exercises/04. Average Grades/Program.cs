using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get; set; }

        public Student(string name, List<double> grades)
        {
            Name = name;
            Grades = grades;
            AverageGrade = grades.Average();
        }
    }
    class Program
    {
        static Student ReadStudent()
        {
            List<string> Tokens = Console.ReadLine().Split(' ').ToList();

            string name = Tokens[0];
            List<double> Grades = Tokens.Skip(1).Select(double.Parse).ToList();

            Student student = new Student(name, Grades);

            return student;
            
        }
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();

            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < num; i++)
            {
                Student student = ReadStudent();
                Students.Add(student);
            }

            Students = Students
                .Where(w => w.AverageGrade >= 5.00)
                .OrderBy(w => w.Name)
                .ThenByDescending(w => w.AverageGrade)
                .ToList();

            foreach (var stud in Students)
            {
                Console.WriteLine($"{stud.Name} -> {stud.AverageGrade:f2}");
            }
        }
    }
}
