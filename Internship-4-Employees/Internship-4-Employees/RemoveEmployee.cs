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
    public partial class RemoveEmployee : Form
    {
        private AllProjectsRepository _listOfProjects;
        private AllEmployeesRepository _listOfEmployees;
        private List<Project> _projects;
        private List<Employee> _employees;
        public RemoveEmployee(AllEmployeesRepository listOfEmployees, AllProjectsRepository listOfProjects)
        {
            InitializeComponent();
            _listOfProjects = listOfProjects;
            _listOfEmployees = listOfEmployees;
            _projects = _listOfProjects.GetAllProjects();
            _employees = _listOfEmployees.GetAllEmployees();
            CleaningAndFillingForm();
        }

        public void CleaningAndFillingForm()
        {
            UsersRtb.Clear();
            ChooseLbx.Items.Clear();
            foreach (var e in _employees)
                UsersRtb.Text += e.ToString();
            foreach (var e in _employees)
                ChooseLbx.Items.Add(e.OIB + "\n");
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (ChooseLbx.SelectedIndex > -1)
            {
                string message = "Are you sure you wish to remove this employee?";
                string caption = "Asking approval";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.No)
                {
                    return;
                }

                var employee = _listOfEmployees.Get(int.Parse(ChooseLbx.SelectedItem.ToString()));
                _listOfEmployees.Remove(int.Parse(ChooseLbx.SelectedItem.ToString()));
                foreach (var p in _projects)
                {
                    foreach (var i in p.Assigned)
                        MessageBox.Show(i.ToString());
                    if (p.Assigned.Contains(employee))
                    {
                        MessageBox.Show(p.ToString());
                        p.Assigned.Remove(employee);
                    }
                }
            }
            else
            {
                MessageBox.Show("First choose who you wish to remove, then click the button");
                return;
            }

            CleaningAndFillingForm();
        }

        private void BackBtn_Click(object sender, EventArgs e) => this.Close();
    }
}
