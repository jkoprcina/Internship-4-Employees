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

namespace Internship_4_Employees
{
    public partial class EditProject : Form
    {
        private Project _project;
        private AllEmployeesRepository _listOfEmployees;
        private List<Employee> _employees;
        public EditProject(Project project, AllEmployeesRepository listOfEmployees)
        {
            InitializeComponent();
            _listOfEmployees = listOfEmployees;
            _employees = _listOfEmployees.GetAllEmployees();
            _project = project;
            ClearAndFillForm();
        }

        public void ClearAndFillForm()
        {
            ProjectNameTxt.Text = _project.Name;
            NumberOfHoursOnProjectTbx.Text = _project.WorkingHours.ToString();
            StartDtp.Value = _project.ProjectStart.Date;
            FinishDtp.Value = _project.ProjectFinish.Date;
            foreach (var e in _employees)
                AllEmployeeCbx.Items.Add(e.ToString());
            for (int x = 0; x < AllEmployeeCbx.Items.Count; x++)
            {
                string[] temp = AllEmployeeCbx.Items[x].ToString().Split('\t');
                var employee = _listOfEmployees.Get(int.Parse(temp[1]));
                foreach (var p in _project.Assigned)
                {
                    if (p == employee)
                        AllEmployeeCbx.SetItemChecked(x, true);
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();

        private void EditProjectBtn_Click(object sender, EventArgs e)
        {
            var newProjectName = _project.Name;
            var newProjectWorkingHours = _project.WorkingHours;
            var newStartingDate = _project.ProjectStart;
            var newFinishDate = _project.ProjectFinish;

            if (_project.Name != ProjectNameTxt.Text)
                newProjectName = ProjectNameTxt.Text;

            try
            {
                if (int.Parse(NumberOfHoursOnProjectTbx.Text) < 1)
                {
                    MessageBox.Show("The number of working hours needs to be a positive number");
                    return;
                }
                if (_project.WorkingHours != int.Parse(NumberOfHoursOnProjectTbx.Text))
                    newProjectWorkingHours = int.Parse(NumberOfHoursOnProjectTbx.Text);
            }
            catch
            {
                MessageBox.Show("Number of working hours needs to be a positive number");
                return;
            }

            if (StartDtp.Value == FinishDtp.Value)
            {
                MessageBox.Show("The project can not start and finish on the same day");
                return;
            }

            if (_project.ProjectStart != StartDtp.Value)
                newStartingDate = StartDtp.Value.Date;

            if (_project.ProjectFinish != FinishDtp.Value)
                newFinishDate = FinishDtp.Value.Date;

            _project.Assigned.Clear();

            foreach (var employee in AllEmployeeCbx.CheckedItems)
            {
                string[] singleEmployeeInfo = employee.ToString().Split('\t');
                var employeeToAdd = _listOfEmployees.Get(int.Parse(singleEmployeeInfo[1]));
                _project.AddEmployee(employeeToAdd);
                employeeToAdd.Projects.Add(_project);
            }

            _project.Name = newProjectName;
            _project.WorkingHours = newProjectWorkingHours;
            _project.ProjectStart = newStartingDate;
            _project.ProjectFinish = newFinishDate;
            if (newStartingDate > DateTime.Now)
                _project.State = States.Planned;
            else if (newFinishDate < DateTime.Now)
                _project.State = States.Finished;
            else
                _project.State = States.Ongoing;

            Close();
        }
    }
}
