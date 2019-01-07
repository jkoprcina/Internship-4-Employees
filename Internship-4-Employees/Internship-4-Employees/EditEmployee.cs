using Internship_4_Employees.Data.Models;
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
using Internship_4_Employees.Interface.Enumerators;

namespace Internship_4_Employees
{
    public partial class EditEmployee : Form
    {
        private Employee _employee;
        private AllProjectsRepository _listOfProjects;
        private List<Project> _projects;
        public EditEmployee(Employee employee, AllProjectsRepository listOfProjects)
        {
            InitializeComponent();
            _employee = employee;
            _listOfProjects = listOfProjects;
            _projects = listOfProjects.GetAllProjects();
            ClearAndFillForms();
        }

        public void ClearAndFillForms()
        {
            foreach (var r in Enum.GetValues(typeof(Roles)))
                OccupationCmb.Items.Add(r);
            foreach (var p in _projects)
                AllProjectsCbx.Items.Add(p.ToString());
            NameTbx.Text = _employee.Name;
            LastnameTbx.Text = _employee.Lastname;
            OccupationCmb.Text = _employee.Role.ToString();
            DateTimePicker1.Value = _employee.DateOfBirth;
            for (int x = 0; x < AllProjectsCbx.Items.Count; x++)
            {
                string[] temp = AllProjectsCbx.Items[x].ToString().Split('\t');
                var project = _listOfProjects.Get(temp[0]);
                foreach (var e in _employee.Projects)
                {
                    if (e == project)
                        AllProjectsCbx.SetItemChecked(x,true);
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
