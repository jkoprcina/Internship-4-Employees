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

namespace Internship_4_Employees
{
    public partial class EditProject : Form
    {
        private Project _project;
        public EditProject(Project project)
        {
            InitializeComponent();
            _project = project;
            ClearAndFillForm();
        }

        public void ClearAndFillForm()
        {
            ProjectNameTxt.Text = _project.Name;

        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
