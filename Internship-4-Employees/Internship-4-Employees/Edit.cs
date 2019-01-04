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

            foreach (var e in _projects)
            {
                AllProjectsLbx.Items.Add($"{e.Name} {e.State}\n");
            }
            foreach (var e in _employees)
            {
                AllEmployeesLbx.Items.Add($"{e.Name} {e.Lastname} {e.OIB}\n");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
