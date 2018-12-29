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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Application.Exit();

        private void InformationBtn_Click_1(object sender, EventArgs e)
        {
            var info = new Information();
            info.ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var add = new Adding();
            add.ShowDialog();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            var remove = new Removing();
            remove.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var edit = new Edit();
            edit.ShowDialog();
        }
    }
}
