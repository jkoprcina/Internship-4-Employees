using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_4_Employees.Data.Models
{
    public class Project
    {
        public Project(string name, List<Employee> asigned, int workingHours, DateTime projectStart, DateTime projectFinish)
        {
            Name = name;
            Asigned = asigned;
            WorkingHours = workingHours;
            ProjectStart = projectStart;
            ProjectFinish = projectFinish;
        }

        public string Name { get; set; }
        public List<Employee> Asigned { get; set; }
        public int WorkingHours { get; set; }
        public DateTime ProjectStart { get; set; }
        public DateTime ProjectFinish { get; set; }
    }
}
