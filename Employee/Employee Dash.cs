using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__project
{
    public partial class Employee_Dash : Form
    {
        public Employee_Dash()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create and show the Application form
            Employee.Application applicationForm = new Employee.Application();
            applicationForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
