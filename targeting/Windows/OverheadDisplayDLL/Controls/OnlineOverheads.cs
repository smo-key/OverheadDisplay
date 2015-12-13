using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverheadDisplay.Controls
{
    public sealed partial class OnlineOverheads : Bases.ControlBase
    {
        List<OverheadAssembly> assemblies = new List<OverheadAssembly>();
        public OnlineOverheads(List<OverheadAssembly> assemblies)
        {
            if (Utils.Referenced)
            {
                InitializeComponent();
                this.assemblies = assemblies;
                this.DoubleBuffered = true;
                EnableActivation();
            }
            else { this.Dispose(); }
        }

        internal override void Control_Resize(object sender, EventArgs e)
        {
            base.Control_Resize(sender, e);
        }

        internal override void CloseForm_Click(object sender, EventArgs e)
        {
            base.CloseForm_Click(sender, e);
        }
    }
}
