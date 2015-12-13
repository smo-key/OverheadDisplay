using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace OverheadDisplay
{
    public partial class Tooltip : System.Windows.Forms.ToolTip
    {
        public Tooltip()
        {
            InitializeComponent();
        }

        public Tooltip(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
