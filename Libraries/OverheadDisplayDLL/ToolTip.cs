using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverheadDisplay.Assets
{
    public partial class ToolTip : UserControl
    {
        public ToolTip()
        {
            InitializeComponent();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
