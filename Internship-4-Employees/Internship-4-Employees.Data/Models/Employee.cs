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
        public Employee(string name, string lastname, DateTime dateOfBirth, Guid oIB, Roles role)
        {
            Name = name;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
            OIB = oIB;
            Role = role;
        }

        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid OIB { get; set; }
        public Roles Role { get; set; }
    }
}
