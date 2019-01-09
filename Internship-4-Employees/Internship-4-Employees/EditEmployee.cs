using Internship_4_Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_4_Employees.Domain.Repositories;
using Internship_4_Employees.Interface.Enumerators;
using Internship_4_Employees.Interface.Extensions;

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
            foreach (var r in Enum.GetValues(typeof(Jobs)))
                RolesCmb.Items.Add(r);
            foreach (var p in _projects)
                AllProjectsCbx.Items.Add(p.ToString());
            NameTbx.Text = _employee.Name;
            LastnameTbx.Text = _employee.Lastname;
            OIBTxt.Text = _employee.OIB.ToString();
            RolesCmb.Text = _employee.Role.ToString();
            DateOfBirthPicker.Value = _employee.DateOfBirth;
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var newName = _employee.Name;
            var newLastname = _employee.Lastname;
            var newOIB = _employee.OIB;
            var newDateOfBirth = _employee.DateOfBirth;
            var newRole = _employee.Role;
            var projects = _employee.Projects;
            
            try
            {
                if (_employee.Name != NameTbx.Text.RemoveWhiteSpaces().CapitalizeWords())
                    newName = NameTbx.Text.RemoveWhiteSpaces().CapitalizeWords();

                if (_employee.Lastname != LastnameTbx.Text.RemoveWhiteSpaces().CapitalizeWords())
                    newLastname = LastnameTbx.Text.RemoveWhiteSpaces().CapitalizeWords();
                try
                {
                    if (_employee.OIB != int.Parse(OIBTxt.Text.RemoveAllTheWhiteSpaces()))
                        newOIB = int.Parse(OIBTxt.Text.RemoveAllTheWhiteSpaces());
                }
                catch
                {
                    MessageBox.Show("OIB needs to be a number");
                    return;
                }

                if (DateOfBirthPicker.Value.Date != newDateOfBirth.Date)
                    newDateOfBirth = DateOfBirthPicker.Value.Date;

                if (DateTime.Now.Year - newDateOfBirth.Year < 19)
                {
                    MessageBox.Show("Employee must be over the age of 18.");
                    return;
                }

                if (RolesCmb.SelectedIndex > -1)
                    newRole = (Jobs) RolesCmb.SelectedValue;

                _employee.Projects.Clear();

                foreach (var project in AllProjectsCbx.CheckedItems)
                {
                    string[] singleProjectInfo = project.ToString().Split('\t');
                    var _project = _listOfProjects.Get(singleProjectInfo[0]);
                    _project.AddEmployee(_employee);
                    _employee.Projects.Add(_project);
                }
            }
            catch
            {
                MessageBox.Show("Wrong input, same problem with roles as in addEmployee");
            }

            _employee.Name = newName;
            _employee.Lastname = newLastname;
            _employee.OIB = newOIB;
            _employee.Role = newRole;
            Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
