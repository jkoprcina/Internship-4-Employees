using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Domain.Repositories;

namespace Internship_4_Employees
{
    public partial class RemoveProject : Form
    {
        private AllProjectsRepository _listOfProjects;
        private AllEmployeesRepository _listOfEmployees;
        private List<Project> _projects;
        private List<Employee> _employees;
        public RemoveProject(AllEmployeesRepository listOfEmployees, AllProjectsRepository listOfProjects)
        {
            InitializeComponent();
            _listOfProjects = listOfProjects;
            _listOfEmployees = listOfEmployees;
            _projects = _listOfProjects.GetAllProjects();
            _employees = _listOfEmployees.GetAllEmployees();
            CleaningAndFillingForm();
        }

        private void CleaningAndFillingForm()
        {
            AllProjectsLbx.Items.Clear();
            foreach (var p in _projects)
                AllProjectsLbx.Items.Add(p.ToString());
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();

        private void RemoveProjectBtn_Click(object sender, EventArgs e)
        {
            if (AllProjectsLbx.SelectedIndex > -1)
            {
                string[] temp = AllProjectsLbx.SelectedItem.ToString().Split('\t');
                var project = _listOfProjects.Get(temp[0]);
                _listOfProjects.Remove(project);
                foreach (var employee in _employees)
                {
                    if (employee.Projects.Contains(project))
                        employee.Projects.Remove(project);
                }

            }
            else
            {
                MessageBox.Show("Please choose the project you wish to remove first");
                return;
            }
            CleaningAndFillingForm();
        }

        private void ProjectDetailsBtn_Click(object sender, EventArgs e)
        {
            if (AllProjectsLbx.SelectedIndex > -1)
            {
                string[] temp = AllProjectsLbx.SelectedItem.ToString().Split('\t');
                var projectDetails = new ProjectDetails(_listOfProjects.Get(temp[0]));
                projectDetails.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose the project you wish to view");
                return;
            }
        }
    }
}
