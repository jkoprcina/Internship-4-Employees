﻿using System;
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
using Internship_4_Employees.Interface.Extensions;

namespace Internship_4_Employees
{
    public partial class AddProject : Form
    {
        private List<Employee> AddedEmployees;
        private List<Employee> NotAddedEmployees;
        public AddProject()
        {
            NotAddedEmployees = AllEmployeesRepository.GetAllEmployees().ToList();
            AddedEmployees = new List<Employee>();
            InitializeComponent();
            ClearAndFillForm();
        }

        private void ClearAndFillForm()
        {
            EmployeesToAddLbx.Items.Clear();
            AddedEmployeesLbx.Items.Clear();
            foreach (var e in NotAddedEmployees)
                EmployeesToAddLbx.Items.Add(e);
            foreach (var e in AddedEmployees)
                AddedEmployeesLbx.Items.Add(e);
        }

        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            if (!ProjectNameTbx.Text.ToString().CheckIfEmpty() && AddedEmployees.Count > 0)
            {
                var message = AllProjectsRepository.AddProject(ProjectNameTbx.Text, StartDtp.Value, FinishDtp.Value,
                    AddedEmployees);
                if (message == "The input was successful!")
                    MessageBox.Show(message);
                else
                {
                    MessageBox.Show(message);
                    return;
                }
            }
            else
            {
                if (ProjectNameTbx.Text.ToString().CheckIfEmpty())
                {
                    MessageBox.Show("You need to set a unique project name");
                    return;
                }
                else if(!(AddedEmployees.Count > 0))
                {
                    MessageBox.Show("You need to choose at least one employee to work on the project. " +
                                    "If there are none, go to 'Add Employee' and add one");
                    return;
                }
                else
                {
                    MessageBox.Show("Wrong input");
                    return;
                }
            }
            Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e) => this.Close();

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (EmployeesToAddLbx.SelectedItem != null && !WorkingHoursTxt.Text.CheckIfEmpty() && WorkingHoursTxt.Text.CheckIfNumber())
            {
                var employee = EmployeesToAddLbx.SelectedItem as Employee;
                employee.WorkingHours = int.Parse(WorkingHoursTxt.Text);
                AddedEmployees.Add(employee);
                NotAddedEmployees.Remove(employee);
                ClearAndFillForm();
            }
            else
            {
                MessageBox.Show(@"Wrong input");
                return;
            }
        }
    }
}
