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
            AllEmployeesRtb.Clear();
            AllEmployeesRtb.Text = "";
            AllProjectsLbx.Items.Clear();
            foreach (var e in _employees)
            {
                AllEmployeesRtb.Text += e.ToString();
            }
            foreach (var p in _projects)
            {
                AllProjectsLbx.Items.Add(p.Name);
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var edit = new Edit(_listOfEmployees, _listOfProjects);
            edit.ShowDialog();
        }
    }
}
