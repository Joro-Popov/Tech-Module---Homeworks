using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_Projects
{
    class Team
    {
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        public string Creator { get; set; }

        public Team(string creator, string teamNAme)
        {
            TeamName = teamNAme;
            Members = new List<string>();
            Creator = creator;
        }
    }
    class Program
    {
        static bool TeamIsNotPresent(List<Team> Teams, string teamName)
        {
            bool isNotPresent = true;

            for (int i = 0; i <= Teams.Count-1; i++)
            {
                string currentTeamName = Teams[i].TeamName;

                if (teamName == currentTeamName)
                {
                    isNotPresent = false;
                    break;
                }
            }

            return isNotPresent;
        }
        static bool CreatorIsNotPresent(List<Team> Teams, string creator)
        {
            bool isNotPresent = true;

            for (int i = 0; i <= Teams.Count-1; i++)
            {
                string currentCreator = Teams[i].Creator;

                if (creator == currentCreator)
                {
                    isNotPresent = false;
                    break;
                }
            }

            return isNotPresent;
        }
        static bool MemberIsNotPresent(List<Team> Teams, string member)
        {
            bool isNotPresent = true;

            for (int i = 0; i <= Teams.Count-1; i++)
            {
                List<string> members = Teams[i].Members;

                if (members.Contains(member) || Teams[i].Creator == member)
                {
                    isNotPresent = false;
                    break;
                }
            }

            return isNotPresent;
        }
        static void AddMember(List<Team> Teams,string team,string member)
        {
            for (int i = 0; i <= Teams.Count-1; i++)
            {
                Team currentTeam = Teams[i];

                if (currentTeam.TeamName == team)
                {
                    currentTeam.Members.Add(member);
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            List<Team> Teams = new List<Team>();

            int countOfTeams = int.Parse(Console.ReadLine());

            // Creating Teams
            for (int i = 0; i < countOfTeams; i++)
            {
                List<string> Input = Console.ReadLine().Split('-').ToList();

                string creator = Input[0];
                string teamName = Input[1];

                Team currentTeam = new Team(creator, teamName);

                if (TeamIsNotPresent(Teams,currentTeam.TeamName))
                {
                    if (CreatorIsNotPresent(Teams,currentTeam.Creator))
                    {
                        Teams.Add(currentTeam);
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");

                    }
                    else
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            // Reading team members
            List<string> Member = Console.ReadLine()
                .Split(new string[] { "->" }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            while (string.Join(" ",Member) != "end of assignment")
            {
                string memberName = Member[0];
                string teamToJoin = Member[1];

                if (TeamIsNotPresent(Teams, teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else
                {
                    if (MemberIsNotPresent(Teams, memberName))
                    {
                        AddMember(Teams, teamToJoin, memberName);
                    }
                    else
                    {
                        Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                    }
                }

                Member = Console.ReadLine()
                .Split(new string[] { "->" }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();
            }

            Teams = Teams
                .OrderByDescending(w => w.Members.Count)
                .ThenBy(w => w.TeamName)
                .ToList();

            List<Team> DisbandTeams = Teams
                .Where(w => w.Members.Count == 0)
                .ToList();

            foreach (var team in Teams)
            {
                string teamName = team.TeamName;
                List<string> Members = team.Members;

                Members = Members
                    .OrderBy(w => w)
                    .ToList();

                if (Members.Count > 0)
                {
                    Console.WriteLine($"{teamName}");
                    Console.WriteLine($"- {team.Creator}");

                    foreach (var member in Members.OrderBy(w => w))
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
 
            }
            Console.WriteLine("Teams to disband:");

            //Print disband teams
            foreach (var team in DisbandTeams.OrderBy(w => w.TeamName))
            {
                string teamName = team.TeamName;

                Console.WriteLine(teamName);
            }
        }
    }
}
