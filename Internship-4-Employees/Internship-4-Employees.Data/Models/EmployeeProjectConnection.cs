using Internship_4_Employees.Interface.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_4_Employees.Data.Models
{
    public class EmployeeProjectConnection
    {
        public string OIB { get; set; }
        public string Name { get; set; }
        public int WorkingHours { get; set; }

        public EmployeeProjectConnection(string oib, string name, int workingHours)
        {
            OIB = oib;
            Name = name;
            WorkingHours = workingHours;
        }
    }
}
