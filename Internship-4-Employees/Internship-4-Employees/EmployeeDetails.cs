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
            if(employee.WeeklyWorkTime > 41)
                NumberOfHoursWorkingBtn.BackColor = Color.Red;
            else if (employee.WeeklyWorkTime < 42 && employee.WeeklyWorkTime > 20)
                NumberOfHoursWorkingBtn.BackColor = Color.Green;
            else
                NumberOfHoursWorkingBtn.BackColor = Color.Yellow;
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
