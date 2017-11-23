using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentor_Group
{
    class Student
    {
        public List<string> Comments { get; set; }
        public List<string> Dates { get; set; }

        public Student()
        {
            Comments = new List<string>();
            Dates = new List<string>();
        }
        
    }
    class Program
    {
        static List<string> GetUserNameAndDates(Dictionary<string, Student> Students, List<string> UserDate)
        {
            while (string.Join(" ", UserDate) != "end of dates")
            {
                string name = UserDate[0];
                UserDate.RemoveAt(0);

                List<string> ListDates = new List<string>();
                ListDates.AddRange(UserDate);

                Student student = new Student();
                student.Dates.AddRange(ListDates);

                if (!Students.ContainsKey(name))
                {
                    Students[name] = student;
                }
                else
                {
                    Students[name].Dates.AddRange(ListDates);
                }

                UserDate = Console.ReadLine()
                .Split(new char[] { ' ', ',' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();
            }

            return UserDate;
        }

        static List<string> GetUserComments(Dictionary<string, Student> Students, List<string> UserComments)
        {
            while (string.Join(" ", UserComments) != "end of comments")
            {
                string name = UserComments[0];
                UserComments.RemoveAt(0);

                List<string> Comments = new List<string>();
                Comments.AddRange(UserComments);

                if (Students.ContainsKey(name))
                {
                    Students[name].Comments.AddRange(Comments);
                }


                UserComments = Console.ReadLine().Split('-').ToList();
            }

            return UserComments;
        }

        static void Main(string[] args)
        {
            Dictionary<string, Student> Students = new Dictionary<string, Student>();

            List<string> UserDate = Console.ReadLine()
                .Split(new char[] { ' ', ',' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            UserDate = GetUserNameAndDates(Students, UserDate);

            List<string> UserComments = Console.ReadLine().Split('-').ToList();

            UserComments = GetUserComments(Students, UserComments);

            foreach (var stud in Students.OrderBy(w => w.Key))
            {
                string name = stud.Key;
                List<string> dates = stud.Value.Dates;
                List<string> comments = stud.Value.Comments;

                Console.WriteLine(name);
                Console.WriteLine("Comments:");

                foreach (var comm in comments)
                {
                    Console.WriteLine($"- {comm}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in dates.OrderBy(w => w))
                {
                    Console.WriteLine($"-- {date}");
                }
            }
        }

        

    }
}
