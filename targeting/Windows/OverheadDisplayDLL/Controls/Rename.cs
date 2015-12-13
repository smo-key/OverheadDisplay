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
    public sealed partial class Rename : Bases.PopupBase
    {
        private string text;
        public string status { get; private set; }
        public Rename(Bases.DesignBase reference, string text) : base(reference)
        {
            if (Utils.Referenced)
            {
                InitializeComponent();
                this.DoubleBuffered = true;
                this.text = text;
                this.NameBox.Text = text;
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

        private void Change_Click(object sender, EventArgs e)
        {
            status = NameBox.Text;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            status = null;
            this.Close();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            if ((NameBox.Text.Trim() == "") || (NameBox.Text == null) || (NameBox.Text == text))
            {
                Change.Enabled = false;
            }
            else
            {
                Change.Enabled = true;
            }
        }
    }
}
