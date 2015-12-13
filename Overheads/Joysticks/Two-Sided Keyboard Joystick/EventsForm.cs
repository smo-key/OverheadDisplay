using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controls.Joysticks
{
    public partial class EventsForm : Form
    {
        private OverheadForm parentform = null;
        public EventsForm(OverheadForm parent)
        {
            InitializeComponent();
            parentform = parent;
            Title.Text = parentform.title + " Events";
        }

        private void Close_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        #region Drag
        private int locx = 0;
        private int locy = 0;
        private bool drag = false;
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            //locx and locy = the mouse's position ON THE FORM
            locx = e.X;
            locy = e.Y;
            locx = 0 + locx;
            locy = 0 + locy;
            drag = true;
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Location = new Point(MousePosition.X - locx, MousePosition.Y - locy);
                }
                else
                {
                    drag = false;
                }
            }
        }

        #endregion
    }
}
