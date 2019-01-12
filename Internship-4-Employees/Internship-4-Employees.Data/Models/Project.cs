using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_4_Employees.Interface.Enumerators;
using Internship_4_Employees.Interface.Extensions;

namespace Internship_4_Employees.Data.Models
{
    public class Project
    {
        public Project(string name, DateTime projectStart, DateTime projectFinish)
        {
            Name = name;
            ProjectStart = projectStart;
            ProjectFinish = projectFinish;
        }

        public string Name { get; set; }
        public DateTime ProjectStart { get; set; }
        public DateTime ProjectFinish { get; set; }
        public int WorkingHours { get; set; }

        public StateEnums.States State
        {
            get
            {
                var state = StateEnums.States.Ongoing;
                if (ProjectStart > DateTime.Now)
                    state = StateEnums.States.Planned;
                else if (ProjectFinish < DateTime.Now)
                    state = StateEnums.States.Finished;
                return state;
            }
        }

        public override string ToString()
        {
            return $"{Name}\t{State}\n";
        }
    }
}
