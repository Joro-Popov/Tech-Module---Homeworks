using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Student_Groups
{
    class Town
    {
        public string TownName { get; set; }
        public int Seats { get; set; }
        public List<Student> Students { get; set; }
        public List<Group> Groups { get; set; }

        public Town(string name, int seats)
        {
            TownName = name;
            Seats = seats;
            Students = new List<Student>();
            Groups = new List<Group>();
        }
    }
    class Student
    {
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Student(string name, string email, DateTime date)
        {
            StudentName = name;
            StudentEmail = email;
            RegistrationDate = date;
        }
    }
    class Group
    {
        public Town Town { get; set; }
        public List<Student> students { get; set; }

    }
    class Program
    {
        static void DistributeStudentsIntoGroups(List<Town> AllTowns)
        {
            for (int i = 0; i <= AllTowns.Count-1; i++)
            {
                Town currentTown = AllTowns[i];

                List<Student> CurrentStudents = AllTowns[i].Students
                    .OrderBy(w => w.RegistrationDate)
                    .ThenBy(w => w.StudentName)
                    .ThenBy(w => w.StudentEmail)
                    .ToList();

                while (CurrentStudents.Count != 0)
                {
                    Group currentGroup = new Group();

                    currentGroup.Town = currentTown;
                    currentGroup.students = CurrentStudents
                        .Take(currentTown.Seats)
                        .ToList();

                    CurrentStudents = CurrentStudents
                        .Skip(currentTown.Seats)
                        .ToList();

                    currentTown.Groups.Add(currentGroup);
                }
            }

        }
        static void Main(string[] args)
        {
            List<Town> AllTowns = new List<Town>();

            string input = Console.ReadLine();
            Regex TownPattern = new Regex(@"(?'town'[A-z]+\s*[A-z]*) => (?'seats'[0-9]+) seats");

            while (input != "End")
            {
                if (TownPattern.IsMatch(input))
                {
                    Match match = TownPattern.Match(input);

                    string townName = match.Groups["town"].ToString();
                    int seats = int.Parse(match.Groups["seats"].ToString());

                    Town currentTown = new Town(townName, seats);
                    AllTowns.Add(currentTown);
                }
                else
                {
                    List<string> StudentTokens = input
                        .Split(new char[] { '|' },
                        StringSplitOptions
                        .RemoveEmptyEntries)
                        .Select(w => w.Trim(new char[] { ' '}))
                        .ToList();
                        

                    string studentName = StudentTokens[0];
                    string studentEmail = StudentTokens[1];
                    DateTime registrationDate = 
                    DateTime.ParseExact(StudentTokens[2], "d-MMM-yyyy",CultureInfo.CreateSpecificCulture("en-US"));

                    Student currentStudent = 
                    new Student(studentName, studentEmail, registrationDate);

                    List<Student> currentList = 
                    AllTowns[AllTowns.Count - 1].Students;

                    currentList.Add(currentStudent);
                }

                input = Console.ReadLine();
            }

            DistributeStudentsIntoGroups(AllTowns);

            int groupsCount = AllTowns
                .Select(w => w.Groups.Count)
                .Sum();

            int townCount = AllTowns.Count;

            Console.WriteLine($"Created {groupsCount} groups in {townCount} towns:");
            
            foreach (var town in AllTowns.OrderBy(w => w.TownName))
            {
                string townName = town.TownName;
                List<Group> Groups = town.Groups;

                foreach (var group in Groups)
                {
                    List<string> students = group.students.Select(w => w.StudentEmail).ToList();

                    Console.WriteLine($"{townName} => {string.Join(", ",students)}");
                }
            }
        }
    }
}
