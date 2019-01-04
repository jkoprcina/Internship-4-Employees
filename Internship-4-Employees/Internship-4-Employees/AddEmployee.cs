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
    public partial class AddEmployee : Form
    {
        private AllEmployeesRepository _listOfEmployees;
        public AddEmployee(AllEmployeesRepository listOfEmployees)
        {
            InitializeComponent();
            CleaningForm();
            _listOfEmployees = listOfEmployees;
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
            var _employees = _listOfEmployees.GetAllEmployees();
            var dateOfBirth = DateTime.Now;

            
            name = NameTbx.Text;
            lastname = LastnameTbx.Text;
            try
            {
                OIB = int.Parse(OIBTxb.Text);
                foreach (var person in _employees)
                {
                    if (person.OIB == OIB)
                    {
                        MessageBox.Show(
                            "This OIB is already in use, go to 'Edit employee info' in the main menu if you wish to Edit instead of Add.");
                        return;
                    }
                }

                if (OccupationCmb.SelectedIndex < 0)
                {
                    MessageBox.Show("You need to select an occuption.");
                    return;
                }
                else
                {
                    role = (Roles) OccupationCmb.SelectedValue;
                    MessageBox.Show(role.ToString());
                }

                dateOfBirth = DateTimePicker1.Value;
                if (DateTime.Now.Year - dateOfBirth.Year < 19)
                {
                    MessageBox.Show("Employee must be over the age of 18.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("You don't know why it throws an error, somewhere in role picking part probably");
            }

            _listOfEmployees.Add(new Employee(name, lastname, dateOfBirth, OIB, role));
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
