﻿using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_4_Employees.Interface.Enumerators;
using Internship_4_Employees.Interface.Extensions;

namespace Internship_4_Employees
{
    public partial class AddEmployee : Form
    {
        private AllEmployeesRepository _listOfEmployees;
        private AllProjectsRepository _listOfProjects;
        private List<Employee> _employees;
        private List<Project> _projects;
        public AddEmployee(AllEmployeesRepository listOfEmployees, AllProjectsRepository listOfProjects)
        {
            InitializeComponent();
            _listOfEmployees = listOfEmployees;
            _listOfProjects = listOfProjects;
            _employees = listOfEmployees.GetAllEmployees();
            _projects = listOfProjects.GetAllProjects();
            CleaningAndFillingForm();
        }

        public void CleaningAndFillingForm()
        {
            NameTbx.Clear();
            LastnameTbx.Clear();
            OIBTxb.Clear();
            AllProjectsCbx.Items.Clear();
            PositionCbx.Items.Clear();
            foreach (var r in Enum.GetValues(typeof(Jobs)))
                PositionCbx.Items.Add(r);
            foreach (var p in _projects)
                AllProjectsCbx.Items.Add(p.ToString());
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var name = "";
            var lastname = "";
            var OIB = 0;
            var role = Jobs.Programer;
            var dateOfBirth = DateTime.Now;
            var listOfProjects = new List<Project>();
            
            name = NameTbx.Text.RemoveWhiteSpaces().CapitalizeWords();
            lastname = LastnameTbx.Text.RemoveWhiteSpaces().CapitalizeWords();
            try
            {
                OIB = int.Parse(OIBTxb.Text.RemoveAllTheWhiteSpaces());
                foreach (var person in _employees)
                {
                    if (person.OIB == OIB)
                    {
                        MessageBox.Show(
                            "This OIB is already in use, go to 'Edit employee info' in the main menu if you wish to Edit instead of Add.");
                        return;
                    }
                }

                dateOfBirth = DateTimePicker1.Value.Date;
                if (DateTime.Now.Year - dateOfBirth.Year < 19)
                {
                    MessageBox.Show("Employee must be over the age of 18.");
                    return;
                }

                if (PositionCbx.SelectedIndex > -1)
                {
                    role = (Jobs) PositionCbx.SelectedValue;
                    MessageBox.Show(role.ToString());
                }
                else
                {
                    MessageBox.Show("You need to select an occuption.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("You don't know why it throws an error, somewhere in role picking part probably");
            }

            var employee = new Employee(name, lastname, dateOfBirth, OIB, role, listOfProjects);
            _listOfEmployees.Add(employee);

            foreach (var project in AllProjectsCbx.CheckedItems)
            {
                string[] singleProjectInfo = project.ToString().Split('\t');
                var _project = _listOfProjects.Get(singleProjectInfo[0]);
                _project.AddEmployee(employee);
                employee.Projects.Add(_project);
            }
            Close();
        }

        private void BackBtn_Click(object sender, EventArgs e) => this.Close();
    }
}
