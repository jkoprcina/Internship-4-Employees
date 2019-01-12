using Internship_4_Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_4_Employees.Domain.Repositories;
using Internship_4_Employees.Interface.Enumerators;
using Internship_4_Employees.Interface.Extensions;

namespace Internship_4_Employees
{
    public partial class EditEmployee : Form
    {
        private Employee _employee;
        private List<Project> listOfWorkedOnProjects;
        private List<Project> listOfNotWorkedOnProjects;
        public EditEmployee(Employee employee)
        {
            _employee = employee;
            listOfWorkedOnProjects = AllProjectsRepository.GetAllProjectsWorkedOn(_employee.OIB);
            listOfNotWorkedOnProjects = AllProjectsRepository.GetAllProjectsNotWorkedOn(listOfWorkedOnProjects);
            InitializeComponent();
            ClearAndFillForm();
        }

        public void ClearAndFillForm()
        {
            ProjectsEmployeeIsOnLbx.Items.Clear();
            ProjectsEmployeeIsNotOnLbx.Items.Clear();
            foreach (var r in Enum.GetValues(typeof(JobEnums.Jobs)))
                PositionsCmb.Items.Add(r);
            foreach (var p in listOfWorkedOnProjects)
                ProjectsEmployeeIsOnLbx.Items.Add(p);
            foreach (var p in listOfNotWorkedOnProjects)
                ProjectsEmployeeIsNotOnLbx.Items.Add(p);
            NameTbx.Text = _employee.Name;
            LastnameTbx.Text = _employee.Lastname;
            EmployeeOIBLbl.Text = _employee.OIB.ToString();
            PositionsCmb.Text = _employee.Role.ToString();
            DateOfBirthPicker.Value = _employee.DateOfBirth;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!NameTbx.Text.ToString().CheckIfEmpty() && !LastnameTbx.Text.ToString().CheckIfEmpty()
                 && PositionsCmb.SelectedIndex > -1)
            {
                if (!AllEmployeesRepository.Edit(NameTbx.Text, LastnameTbx.Text, _employee.OIB,
                    DateOfBirthPicker.Value, PositionsCmb.SelectedItem.ToString(), listOfWorkedOnProjects))
                {
                    MessageBox.Show("Something was wrong");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Wrong input");
                return;
            }

            Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();

        private void AddToProjectbtn_Click(object sender, EventArgs e)
        {
            if (ProjectsEmployeeIsNotOnLbx.SelectedIndex > -1 && !WorkingHoursTxt.Text.CheckIfEmpty() && WorkingHoursTxt.Text.CheckIfNumber())
            {
                var project = ProjectsEmployeeIsNotOnLbx.SelectedItem as Project;
                project.WorkingHours = int.Parse(WorkingHoursTxt.Text);
                listOfWorkedOnProjects.Add(project);
                listOfNotWorkedOnProjects.Remove(project);
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
            if (ProjectsEmployeeIsOnLbx.SelectedItem != null)
            {
                var project = ProjectsEmployeeIsOnLbx.SelectedItem as Project;
                listOfNotWorkedOnProjects.Add(project);
                listOfWorkedOnProjects.Remove(project);
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
