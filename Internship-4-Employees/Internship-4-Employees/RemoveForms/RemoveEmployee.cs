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
        public RemoveEmployee()
        {
            InitializeComponent();
            CleaningAndFillingForm();
        }

        public void CleaningAndFillingForm()
        {
            AllEmployeesLbx.Items.Clear();
            foreach (var e in AllEmployeesRepository.GetAllEmployees())
                AllEmployeesLbx.Items.Add(e);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (AllEmployeesLbx.SelectedIndex > -1)
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

                var employee = AllEmployeesLbx.SelectedItem as Employee;
                EmployeeProjectRepository.RemoveAllWithEmployee(employee);
                AllEmployeesRepository.Remove(employee.OIB);
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
