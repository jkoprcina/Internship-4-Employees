using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Interface.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_4_Employees.Interface.Extensions;

namespace Internship_4_Employees.Domain.Repositories
{
    public static class AllEmployeesRepository
    {
        private static List<Employee> _employees = new List<Employee>()
        {
            new Employee("Carl", "Smith", new DateTime(1997,12,6), "0", JobEnums.Jobs.Programer),
            new Employee("Jane", "Peterson", new DateTime(1996,1,8), "1", JobEnums.Jobs.Designer)
        };


        public static List<Employee> GetAllEmployees() => _employees;


        //ADD , REMOVE, GET
        public static void Add(Employee employeeToAdd)
        {
            _employees.Add(employeeToAdd);
        }

        public static void Remove(string personToRemove)
        {
            foreach (var e in _employees)
            {
                if (e.OIB == personToRemove)
                {
                    _employees.Remove(e);
                    break;
                }
            }
        }

        public static Employee Get(string oibOfEmployeeToGet)
        {
            foreach (var e in _employees)
            {
                if (e.OIB == oibOfEmployeeToGet)
                    return e;
            }
            return null;
        }

        //Add method which checks and adds all needed info
        public static string AddEmployee(string name, string lastname, string oib, DateTime dateOfBirth, string job, List<Project> projects)
        {
            if (!CheckIfOIBExists(oib.RemoveAllTheWhiteSpaces()))
                return "The OIB is already in use, it must be unique";
            else if(!CheckIfOfAge(dateOfBirth))
                return "The user must be at least 18 years old";
            else
            {
                var employee = new Employee(name.RemoveWhiteSpaces().CapitalizeWords(),
                    lastname.RemoveWhiteSpaces().CapitalizeWords(),
                    dateOfBirth, oib.RemoveAllTheWhiteSpaces(), (JobEnums.Jobs)Enum.Parse(typeof(JobEnums.Jobs), job));
                Add(employee);

                EmployeeProjectRepository.AddConnectionsSingleEmployee(employee.OIB, projects);
            }
            return "The input was successful!";
        }

        //Checks if the oib already exists because it has to be a unique number
        public static bool CheckIfOIBExists(string oib)
        {
            foreach(var employee in _employees)
            {
                if (employee.OIB == oib)
                    return false;
            }
            return true;
        }

        public static bool CheckIfOfAge(DateTime dateOfBirth)
        {
            return dateOfBirth < DateTime.Now.AddYears(-18);
        }

        //A method which returns the ammount of hours an employ is working per week right now not taking into account the exact 
        //day of week projects start and end
        public static int CountWeeklyWorkTime(Employee employee)
        {
            var weeklyWorkTime = 0;
            foreach (var connectionInstance in EmployeeProjectRepository.GetAllConnectins())
            {
                var project = AllProjectsRepository.Get(connectionInstance.Name);
                if (connectionInstance.OIB == employee.OIB && project.State == StateEnums.States.Ongoing)
                {
                    weeklyWorkTime += connectionInstance.WorkingHours;
                }
            }
            return weeklyWorkTime;
        }

        //A method that returns three lists that show how many projects the employee has worked on so far (Finished projects),
        //is working on (Ongoing projects), or will work on (Planned projects)
        public static string NumberOfProjectsForOneEmployee(Employee employee)
        {
            var numberOfFinishedProjects = 0;
            var numberOfOngoingProjects = 0;
            var numberOfPlannedProjects = 0;

            foreach (var connectionInstance in EmployeeProjectRepository.GetAllConnectins())
            {
                var project = AllProjectsRepository.Get(connectionInstance.Name);
                if (connectionInstance.OIB == employee.OIB)
                {
                    if (project.State == StateEnums.States.Finished)
                        numberOfFinishedProjects++;
                    else if (project.State == StateEnums.States.Ongoing)
                        numberOfOngoingProjects++;
                    else
                        numberOfPlannedProjects++;
                }
            }
            return $"Number of finished Projects: {numberOfFinishedProjects}\n" +
                   $"Number of ongoing Projects: {numberOfOngoingProjects}\n" +
                   $"Number of planned Projects: {numberOfPlannedProjects}\n";
        }

        //A method used in edit forms which returns all employees who are currently, have once, or will once work on the project
        //(if nothing changes of course)
        public static List<Employee> GetAllEmployeesWorkingOnProject(Project project)
        {
            var listOfEmployeesWorkingOnProject = new List<Employee>();
            foreach (var connection in EmployeeProjectRepository.GetAllConnectins())
            {
                if (connection.Name == project.Name)
                {
                    var employee = Get(connection.OIB);
                    if(!listOfEmployeesWorkingOnProject.Contains(employee))
                        listOfEmployeesWorkingOnProject.Add(employee);
                }
            }
            return listOfEmployeesWorkingOnProject;
        }

        //A method used in edit forms which returns all employees who aren't currenty, never have, and never will work on the project
        //(if nothing changes of course)
        public static List<Employee> GetAllEmployeesNotWorkingOnProject(List<Employee> _employees)
        {
            var listOfEmployeesNotWorkingOnProject = new List<Employee>();
            foreach (var connection in EmployeeProjectRepository.GetAllConnectins())
            {
                var employee = Get(connection.OIB);
                if (!_employees.Contains(employee))
                {
                    if (!listOfEmployeesNotWorkingOnProject.Contains(employee))
                        listOfEmployeesNotWorkingOnProject.Add(employee);
                }
            }
            return listOfEmployeesNotWorkingOnProject;
        }

        // Edit method which accepts all info and edits old ones
        public static string Edit(string name, string lastname, string oib, DateTime dateOfBirth, string job,List<Project> projects)
        {
            if (CheckIfOfAge(dateOfBirth))
            {
                var employee = new Employee(name.RemoveWhiteSpaces().CapitalizeWords(),
                    lastname.RemoveWhiteSpaces().CapitalizeWords(),
                    dateOfBirth, oib.RemoveAllTheWhiteSpaces(), (JobEnums.Jobs) Enum.Parse(typeof(JobEnums.Jobs), job));
                Remove(oib);
                Add(employee);
                EmployeeProjectRepository.RemoveAllWithEmployee(employee);
                EmployeeProjectRepository.AddConnectionsSingleEmployee(employee.OIB, projects);
                return "The edit was successful!";
            }
            else
                return "The user must be at least 18 years old";
        }
    }
}
