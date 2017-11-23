using System;
using System.Collections.Generic;
using System.IO;
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
            AverageGrade = Grades.Average();
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Student> AllStudents = new List<Student>();
            
            string[] Input = File.ReadAllLines("Input.txt");

            for (int i = 1; i <= Input.Length-1; i++)
            {
                List<string> CurrentStudent = Input[i]
                    .ToString()
                    .Split(' ')
                    .ToList();

                string name = CurrentStudent[0];

                List<double> Grades = CurrentStudent
                    .GetRange(1, CurrentStudent.Count - 1)
                    .Select(double
                    .Parse)
                    .ToList();

                Student student = new Student(name, Grades);
                AllStudents.Add(student);
            }

            AllStudents = AllStudents
                .Where(w => w.AverageGrade >= 5.00)
                .OrderBy(w => w.Name)
                .ThenBy(w => w.AverageGrade)
                .ToList();

            using (StreamWriter writer = new StreamWriter("Output.txt",true))
            {
                foreach (var stud in AllStudents)
                {
                    string result = ($"{stud.Name} -> {stud.AverageGrade:f2}");

                    writer.WriteLine(result);
                }
            }
        }
    }
}
