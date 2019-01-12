using Internship_4_Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_4_Employees.Domain.Repositories;
using Internship_4_Employees.Interface.Enumerators;
using Internship_4_Employees.Interface.Extensions;

namespace Internship_4_Employees
{
    public partial class EditProject : Form
    {
        private Project _project;
        private List<Employee> EmployeesWorkingOnProject;
        private List<Employee> EmployeesNotWorkingOnProject;
        public EditProject(Project project)
        {
            _project = project;
            EmployeesWorkingOnProject = AllEmployeesRepository.GetAllEmployeesWorkingOnProject(project);
            EmployeesNotWorkingOnProject = AllEmployeesRepository.GetAllEmployeesNotWorkingOnProject(EmployeesWorkingOnProject);
            InitializeComponent();
            ClearAndFillForm();
        }

        public void ClearAndFillForm()
        {
            EmployeesWorkingOnPojectLbx.Items.Clear();
            EmployeesNotWorkingOnProjectLbx.Items.Clear();
            foreach (var e in EmployeesWorkingOnProject)
                EmployeesWorkingOnPojectLbx.Items.Add(e);
            foreach (var e in EmployeesNotWorkingOnProject)
                EmployeesNotWorkingOnProjectLbx.Items.Add(e);

            StartDtp.Value = _project.ProjectStart.Date;
            FinishDtp.Value = _project.ProjectFinish.Date;
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();

        private void EditProjectBtn_Click(object sender, EventArgs e)
        {
            if (EmployeesWorkingOnProject.Count > 0)
            {
                AllProjectsRepository.AddProject(_project.Name, StartDtp.Value, FinishDtp.Value,EmployeesWorkingOnProject);
            }
            else
            {
                MessageBox.Show(@"Wrong input");
                return;
            }
            
            Close();
        }

        private void AddToProjectbtn_Click(object sender, EventArgs e)
        {
            if (EmployeesNotWorkingOnProjectLbx.SelectedIndex > -1 && !WorkingHoursTxt.Text.CheckIfEmpty() && WorkingHoursTxt.Text.CheckIfNumber())
            {
                var employee = EmployeesNotWorkingOnProjectLbx.SelectedItem as Employee;
                employee.WorkingHours = int.Parse(WorkingHoursTxt.Text);
                EmployeesWorkingOnProject.Add(employee);
                EmployeesNotWorkingOnProject.Remove(employee);
                ClearAndFillForm();
            }
            else
            {
                MessageBox.Show(@"Wrong input");
                return;
            }
        }

        private void RemoveFromProjectBtn_Click(object sender, EventArgs e)
        {
            if (EmployeesWorkingOnPojectLbx.SelectedIndex > -1)
            {
                var employee = EmployeesWorkingOnPojectLbx.SelectedItem as Employee;
                EmployeesNotWorkingOnProject.Add(employee);
                EmployeesWorkingOnProject.Remove(employee);
                ClearAndFillForm();
            }
            else
            {
                MessageBox.Show(@"Wrong input");
                return;
            }
        }
    }
}
