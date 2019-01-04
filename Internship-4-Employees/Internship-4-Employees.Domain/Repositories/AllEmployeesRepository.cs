using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Interface.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_4_Employees.Domain.Repositories
{
    public class AllEmployeesRepository
    {
        private List<Employee> _employees;
        public AllEmployeesRepository()
        {
            FakeData();
        }

        private void FakeData()
        {
            _employees = new List<Employee>()
            {
                new Employee("Josip", "Koprcina", DateTime.Now, 0, Roles.Programer),
                new Employee("Ana", "Vucak", DateTime.Now, 1, Roles.Programer)
            };
        }

        public List<Employee> GetAllEmployees() => _employees;

        public void Add(Employee employeeToAdd)
        {
            _employees.Add(employeeToAdd);
        }

        public void Edit(Employee personToEdit)
        {

        }

        public void Remove(int personToRemove)
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

        public Employee Get(int personToReturnOib)
        {
            foreach (var e in _employees)
            {
                if (e.OIB == personToReturnOib)
                {
                    return e;
                }
            }
        }
    }
}
