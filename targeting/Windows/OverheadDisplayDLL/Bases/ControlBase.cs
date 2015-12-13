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
    public partial class ControlBase : UserControl
    {
        public ControlBase()
        {
            InitializeComponent();
            ResizeBase();
        }      

        public bool activated { get; private set; }

        public string title
        {
            get
            {
                return Title.Text;
            }
            set
            {
                Title.Text = value;
            }
        }

        internal virtual void Control_Resize(object sender, EventArgs e)
        {
            ResizeBase();
        }

        public new virtual void BringToFront()
        {
            base.BringToFront();
            Bases.DesignBase form = (Bases.DesignBase)this.Parent;
            Utils.BringToFront(form);
        }

        private void ResizeBase()
        {
            TopPanel.Width = this.Width;
            Border.Size = this.Size;
            if (activated)
            {
                Border.Size = new Size(Border.Size.Width - 2, Border.Size.Height - 2);
            }
            SortedDictionary<int, Button> sorted = new SortedDictionary<int, Button>();
            foreach (Button item in TopPanel.Controls.OfType<Button>())
            {
                sorted.Add(item.Location.X, item);
            }
            for (int i = sorted.Count() - 1; i > -1; i--)
            {
                int x = TopPanel.Width - 4 - (24 * (sorted.Count() - i));
                Point p = new Point(x, sorted.Values.ElementAt(i).Location.Y);
                sorted.Values.ElementAt(i).Location = p;
            } 
            Resizer.BringToFront();
        }



        internal virtual void CloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            drag = true;
            Bases.DesignBase form = (Bases.DesignBase)this.Parent;
            Utils.BringToFront(form);
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int l = e.X + this.Left - locx;
                    int t = e.Y + this.Top - locy;
                    if (t < 58) { t = 58; }
                    if (t > this.Parent.Size.Height - 46) { t = this.Parent.Size.Height - 46; }
                    if (l < 5 - this.Width) { l = 5 - this.Width; }
                    if (l > this.Parent.Size.Width - 5) { l = this.Parent.Size.Width - 5; }
                    this.Left = l;
                    this.Top = t;
                }
                else
                {
                    drag = false;
                }
            }
        }
        #endregion

        #region Activation
        internal void Activate_MouseDown(object sender, MouseEventArgs e)
        {
            ActivateForm();
        }
        public void EnableActivation()
        {
            Application.DoEvents();
            this.MouseDown += Activate_MouseDown;
            List<Control> controls = GetAll(this).ToList();
            foreach (Control item in controls)
            {
                item.MouseDown += Activate_MouseDown;
            }
        }
        private IEnumerable<Control> GetAll(Control control)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl))
                                      .Concat(controls);
        }
        public virtual void ActivateForm()
        {
            foreach (ControlBase item in Parent.Controls.OfType<ControlBase>())
            {
                item.DeactivateForm();
            }
            foreach (Button item in TopPanel.Controls.OfType<Button>())
            {
                item.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 141, 218);
                item.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 81, 138);
            }
            TopPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            Title.ForeColor = Color.White;
            this.BringToFront();
            activated = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Resizer.distance = new Point(23, 23);
            ResizeBase();
        }
        public virtual void DeactivateForm()
        {
            TopPanel.BackColor = System.Drawing.SystemColors.Control;
            Title.ForeColor = Color.FromArgb(64, 64, 64);
            foreach (Button item in TopPanel.Controls.OfType<Button>())
            {
                item.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
                item.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            }
            activated = false;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Resizer.distance = new Point(21, 21);
            ResizeBase();
        }
        #endregion

    }
}
