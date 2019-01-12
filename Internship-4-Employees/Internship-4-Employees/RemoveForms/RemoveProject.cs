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
    public partial class RemoveProject : Form
    {
        public RemoveProject()
        {
            InitializeComponent();
            CleaningAndFillingForm();
        }

        private void CleaningAndFillingForm()
        {
            AllProjectsLbx.Items.Clear();
            foreach (var p in AllProjectsRepository.GetAllProjects())
                AllProjectsLbx.Items.Add(p);
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();

        private void RemoveProjectBtn_Click(object sender, EventArgs e)
        {
            if (AllProjectsLbx.SelectedIndex > -1)
            {
                var project = AllProjectsLbx.SelectedItem as Project;
                EmployeeProjectRepository.RemoveAllWithProject(project);
                AllProjectsRepository.Remove(project);
            }
            else
            {
                MessageBox.Show("Please choose the project you wish to remove first");
                return;
            }
            CleaningAndFillingForm();
        }

        private void ProjectDetailsBtn_Click(object sender, EventArgs e)
        {
            if (AllProjectsLbx.SelectedIndex > -1)
            {
                var projectDetails = new ProjectDetails(AllProjectsLbx.SelectedItem as Project);
                projectDetails.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose the project you wish to view");
                return;
            }
        }
    }
}
