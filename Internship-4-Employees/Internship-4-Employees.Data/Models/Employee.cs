using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_4_Employees.Interface.Enumerators;

namespace Internship_4_Employees.Data.Models
{
    public class Employee
    {
        public Employee(string name, string lastname, DateTime dateOfBirth, int oIB, Roles role, List<Project> projects)
        {
            Name = name;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
            OIB = oIB;
            Role = role;
            Projects = projects;
        }

        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int OIB { get; set; }
        public Roles Role { get; set; }
        public List<Project> Projects { get; set; }
        public int WeeklyWorkTime { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} {Lastname} OIB:\t{OIB}\n";
        }

        public string AllInfo()
        {
            var numberOfFinishedProjects = 0;
            var numberOfOngoingProjects = 0;
            var numberOfPlannedProjects = 0;
            WeeklyWorkTime = 0;

            foreach (var p in Projects)
            {
                if (p.State == States.Finished)
                    numberOfFinishedProjects++;
                else if (p.State == States.Ongoing)
                    numberOfOngoingProjects++;
                else
                    numberOfPlannedProjects++;

                if (p.WorkingHours != null && p.State == States.Ongoing)
                    WeeklyWorkTime += (int)p.WorkingHours;
            }

            return $"Name: {Name} {Lastname}\n" +
                   $"Date of birth: {DateOfBirth.ToShortDateString()}\n" +
                   $"OIB: {OIB}\n" +
                   $"Occupation: {Role}\n" +
                   $"Number of finished Projects: {numberOfFinishedProjects}\n" +
                   $"Number of ongoing Projects: {numberOfOngoingProjects}\n" +
                   $"Number of planned Projects: {numberOfPlannedProjects}\n";
        }

        public void AddProject(Project project)
        {
            if(!Projects.Contains(project))
                Projects.Add(project);
        }
    }
}
