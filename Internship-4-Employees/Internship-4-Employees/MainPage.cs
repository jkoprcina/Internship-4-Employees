using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internship_4_Employees
{
    public partial class MainPage : Form
    {
        private List<Employee> _employees;
        private List<Project> _projects;
        public MainPage()
        {
            InitializeComponent();
            ClearAndFillForms();
        }

        private void ShutDownBtn_Click(object sender, EventArgs e) => Close();

        private void ClearAndFillForms()
        {
            _employees = AllEmployeesRepository.GetAllEmployees().ToList();
            _projects = AllProjectsRepository.GetAllProjects().ToList();
            AllEmployeesLbx.Items.Clear();
            AllProjectsLbx.Items.Clear();
            foreach (var employee in _employees)
                AllEmployeesLbx.Items.Add(employee);
            foreach (var project in _projects)
                AllProjectsLbx.Items.Add(project);

        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            var addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
            ClearAndFillForms();
        }

        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            var addProject = new AddProject();
            addProject.ShowDialog();
            ClearAndFillForms();
        }

        private void RemoveEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (AllEmployeesLbx.SelectedIndex > -1)
            {
                string message = "Are you sure you wish to remove this employee?";
                string caption = "Asking approval";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.No)
                {
                    return;
                }

                var employee = AllEmployeesLbx.SelectedItem as Employee;
                EmployeeProjectRepository.RemoveAllWithEmployee(employee);
                AllEmployeesRepository.Remove(employee.OIB);
            }
            else
            {
                MessageBox.Show("First choose who you wish to remove, then click the button");
                return;
            }
            ClearAndFillForms();
        }

        private void RemoveProjectBtn_Click(object sender, EventArgs e)
        {
            if (AllProjectsLbx.SelectedIndex > -1)
            {
                string message = "Are you sure you wish to remove this project?";
                string caption = "Asking approval";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.No)
                {
                    return;
                }
                var project = AllProjectsLbx.SelectedItem as Project;
                EmployeeProjectRepository.RemoveAllWithProject(project);
                AllProjectsRepository.Remove(project);
            }
            else
            {
                MessageBox.Show("Please choose the project you wish to remove first");
                return;
            }
            ClearAndFillForms();
        }

        private void EmployeeDetailsBtn_Click(object sender, EventArgs e)
        {
            if (AllEmployeesLbx.SelectedIndex > -1)
            {
                var employeeDetails = new EmployeeDetails(AllEmployeesLbx.SelectedItem as Employee);
                employeeDetails.ShowDialog();
                ClearAndFillForms();
            }
            else
                MessageBox.Show("Please choose the employee you wish to see the details of");
        }

        private void ProjectDetailsBtn_Click(object sender, EventArgs e)
        {
            if (AllProjectsLbx.SelectedIndex > -1)
            {
                var projectDetails = new ProjectDetails(AllProjectsLbx.SelectedItem as Project);
                projectDetails.ShowDialog();
                ClearAndFillForms();
            }
            else
                MessageBox.Show("Please choose the project you wish to see the details of");
        }

        private void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (AllEmployeesLbx.SelectedIndex > -1)
            {
                var editEmployee = new EditEmployee(AllEmployeesLbx.SelectedItem as Employee);
                editEmployee.ShowDialog();
                ClearAndFillForms();
            }
            else
                MessageBox.Show("Please choose the employee you wish to edit the details of");
        }

        private void EditProjectBtn_Click(object sender, EventArgs e)
        {
            if (AllProjectsLbx.SelectedIndex > -1)
            {
                var editProject = new EditProject(AllProjectsLbx.SelectedItem as Project);
                editProject.ShowDialog();
                ClearAndFillForms();
            }
            else
                MessageBox.Show("Please choose the project you wish to edit the details of");
        }
    }
}
