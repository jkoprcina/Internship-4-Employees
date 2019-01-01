using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Interface.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_4_Employees.Domain.Repositories
{
    public class AllEmployees
    {
        private List<Employee> _employees;
        public AllEmployees()
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

        public void Edit(Employee personToEdit)
        {

        }

        public void Remove(int personToRemove)
        {
            foreach (var e in GetAllEmployees())
            {
                if (e.OIB == personToRemove)
                {
                    _employees.Remove(e);
                    break;
                }
            }
        }
    }
}
