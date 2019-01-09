using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Domain.Repositories;
using Internship_4_Employees.Interface.Enumerators;

namespace Internship_4_Employees
{
    public partial class AddProject : Form
    {
        private AllEmployeesRepository _listOfEmployees;
        private AllProjectsRepository _listOfProjects;
        private List<Employee> _employees;
        private List<Project> _projects;
        public AddProject(AllProjectsRepository listOfProjects, AllEmployeesRepository listOfEmployees)
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
            EmployeeCbx.Items.Clear();
            foreach (var e in _employees)
                EmployeeCbx.Items.Add(e.ToString());
        }

        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            var name = ProjectNameTbx.Text;
            int? hours = null;
            var start = DateTime.Now;
            var finish = DateTime.Now;
            var state = States.Ongoing;
            var listOfEmployeesInProject = new List<Employee>();
            
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
                if(HoursTbx.Text != "")
                    hours = int.Parse(HoursTbx.Text);
                if (hours < 0)
                {
                    MessageBox.Show(
                        "The number of hours a person works on a project weekly needs to be a positive whole number");
                    return;
                }

                start = StartDtp.Value.Date;
                finish = FinishingDtp.Value;
                if (finish <= start)
                {
                    MessageBox.Show("The project can not finish before or at the same time as it started");
                    return;
                }

                //the OIB will always be in the second place of the array because we set up the checkbox that way 
                foreach (var person in EmployeeCbx.CheckedItems)
                {
                    string[] infoOneEmployee = person.ToString().Split('\t');
                    var employee = _listOfEmployees.Get(int.Parse(infoOneEmployee[2]));
                    listOfEmployeesInProject.Add(employee);
                }

                if (listOfEmployeesInProject.Count < 1)
                {
                    MessageBox.Show("You need to choose at least one project for the employee to work on");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Wrong input");
                return;
            }

            if (start > DateTime.Now)
                state = States.Planned;
            else if (finish < DateTime.Now)
                state = States.Finished;

            var project = new Project(name, listOfEmployeesInProject, start, finish, state, hours);
            _listOfProjects.Add(project);

            foreach (var person in EmployeeCbx.CheckedItems)
            {
                string[] infoOneEmployee = person.ToString().Split('\t');
                var employee = _listOfEmployees.Get(int.Parse(infoOneEmployee[2]));
                employee.Projects.Add(project);
            }
            Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e) => this.Close();
    }
}
