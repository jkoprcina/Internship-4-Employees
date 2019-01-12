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
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee("Josip", "Koprcina", DateTime.Now, "0", JobEnums.Jobs.Programer),
            new Employee("Ana", "Vucak", DateTime.Now, "1", JobEnums.Jobs.Designer)
        };


        public static List<Employee> GetAllEmployees() => Employees;

        public static void Add(Employee employeeToAdd)
        {
            Employees.Add(employeeToAdd);
        }

        public static void Remove(string personToRemove)
        {
            foreach (var e in Employees)
            {
                if (e.OIB == personToRemove)
                {
                    Employees.Remove(e);
                    break;
                }
            }
        }

        public static bool AddEmployee(string name, string lastname, string oib, DateTime dateOfBirth, string job, List<Project> projects)
        {
            if (CheckIfOIBExists(oib.RemoveAllTheWhiteSpaces()) && CheckIfOfAge(dateOfBirth))
            {
                var employee = new Employee(name.RemoveWhiteSpaces().CapitalizeWords(),
                    lastname.RemoveWhiteSpaces().CapitalizeWords(),
                    dateOfBirth, oib.RemoveAllTheWhiteSpaces(), (JobEnums.Jobs) Enum.Parse(typeof(JobEnums.Jobs), job));
                Employees.Add(employee);

                EmployeeProjectRepository.AddConnectionsSingleEmployee(employee.OIB, projects);
                return true;
            }
            else
                return false;
        }

        public static bool CheckIfOIBExists(string oib)
        {
            foreach(var employee in Employees)
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

        public static Employee Get(string oibOfEmployeeToGet)
        {
            foreach (var e in Employees)
            {
                if (e.OIB == oibOfEmployeeToGet)
                    return e;
            }
            return null;
        }

        public static int CountWeeklyWorkTime(Employee employee)
        {
            var weeklyWorkTime = 0;
            foreach (var connectionInstance in EmployeeProjectRepository._listOfAllConnections)
            {
                var project = AllProjectsRepository.Get(connectionInstance.Name);
                if (connectionInstance.OIB == employee.OIB && project.State == StateEnums.States.Ongoing)
                {
                    weeklyWorkTime += connectionInstance.WorkingHours;
                }
            }
            return weeklyWorkTime;
        }

        public static string NumberOfProjectsForOneEmployee(Employee employee)
        {
            var numberOfFinishedProjects = 0;
            var numberOfOngoingProjects = 0;
            var numberOfPlannedProjects = 0;

            foreach (var connectionInstance in EmployeeProjectRepository._listOfAllConnections)
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

        
    }
}
