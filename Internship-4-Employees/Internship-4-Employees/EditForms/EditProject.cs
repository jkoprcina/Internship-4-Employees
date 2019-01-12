using Internship_4_Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_4_Employees.Domain.Repositories;
using Internship_4_Employees.Interface.Enumerators;
using Internship_4_Employees.Interface.Extensions;

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
            StartDtp.Value = _project.ProjectStart.Date;
            FinishDtp.Value = _project.ProjectFinish.Date;
            foreach (var e in AllEmployeesRepository.GetAllEmployees())
                AllEmployeeCbx.Items.Add(e.ToString());
            for (int x = 0; x < AllEmployeeCbx.Items.Count; x++)
            {
                string[] temp = AllEmployeeCbx.Items[x].ToString().Split('\t');
                var employee = AllEmployeesRepository.Get(temp[1]);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();

        private void EditProjectBtn_Click(object sender, EventArgs e)
        {
            if (!ProjectNameTxt.Text.ToString().CheckIfEmpty() && AllEmployeeCbx.SelectedIndex > -1)
            {
            }
            else
            {
            }
            
            Close();
        }
    }
}
