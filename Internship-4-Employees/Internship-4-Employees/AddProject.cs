using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Domain.Repositories;

namespace Internship_4_Employees
{
    public partial class AddProject : Form
    {
        public AddProject(AllProjects listOfProjects, AllEmployees listOfEmployees)
        {
            InitializeComponent();
            var _emloyees = listOfEmployees.GetAllEmployees();
            EmployeeCbx.Items.Clear();
            foreach (var e in _emloyees)
            {
                EmployeeCbx.Items.Add($"{e.Name} {e.Lastname} {e.OIB}\n");
            }
        }

        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            var name = "";
            var hours = 0;
            var start = DateTime.Now;
            var finish = DateTime.Now;
            var listOfEmployees = new List<Employee>();
            var _projects = listOfProjects.GetAllProjects();

            try
            {
                foreach (var p in _projects)
                {
                    if (p.Name == name)
                    {
                        MessageBox.Show("That name is already in use.");
                        return;
                    }
                }
                hours = int.Parse(HoursTbx.Text);
                if (hours < 0)
                {
                    MessageBox.Show(
                        "The number of hours a person works on a project weekly needs to be a positive whole number");
                    return;
                }

                start = StartDtp.Value;
                finish = FinishingDtp.Value;
                if (finish <= start)
                {
                    MessageBox.Show("The project can not finish before or at the same time as it started");
                    return;
                }

                foreach (var person in EmployeeCbx.CheckedItems)
                {

                }
            }
            catch
            {
                MessageBox.Show("Wrong input");
                return;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
