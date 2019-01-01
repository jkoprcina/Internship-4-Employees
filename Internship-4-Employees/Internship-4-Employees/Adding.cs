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

namespace Internship_4_Employees
{
    public partial class Adding : Form
    {
        private List<Employee> _employees;
        private AllEmployees _listOfEmployees;
        public Adding()
        {
            InitializeComponent();
            _listOfEmployees = new AllEmployees();
            _employees = _listOfEmployees.GetAllEmployees();
            CleaningForm();
        }

        public void CleaningForm()
        {
            NameTbx.Clear();
            LastnameTbx.Clear();
            OIBTxb.Clear();
            AllProjectsCbx.Items.Clear();
            foreach (var r in Enum.GetValues(typeof(Roles)))
                OccupationCmb.Items.Add(r);

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var name = "";
            var lastname = "";
            var OIB = 0;
            var role = Roles.Programer;

            try
            {
                name = NameTbx.Text;
                lastname = LastnameTbx.Text;
                try
                {
                    OIB = int.Parse(OIBTxb.ToString().Replace(" ", ""));
                    foreach (var person in _employees)
                    {
                        if (person.OIB == OIB)
                        {
                            MessageBox.Show("This OIB is already in use, go to 'Edit employee info' in the main menu if you wish to Edit instead of Add.");
                            return;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("The OIB should not contain letters.");
                    return;
                }

                if (OccupationCmb.SelectedIndex < 0)
                {
                    MessageBox.Show("You need to select an occuption.");
                    return;
                }
                else
                    role = (Roles)OccupationCmb.SelectedValue;
            }
            catch
            {
                MessageBox.Show("Uknown error, try again!");
                return;
            }

            var dateOfBirth = DateTimePicker1.Value;
            if (DateTime.Now.Year - dateOfBirth.Year < 19)
            {
                MessageBox.Show("Employee must be over the age of 18.");
                return;
            }

            _employees.Add(new Employee(name, lastname, dateOfBirth, OIB, role));

            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
