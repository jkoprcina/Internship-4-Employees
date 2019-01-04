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
        private List<Employee> _employees;
        public RemoveEmployee(AllEmployees _listOfEmployees)
        {
            InitializeComponent();
            _listOfEmployees = new AllEmployees();
            _employees = _listOfEmployees.GetAllEmployees();
            CleaningForm();
            foreach (var e in _employees)
            {
                UsersRtb.Text += e.ToString();
            }
            foreach (var e in _employees)
            {
                ChooseLbx.Items.Add(e.OIB +"\n");
            }
        }

        public void CleaningForm()
        {
            UsersRtb.Clear();
            ChooseLbx.Items.Clear();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int oibOfPersonToRemove;
            if (ChooseLbx.SelectedIndex > -1)
            {
                oibOfPersonToRemove = int.Parse(ChooseLbx.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("First choose who you wish to remove, then click the button");
                return;
            }
            _listOfEmployees.Remove(oibOfPersonToRemove);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
