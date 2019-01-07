using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_4_Employees.Domain.Repositories;

namespace Internship_4_Employees
{
    public partial class MainPage : Form
    {
        public AllEmployeesRepository listOfEmployees;
        public AllProjectsRepository listOfProjects;
        public MainPage()
        {
            InitializeComponent();
            listOfEmployees = new AllEmployeesRepository();
            listOfProjects = new AllProjectsRepository();
            //ovo je hardkoriranje, nadam se da nije bitno sta sam ovako glupo napravia jer je ionako samo za probu
            var employees = listOfEmployees.GetAllEmployees();
            var projects = listOfProjects.GetAllProjects();
            foreach (var p in projects)
            {
                foreach(var e in employees)
                    e.Projects.Add(p);
            }

        }

        private void InformationBtn_Click_1(object sender, EventArgs e)
        {
            var info = new Information(listOfEmployees, listOfProjects);
            info.ShowDialog();
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            var addEmployee = new AddEmployee(listOfEmployees, listOfProjects);
            addEmployee.ShowDialog();
        }

        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            var addProject = new AddProject(listOfProjects, listOfEmployees);
            addProject.ShowDialog();
        }

        private void RemoveEmployeeBtn_Click(object sender, EventArgs e)
        {
            var removeEmployee = new RemoveEmployee(listOfEmployees, listOfProjects);
            removeEmployee.ShowDialog();
        }

        private void RemoveProjectBtn_Click(object sender, EventArgs e)
        {
            var removeProject = new RemoveProject(listOfEmployees, listOfProjects);
            removeProject.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var edit = new Edit(listOfEmployees, listOfProjects);
            edit.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Application.Exit();
    }
}
