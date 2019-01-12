using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_4_Employees.Interface.Enumerators;
using Internship_4_Employees.Interface.Extensions;

namespace Internship_4_Employees.Data.Models
{
    public class Employee
    {
        public Employee(string name, string lastname, DateTime dateOfBirth, string oIB, JobEnums.Jobs role)
        {
            Name = name;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
            OIB = oIB.RemoveAllTheWhiteSpaces();
            Role = role;
        }

        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string OIB { get; set; }
        public JobEnums.Jobs Role { get; set; }
        public int WorkingHours { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} {Lastname} OIB:\t{OIB}\n";
        }

        public string AllInfo()
        {
            return $"Name: {Name} {Lastname}\n" +
                   $"Date of birth: {DateOfBirth.ToShortDateString()}\n" +
                   $"OIB: {OIB}\n" +
                   $"Occupation: {Role}\n";
        }
    }
}
