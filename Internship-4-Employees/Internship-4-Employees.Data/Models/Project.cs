using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_4_Employees.Interface.Enumerators;

namespace Internship_4_Employees.Data.Models
{
    public class Project
    {
        public Project(string name, List<Employee> assigned, DateTime projectStart, DateTime projectFinish, States state, int? workingHours = null)
        {
            Name = name;
            Assigned = assigned;
            WorkingHours = workingHours;
            ProjectStart = projectStart;
            ProjectFinish = projectFinish;
            State = state;
        }

        public string Name { get; set; }
        public List<Employee> Assigned { get; set; }
        public int? WorkingHours { get; set; }
        public DateTime ProjectStart { get; set; }
        public DateTime ProjectFinish { get; set; }
        public States State { get; set; }

        public override string ToString()
        {
            return $"{Name}\t{State}\n";
        }

        public void AddEmployee(Employee employee)
        {
            if(!Assigned.Contains(employee))
                Assigned.Add(employee);
        }

        public void RemoveAssignedIfContained(Employee employee)
        {
            if (Assigned.Contains(employee))
                Assigned.Remove(employee);
        }
    }
}
