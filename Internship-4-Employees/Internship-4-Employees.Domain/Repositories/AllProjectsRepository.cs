using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_4_Employees.Data.Models;

namespace Internship_4_Employees.Domain.Repositories
{
    public class AllProjectsRepository
    {
        private List<Project> _projects;
        public List<Employee> listOfEmployees;
        public AllProjectsRepository()
        {
            FakeData();
        }

        private void FakeData()
        {
            _projects = new List<Project>()
            {
                new Project("Google Glasses", listOfEmployees, 10,new DateTime(2016, 1, 18), new DateTime(2017, 1, 18)),
                new Project("Jarvis", listOfEmployees, 12, new DateTime(2015, 1, 18), new DateTime(2020, 1, 18))
            };
        }

        public List<Project> GetAllProjects() => _projects;

        public void Add(Project projectToAdd)
        {
            _projects.Add(projectToAdd);
        }
    }
}
