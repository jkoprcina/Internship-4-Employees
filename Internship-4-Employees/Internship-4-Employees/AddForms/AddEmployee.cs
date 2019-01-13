using Internship_4_Employees.Data.Models;
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
        private List<Project> AddedProjects;
        private List<Project> NotAddedProjects;
        public AddEmployee()
        {
            NotAddedProjects = AllProjectsRepository.GetAllProjects().ToList();
            AddedProjects = new List<Project>();
            InitializeComponent();
            ClearAndFillForm();
        }

        public void ClearAndFillForm()
        {
            ProjectsToChooseFromLbx.Items.Clear();
            ChosenProjectsLbx.Items.Clear();
            foreach (var r in Enum.GetValues(typeof(JobEnums.Jobs)))
                PositionCbx.Items.Add(r);
            foreach (var p in NotAddedProjects)
                ProjectsToChooseFromLbx.Items.Add(p);
            foreach (var p in AddedProjects)
                ChosenProjectsLbx.Items.Add(p);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (!NameTbx.Text.ToString().CheckIfEmpty() && !LastnameTbx.Text.ToString().CheckIfEmpty() &&
                OIBTxb.Text.CheckIfNumber() && !OIBTxb.Text.CheckIfEmpty() && PositionCbx.SelectedIndex > -1)
            {
                var message = AllEmployeesRepository.AddEmployee(NameTbx.Text, LastnameTbx.Text, OIBTxb.Text,
                    DateOfBirthPicker.Value, PositionCbx.SelectedItem.ToString(), AddedProjects);
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
                if (NameTbx.Text.ToString().CheckIfEmpty() || LastnameTbx.Text.ToString().CheckIfEmpty())
                {
                    MessageBox.Show("You can't leave the 'name' and 'lastname' parts empty");
                    return;
                }
                else if (!(PositionCbx.SelectedIndex > -1))
                {
                    MessageBox.Show("You need to choose the job the employee will be doing");
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
        private void BackBtn_Click(object sender, EventArgs e) => this.Close();

        private void SaveProjectBtn_Click(object sender, EventArgs e)
        {
            if (ProjectsToChooseFromLbx.SelectedItem != null && !WorkingHoursTxt.Text.CheckIfEmpty() && WorkingHoursTxt.Text.CheckIfNumber())
            {
                var project = ProjectsToChooseFromLbx.SelectedItem as Project;
                project.WorkingHours = int.Parse(WorkingHoursTxt.Text);
                AddedProjects.Add(project);
                NotAddedProjects.Remove(project);
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
