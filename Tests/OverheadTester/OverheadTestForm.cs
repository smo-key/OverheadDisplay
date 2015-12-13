using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverheadTester
{
    public partial class OverheadTestForm : Form
    {
        public OverheadTestForm()
        {
            InitializeComponent();
            Overhead.title = "Controller 1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Overhead.UpdateStatus("frozen");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Overhead.UpdateStatus("disabled");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Overhead.UpdateStatus("enabled");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Overhead.show_titleoptions = !(Overhead.show_titleoptions);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Overhead.show_titlebar = !(Overhead.show_titlebar);
        }

        private void OverheadTestForm_Resize(object sender, EventArgs e)
        {
            Overhead.Width = this.Width - 16;
            Overhead.Height = this.Height - 71;
            Overhead.Location = new Point(0, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Overhead.show_errorpanel = !(Overhead.show_errorpanel);
        }
    }
}
