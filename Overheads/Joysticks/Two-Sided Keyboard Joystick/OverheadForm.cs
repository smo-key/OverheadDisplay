using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controls.Joysticks
{
    public sealed partial class OverheadForm : UserControl
    {
        #region Initialization Variables
        public String publisher { get { return "Arthur Pachachura"; } }
        public String copyright { get { return "Copyright (C) Arthur Pachachura 2013"; ; } }
        public String name { get { return "Two-Sided Simple Keyboard"; } }
        public String[] location { get { return new String[] { "[BASE]", "Joysticks" }; } }
        public string id { get { return "693C29C9359042D3"; } }
        //Unique 16-hex element ID.  Used in the store. DO NOT CHANGE!
        public int[] version { get { return new int[] { 1, 0 }; } }
        public Scope[] scope { get { return new Scope[] { Scope.Joystick }; } }
        //scope = Actions in the selected connection that can be accessed
        public string versionkey { get { return "F2B72989-7053-44F6-A7A7-60CFCB61E777"; } }
        //DO NOT MODIFY THE VERSIONKEY!  It is used to find which version of OverheadDisplay you are using.
        //Change this key based on the one provided in your SDK.
        
        public enum Status { frozen, disabled, enabled };
        //enabled = actions can occur, display active
        //disabled = actions cannot occur, display active
        //frozen = displaying frozen_message, nothing else

        public enum Scope { Sensor, Joystick, Universal };

        public Status status
        {
            get { return mystatus; }            
        }
        private Status mystatus;        
        //current status

        public string title
        {
            set { Title.Text = value; }
            get { return Title.Text; }
        }

        public bool show_titlebar
        {
            get { return TopPanel.Visible; }
            set { TopPanel.Visible = value; }
        }

        public bool show_titleoptions
        {
            get { return Settings.Visible; }
            set 
            {
                Events.Visible = value; 
                Maximize.Visible = value; 
                Settings.Visible = value; 
            }
        }

        public bool show_errorpanel
        {
            get { return ErrorPanel.Visible; }
            set { ErrorPanel.Visible = value; }
        }

        public string frozen_message { get { return _frozenmessage; } set { _frozenmessage = value; } }
        public string _frozenmessage = "This control is currently inactive.";
        //message to display during frozen status

        #endregion

        //TODO: Make a base class for this, Events, Properties, and Actions.

        //Properties may only be called from the properties popup window
        #region Properties
        public bool prop_usenum { get { return _usenum; } set { _usenum = value; } }
        private bool _usenum = false;
        #endregion

        #region Events

        #endregion

        public void ShowForm()
        {            
            CallStart();
        }

        private void CallStart()
        {
            InitializeComponent();
            FrozenText.Text = frozen_message;
            UpdateStatus(Status.frozen);
            show_titleoptions = true;
            show_titlebar = true;
            show_errorpanel = false;
            this.DoubleBuffered = true;
            Title.Text = name;
            //Set to frozen to display text instead while dragging into display
        }

        public OverheadForm()
        {
            CallStart();
        }

        /// <summary> 
        /// Call this to update the status of the control.  It is REQUIRED in order to see visual changes.
        /// </summary>
        /// <param name="newstatus">The status you wish to set the form to.  Frozen = displaying frozen_message, nothing else.
        /// Disabled = actions cannot occur, display active.  Enabled = actions can occur, display active.</param>
        public void UpdateStatus(Status newstatus)
        {
            if (newstatus == Status.frozen)
            {
                W.Visible = false;
                A.Visible = false;
                S.Visible = false;
                D.Visible = false;
                Up.Visible = false;
                Down.Visible = false;
                Left.Visible = false;
                Right.Visible = false;
                FrozenText.Visible = true;
                FrozenText.Text = frozen_message;                
            }
            else
            {
                W.Visible = true;
                A.Visible = true;
                S.Visible = true;
                D.Visible = true;
                Up.Visible = true;
                Down.Visible = true;
                Left.Visible = true;
                Right.Visible = true;
                FrozenText.Visible = false;                
            }

            if (newstatus != Status.enabled)
            {
                this.BackColor = System.Drawing.SystemColors.ControlDark;
            }
            else
            {
                this.BackColor = System.Drawing.SystemColors.Control;
            }

            mystatus = newstatus;
        }

        /// <summary> 
        /// Call this to update the status of the control.  It is REQUIRED in order to see visual changes.
        /// </summary>
        /// <param name="newstatus">The status you wish to set the form to.  'frozen' = displaying frozen_message, nothing else.
        /// 'disabled' = actions cannot occur, display active.  'enabled' = actions can occur, display active.</param>
        public void UpdateStatus(string status)
        {
            Status newstatus = Status.disabled;
            if (status == "enabled") { newstatus = Status.enabled; }
            if (status == "frozen") { newstatus = Status.frozen; }
            if (newstatus == Status.frozen)
            {
                W.Visible = false;
                A.Visible = false;
                S.Visible = false;
                D.Visible = false;
                Up.Visible = false;
                Down.Visible = false;
                Left.Visible = false;
                Right.Visible = false;
                FrozenText.Visible = true;
                FrozenText.Text = frozen_message;
            }
            else
            {
                W.Visible = true;
                A.Visible = true;
                S.Visible = true;
                D.Visible = true;
                Up.Visible = true;
                Down.Visible = true;
                Left.Visible = true;
                Right.Visible = true;
                FrozenText.Visible = false;
            }

            if (newstatus != Status.enabled)
            {
                this.BackColor = System.Drawing.SystemColors.ControlDark;
            }
            else
            {
                this.BackColor = System.Drawing.SystemColors.Control;
            }

            mystatus = newstatus;
        }

        //event when the form resizes
        private void Control_Resize(object sender, EventArgs e)
        {
            int h = this.Height;
            int w = this.Width;
            int corner_width = (w / 30);
            int center_width = (w / 15);
            int dist_betweenkeys = 6;

            Border.Size = this.Size;
            Settings.Location = new Point(w - 44, 3);
            Events.Location = new Point(w - 66, 3);
            Maximize.Location = new Point(w - 22, 3);
            ErrorPanel.Width = w;
            ErrorPanel.Location = new Point(0, h - 21);
            TopPanel.Width = w;
            TopPanel.Location = new Point(0, 0);
            FrozenText.Width = w;
            FrozenText.Height = h;
            FrozenText.Location = new Point(0, 0);
            /*if (((h < 190) || (w < 524)) && (status != Status.frozen))
            {
                //freezes window if overhead is too small
                frozen_message = "The overhead is too small.";
                UpdateStatus(Status.frozen);
                return;
            }*/       
                        
            int keywidth = (w - (corner_width * 2) - center_width - (dist_betweenkeys * 4)) / 6;
            //keywidth = form width - corner substraction - distance in center - distance between keys
            int keyheight = Convert.ToInt32(Math.Floor(Convert.ToDouble(keywidth * 0.7)));
            //keyheight = 70% of keywidth            
            int textsize = Convert.ToInt32(Math.Floor(Convert.ToDouble(keyheight * 0.7)) / 2);
            W.Font = new Font("Segoe UI", textsize, FontStyle.Regular, GraphicsUnit.Pixel, 0, false);
            A.Font = W.Font;
            S.Font = W.Font;
            D.Font = W.Font;
            Up.Font = W.Font;
            Down.Font = W.Font;
            Left.Font = W.Font;
            Right.Font = W.Font;
            W.Height = keyheight;
            A.Height = keyheight;
            S.Height = keyheight;
            D.Height = keyheight;
            Up.Height = keyheight;
            Down.Height = keyheight;
            Left.Height = keyheight;
            Right.Height = keyheight;
            W.Width = keywidth;
            A.Width = keywidth;
            S.Width = keywidth;
            D.Width = keywidth;
            Up.Width = keywidth;
            Down.Width = keywidth;
            Left.Width = keywidth;
            Right.Width = keywidth;            

            A.Location = new Point(corner_width, (this.Height / 2) + (dist_betweenkeys / 2));
            S.Location = new Point(corner_width + keywidth + dist_betweenkeys, (this.Height / 2) + (dist_betweenkeys / 2));
            W.Location = new Point(corner_width + keywidth + dist_betweenkeys, (this.Height / 2) - (dist_betweenkeys / 2) - keyheight);
            D.Location = new Point(corner_width + (keywidth * 2) + (dist_betweenkeys * 2), (this.Height / 2) + (dist_betweenkeys / 2));

            Right.Location = new Point(w - (corner_width) - keywidth, (this.Height / 2) + (dist_betweenkeys / 2));
            Down.Location = new Point(w - (corner_width + keywidth + dist_betweenkeys) - keywidth, (this.Height / 2) + (dist_betweenkeys / 2));
            Up.Location = new Point(w - (corner_width + keywidth + dist_betweenkeys) - keywidth, (this.Height / 2) - (dist_betweenkeys / 2) - keyheight);
            Left.Location = new Point(w - (corner_width + (keywidth * 2) + (dist_betweenkeys * 2)) - keywidth, (this.Height / 2) + (dist_betweenkeys / 2));

        }

        private void Buttons_MouseDown(object sender, MouseEventArgs e)
        {
            if (status == Status.enabled)
            {
                Label s = (Label)sender;
                s.BackColor = Color.White;
                s.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void Buttons_MouseUp(object sender, MouseEventArgs e)
        {
            if (status == Status.enabled)
            {
                Label s = (Label)sender;
                s.BackColor = Color.Black;
                s.ForeColor = Color.White;
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Control_Leave(sender, e);
            Form form = new PropertiesForm(this);
            form.ShowDialog();
            Control_Enter(sender, e);
            if (prop_usenum == false)
            {
                Up.Text = "Up";
                Down.Text = "Down";
                Left.Text = "Left";
                Right.Text = "Right";
            }
            if (prop_usenum == true)
            {
                Up.Text = "8";
                Down.Text = "2";
                Left.Text = "4";
                Right.Text = "6";
            }
        }

        private void Maximize_Click(object sender, EventArgs e)
        {

        }

        private void Events_Click(object sender, EventArgs e)
        {

        }

        private void Control_Enter(object sender, EventArgs e)
        {
            TopPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            Title.ForeColor = Color.White;
        }

        private void Control_Leave(object sender, EventArgs e)
        {
            TopPanel.BackColor = System.Drawing.SystemColors.Control;
            Title.ForeColor = Color.FromArgb(64, 64, 64);
        }




    }
}
