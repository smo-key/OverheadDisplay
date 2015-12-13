using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverheadDisplay.Assets
{
    public partial class PreLoad_Error : Form
    {
        public PreLoad_Error(string error)
        {
            InitializeComponent();
            label1.Text = error;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
