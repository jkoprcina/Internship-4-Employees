using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Interface.Enumerators;
using Internship_4_Employees.Interface.Extensions;

namespace Internship_4_Employees.Domain.Repositories
{
    public static class AllProjectsRepository
    {
        public static List<Project> _projects = new List<Project>()
        {
            new Project("Google Glasses", new DateTime(2016, 1, 18), new DateTime(2017, 1, 18)),
            new Project("Jarvis", new DateTime(2015, 1, 18), new DateTime(2020, 1, 18))
        };

        public static List<Project> GetAllProjects() => _projects;

        public static void Add(Project projectToAdd)
        {
            _projects.Add(projectToAdd);
        }

        public static void Remove(Project project)
        {
            _projects.Remove(project);
        }

        public static void Remove(string projectName)
        {
            foreach (var project in _projects)
            {
                if (project.Name == projectName)
                {
                    _projects.Remove(project);
                    break;
                }
            }
        }

        public static Project Get(string nameOfProjectToGet)
        {
            foreach (var p in _projects)
            {
                if (p.Name == nameOfProjectToGet)
                    return p;
            }
            return null;
        }

        public static string AddProject(string projectName, DateTime startDate, DateTime finishDate, List<Employee> employees)
        {
            if (!CheckNameAuthentication(projectName))
                return "The projects's name must be unique";
            else if (startDate.Date >= finishDate.Date)
                return "The start date should be before the finish date";
            else
            {
                var project = new Project(projectName.RemoveWhiteSpaces().CapitalizeWords(), startDate, finishDate);
                Add(project);

                EmployeeProjectRepository.AddConnectionsSingleProject(project.Name, employees);
                return "The input was successful!";
            }
        }

        public static bool CheckNameAuthentication(string projectName)
        {
            foreach (var project in _projects)
            {
                if (project.Name == projectName)
                    return false;
            }
            return true;
        }

        public static string ThisProjectWorkers(Project project)
        {
            var infoToReturn = "";
            foreach (var r in Enum.GetValues(typeof(JobEnums.Jobs)))
            {
                var counter = 0;
                foreach (var connectionInstance in EmployeeProjectRepository._listOfAllConnections)
                {
                    if (connectionInstance.Name == project.Name)
                    {
                        var employee = AllEmployeesRepository.Get(connectionInstance.OIB);
                        if (employee.Role == (JobEnums.Jobs)r)
                            counter++;
                    }
                }
                infoToReturn += $"{r}: {counter}\n";
                foreach (var connectionInstance in EmployeeProjectRepository._listOfAllConnections)
                {
                    if (connectionInstance.Name == project.Name)
                    { 
                        var employeeToFind = AllEmployeesRepository.Get(connectionInstance.OIB);
                        if (employeeToFind.Role == (JobEnums.Jobs)r)
                            infoToReturn += employeeToFind.ToString();
                    }
                }
            }
            if (infoToReturn == "")
                return "Nobody is yet assigned to the project";
            else
                return infoToReturn;
        }

        public static List<Project> GetAllProjectsWorkedOn(string oib)
        {
            var listOfWorkedOnProjects = new List<Project>();
            foreach (var connection in EmployeeProjectRepository._listOfAllConnections)
            {
                if (connection.OIB == oib)
                {
                    var project = Get(connection.Name);
                    if (!listOfWorkedOnProjects.Contains(project))
                        listOfWorkedOnProjects.Add(project);
                }
            }
            return listOfWorkedOnProjects;
        }

        public static List<Project> GetAllProjectsNotWorkedOn(List<Project> projectsWorkedOn)
        {
            var listOfNotWorkedOnProjects = new List<Project>();
            foreach (var connection in EmployeeProjectRepository._listOfAllConnections)
            {
                var project = Get(connection.Name);
                if (!projectsWorkedOn.Contains(project))
                {
                    if (!listOfNotWorkedOnProjects.Contains(project))
                        listOfNotWorkedOnProjects.Add(project);
                }
            }
            return listOfNotWorkedOnProjects;
        }

        public static string Edit(string projectName, DateTime startDate, DateTime finishDate, List<Employee> employees)
        {
            if (startDate.Date >= finishDate.Date)
                return "The start date should be before the finish date";
            else
            {
                var project = new Project(projectName.RemoveWhiteSpaces().CapitalizeWords(), startDate, finishDate);
                Remove(projectName);
                Add(project);
                EmployeeProjectRepository.RemoveAllWithProject(project);
                EmployeeProjectRepository.AddConnectionsSingleProject(project.Name, employees);
                return "The edit was successful!";
            }
        }
    }
}
