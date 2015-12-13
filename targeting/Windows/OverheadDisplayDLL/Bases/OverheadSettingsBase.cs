using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverheadDisplay.Bases
{
    public sealed partial class OverheadSettingsBase : Bases.PopupBase
    {
        public OverheadSettingsBase(Bases.DesignBase reference)
            : base(reference)
        {
            if (Utils.Referenced)
            {
                InitializeComponent();
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
