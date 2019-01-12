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
        public EditEmployee(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            ClearAndFillForms();
        }

        public void ClearAndFillForms()
        {
            foreach (var r in Enum.GetValues(typeof(JobEnums.Jobs)))
                PositionsCmb.Items.Add(r);
            foreach (var p in AllProjectsRepository.GetAllProjects())
                AllProjectsCbx.Items.Add(p);
            NameTbx.Text = _employee.Name;
            LastnameTbx.Text = _employee.Lastname;
            OIBTxt.Text = _employee.OIB.ToString();
            PositionsCmb.Text = _employee.Role.ToString();
            DateOfBirthPicker.Value = _employee.DateOfBirth;
            for (int x = 0; x < AllProjectsCbx.Items.Count; x++)
            {
                string[] temp = AllProjectsCbx.Items[x].ToString().Split('\t');
                var project = AllProjectsRepository.Get(temp[0]);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!NameTbx.Text.ToString().CheckIfEmpty() && !LastnameTbx.Text.ToString().CheckIfEmpty() &&
                OIBTxt.Text.CheckIfNumber() && PositionsCmb.SelectedIndex > -1)
            { 

            }
            else
            {
                
            }

            Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
