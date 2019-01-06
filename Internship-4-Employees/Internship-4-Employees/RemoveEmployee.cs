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
        private AllEmployeesRepository _listOfEmployees;
        public RemoveEmployee(AllEmployeesRepository listOfEmployees)
        {
            InitializeComponent();
            _listOfEmployees = listOfEmployees;
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
                _listOfEmployees.Remove(int.Parse(ChooseLbx.SelectedItem.ToString()));
            else
            {
                MessageBox.Show("First choose who you wish to remove, then click the button");
                return;
            }

            string message = "Are you sure you wish to remove this employee?";
            string caption = "Asking approval";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.No)
            {
                return;
            }
            CleaningAndFillingForm();
        }

        private void BackBtn_Click(object sender, EventArgs e) => this.Close();
    }
}
