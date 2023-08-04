using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.MdiParent=this;
            emp.Show();
        }

        private void timeSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeSheet emp = new TimeSheet();
            emp.MdiParent = this;
            emp.Show();
        }
    }
}
