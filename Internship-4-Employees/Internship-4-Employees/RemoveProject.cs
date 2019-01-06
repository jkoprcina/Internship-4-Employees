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
        private AllProjectsRepository _listOfProjects;
        private List<Project> _projects;
        public RemoveProject(AllProjectsRepository listOfProjects)
        {
            InitializeComponent();
            _listOfProjects = listOfProjects;
            _projects = _listOfProjects.GetAllProjects();
            CleaningAndFillingForm();
        }

        private void CleaningAndFillingForm()
        {
            AllProjectsLbx.Items.Clear();
            foreach (var p in _projects)
                AllProjectsLbx.Items.Add(p.ToString());
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();

        private void RemoveProjectBtn_Click(object sender, EventArgs e)
        {
            if (AllProjectsLbx.SelectedIndex > -1)
            {
                string[] temp = AllProjectsLbx.SelectedItem.ToString().Split('\t');
                _listOfProjects.Remove(temp[0]);
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
                string[] temp = AllProjectsLbx.SelectedItem.ToString().Split('\t');
                var projectDetails = new ProjectDetails(_listOfProjects.Get(temp[0]));
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
