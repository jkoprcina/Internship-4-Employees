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
    public partial class Edit : Form
    {
        public Edit(AllEmployeesRepository _listOfEmployees)
        {
            InitializeComponent();
        }
    }
}
