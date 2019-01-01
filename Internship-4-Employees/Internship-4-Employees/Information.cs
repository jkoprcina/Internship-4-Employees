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
    public partial class Information : Form
    {
        private List<Employee> _employees;
        public AllEmployees _listOfEmployees;
        public Information()
        {
            InitializeComponent();
            _listOfEmployees = new AllEmployees();
            _employees = _listOfEmployees.GetAllEmployees();
            EverythingRtb.Text = "";
            foreach (var e in _employees)
            {
                EverythingRtb.Text += e.ToString();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
