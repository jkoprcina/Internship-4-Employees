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
    public partial class Information : Form
    {
        private List<Employee> _employees;
        private AllEmployeesRepository _listOfEmployees;
        private List<Project> _projects;
        private AllProjectsRepository _listOfProjects;
        public Information(AllEmployeesRepository listOfEmployees, AllProjectsRepository listOfProjects) 
        {
            InitializeComponent();
            _listOfEmployees = listOfEmployees;
            _employees = _listOfEmployees.GetAllEmployees();
            _listOfProjects = listOfProjects;
            _projects = _listOfProjects.GetAllProjects();
            CleaningAndFillingForm();
        }

        public void CleaningAndFillingForm()
        {
            AllProjectsLbx.Items.Clear();
            AllEmployeesLbx.Items.Clear();
            AllProjectsLbx.Items.Clear();
            foreach (var e in _employees)
                AllEmployeesLbx.Items.Add(e.ToString());
            foreach (var p in _projects)
                AllProjectsLbx.Items.Add(p.ToString());
        }

        private void ExitBtn_Click(object sender, EventArgs e) => this.Close();

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var edit = new Edit(_listOfEmployees, _listOfProjects);
            edit.ShowDialog();
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

        private void EmployeeDetailsBtn_Click(object sender, EventArgs e)
        {
            if (AllEmployeesLbx.SelectedIndex > -1)
            {
                string[] temp = AllEmployeesLbx.SelectedItem.ToString().Split('\t');
                var projectDetails = new EmployeeDetails(_listOfEmployees.Get(int.Parse(temp[1])));
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
