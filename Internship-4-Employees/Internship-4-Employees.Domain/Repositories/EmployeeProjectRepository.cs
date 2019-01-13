using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Interface.Enumerators;

namespace Internship_4_Employees.Domain.Repositories
{
    public static class EmployeeProjectRepository
    {
        private static List<EmployeeProjectConnection> _listOfAllConnections = new List<EmployeeProjectConnection>
        {
            new EmployeeProjectConnection("0","Google Glasses",21),
            new EmployeeProjectConnection("0","Jarvis",21),
            new EmployeeProjectConnection("1","Google Glasses",5),
            new EmployeeProjectConnection("1","Jarvis",6)
        };

        public static List<EmployeeProjectConnection> GetAllConnectins() => _listOfAllConnections;

        //ADD
        //Adds connections which the specific employee has
        public static void AddConnectionsSingleEmployee(string oib, List<Project> projects)
        {
            foreach (var projectToAdd in projects)
            {
                var connectionToAdd = new EmployeeProjectConnection(oib, projectToAdd.Name, projectToAdd.WorkingHours);
                if(!_listOfAllConnections.Contains(connectionToAdd))
                    _listOfAllConnections.Add(connectionToAdd);
            }
        }

        //Adds connections which the specific project has
        public static void AddConnectionsSingleProject(string name, List<Employee> employees)
        {
            foreach (var employeeToAdd in employees)
            {
                var connectionToAdd = new EmployeeProjectConnection(employeeToAdd.OIB, name, employeeToAdd.WorkingHours);
                if (!_listOfAllConnections.Contains(connectionToAdd))
                    _listOfAllConnections.Add(connectionToAdd);
            }
        }

        //REMOVE
        //Removes all the connections which the specific employee has
        public static void RemoveAllWithEmployee(Employee employee)
        {
            var listOfConnectionsToRemove = new List<EmployeeProjectConnection>();
            foreach (var connectionInstance in _listOfAllConnections)
            {
                if(connectionInstance.OIB == employee.OIB)
                    listOfConnectionsToRemove.Add(connectionInstance);
            }
            Remove(listOfConnectionsToRemove);
        }

        //Removes all the connections which the specific project has
        public static void RemoveAllWithProject(Project project)
        {
            var listOfConnectionsToRemove = new List<EmployeeProjectConnection>();
            foreach (var connectionInstance in _listOfAllConnections)
            {
                if (connectionInstance.Name == project.Name)
                    listOfConnectionsToRemove.Add(connectionInstance);
            }
            Remove(listOfConnectionsToRemove);
        }

        public static void Remove(List<EmployeeProjectConnection> listOfConnectionsToRemove)
        {
            foreach (var connectionToRemove in listOfConnectionsToRemove)
                _listOfAllConnections.Remove(connectionToRemove);
        }
    }
}
