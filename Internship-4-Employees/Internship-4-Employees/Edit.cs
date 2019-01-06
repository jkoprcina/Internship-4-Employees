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
    public partial class Edit : Form
    {
        private AllEmployeesRepository _listOfEmployees;
        private AllProjectsRepository _listOfProjects;
        private List<Employee> _employees;
        private List<Project> _projects;
        public Edit(AllEmployeesRepository listOfEmployees, AllProjectsRepository listOfProjects)
        {
            InitializeComponent();
            _employees = listOfEmployees.GetAllEmployees();
            _projects = listOfProjects.GetAllProjects();
            _listOfProjects = listOfProjects;
            _listOfEmployees = listOfEmployees;
            CleaningAndFillingForm();
        }

        public void CleaningAndFillingForm()
        {
            AllProjectsLbx.Items.Clear();
            AllEmployeesLbx.Items.Clear();
            foreach (var p in _projects)
                AllProjectsLbx.Items.Add(p.ToString());
            foreach (var e in _employees)
                AllEmployeesLbx.Items.Add(e.ToString());
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();

        private void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            var edit = new AddEmployee(_listOfEmployees, _listOfProjects);
            edit.ShowDialog();
        }

        private void EditProjectBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
