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
using Internship_4_Employees.Domain.Repositories;

namespace Internship_4_Employees
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails(Employee employee)
        {
            InitializeComponent();
            var weeklyWorkTime = AllEmployeesRepository.CountWeeklyWorkTime(employee);
            EmployeeDetailsRtb.Text += AllEmployeesRepository.NumberOfProjectsForOneEmployee(employee);
            EmployeeDetailsRtb.Text += employee.AllInfo();
            if(weeklyWorkTime > 41)
                NumberOfHoursWorkingBtn.BackColor = Color.Red;
            else if (weeklyWorkTime < 42 && weeklyWorkTime > 20)
                NumberOfHoursWorkingBtn.BackColor = Color.Green;
            else
                NumberOfHoursWorkingBtn.BackColor = Color.Yellow;
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
