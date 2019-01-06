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
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails(Employee employee)
        {
            InitializeComponent();
            EmployeeDetailsRtb.Text += employee.AllInfo();
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
