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
    public partial class ProjectDetails : Form
    {
        public ProjectDetails(Project project)
        {
            InitializeComponent();

            NameLbl.Text = project.Name;
            StartLbl.Text = project.ProjectStart.ToShortDateString();
            FinishLbl.Text = project.ProjectFinish.ToShortDateString();
            StateLbl.Text = project.State.ToString();

            AssignedToProjectRtb.Text += AllProjectsRepository.ThisProjectWorkers(project);
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
