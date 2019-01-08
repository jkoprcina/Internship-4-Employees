using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Interface.Enumerators;

namespace Internship_4_Employees.Domain.Repositories
{
    public class AllProjectsRepository
    {
        private List<Project> _projects;
        private List<Employee> _employees = new List<Employee>();
        public AllProjectsRepository()
        {
            FakeData();
        }

        private void FakeData()
        {
            _projects = new List<Project>()
            {
                new Project("Google Glasses", _employees, new DateTime(2016, 1, 18), new DateTime(2017, 1, 18), States.Ongoing, 10),
                new Project("Jarvis", _employees, new DateTime(2015, 1, 18), new DateTime(2020, 1, 18), States.Ongoing, 12)
            };
        }

        public List<Project> GetAllProjects() => _projects;

        public void Add(Project projectToAdd)
        {
            _projects.Add(projectToAdd);
        }

        public void Remove(Project project)
        {
            _projects.Remove(project);
        }

        public Project Get(string nameOfProjectToGet)
        {
            foreach (var p in _projects)
            {
                if (p.Name == nameOfProjectToGet)
                    return p;
            }
            return null;
        }
    }
}
