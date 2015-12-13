using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Touch_Joystick_Demo
{
    public partial class TouchJoystickDemo : UserControl
    {
        #region Initialization Variables
        public String publisher { get { return "Arthur Pachachura"; } }
        public String copyright { get { return "Copyright (C) Arthur Pachachura 2013"; ; } }
        public String name { get { return "Two-Sided Touch Joystick DEMO"; } }
        public String[] location { get { return new String[] { "Controls", "Joysticks" }; } }
        public int[] version { get { return new int[] { 1, 0 }; } }
        public string versionkey { get { return "F2B72989-7053-44F6-A7A7-60CFCB61E777"; } }
        //DO NOT MODIFY THE VERSIONKEY!  It is used to find which version of OverheadDisplay you are using.
        //Change this key based on the one provided in your SDK.

        public enum Status { frozen, disabled, enabled };
        //enabled = actions can occur, display active
        //disabled = actions cannot occur, display active
        //frozen = displaying frozen_message, nothing else

        public Status status
        {
            get { return mystatus; }
        }
        private Status mystatus;
        //current status

        public string title
        {
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
            set { Settings.Visible = value; }
        }

        public bool show_errorpanel
        {
            get { return ErrorPanel.Visible; }
            set { ErrorPanel.Visible = value; }
        }

        public string frozen_message = "This control is currently inactive.";
        //message to display during frozen status

        #endregion

        public TouchJoystickDemo()
        {
            InitializeComponent();
            InitializeComponent();
            FrozenText.Text = frozen_message;
            UpdateStatus(Status.disabled);
            show_titleoptions = false;
            show_titlebar = true;
            show_errorpanel = false;
            this.DoubleBuffered = true;

            CenterX = this.Width / 2;
            if (this.Height < this.Width)
            {
                JoyHeight = this.Height / 3;
            }
            else
            {
                JoyHeight = this.Width / 3;
            }
        }

        /// <summary> 
        /// Call this to update the title of the control.  It is REQUIRED in order to see visual changes.
        /// </summary>
        /// <param name="newstatus">The form's title, displayed at the top.</param>
        public void UpdateTitle(string newtitle)
        {
            Title.Text = newtitle;
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
                FrozenText.Visible = true;
                FrozenText.Text = frozen_message;                
            }
            else
            {
                
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
        /// <param name="newstatus">The status you wish to set the form to.  Frozen = displaying frozen_message, nothing else.
        /// Disabled = actions cannot occur, display active.  Enabled = actions can occur, display active.</param>
        public void UpdateStatus(string newstatus)
        {
            if (newstatus == "frozen")
            {
                FrozenText.Visible = true;
                FrozenText.Text = frozen_message;
            }
            else
            {
                FrozenText.Visible = false;
            }

            if (newstatus == "disabled")
            {
                this.BackColor = System.Drawing.SystemColors.ControlDark;
            }
            else
            {
                this.BackColor = System.Drawing.SystemColors.Control;
            }

            if (newstatus == "frozen") { mystatus = Status.frozen; }
            if (newstatus == "disabled") { mystatus = Status.enabled; }
            if (newstatus == "enabled") { mystatus = Status.disabled; }
            
        }

        //event when the form resizes
        private void TouchJoystickDemo_Resize(object sender, EventArgs e)
        {
            CenterX = this.Width / 2;
            if (this.Height < this.Width)
            {
                JoyHeight = this.Height / 3;
            }
            else
            {
                JoyHeight = this.Width / 3;
            }
        }

        Point locL = new Point(0, 0);
        Point locLb = new Point(0, 0);
        bool drawL = false;
        int CenterX;
        int JoyHeight;
        Graphics gfx;
        int offsetX = -60;
        int offsetY = -60;

        private void TouchJoystickDemo_MouseDown(object sender, MouseEventArgs e)
        {
            locLb = new Point(e.X +offsetX, e.Y + offsetY);
            locL = new Point(e.X + offsetX, e.Y + offsetY);
            drawL = true;
            this.Invalidate();
        }

        private void TouchJoystickDemo_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawL == true)
            {
                locL = new Point(e.X + offsetX, e.Y + offsetY);
                double x1 = locL.X;
                double x2 = locLb.X;
                double y1 = locL.Y;
                double y2 = locLb.Y;
                double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                int maxdist = 20;
                if (distance > maxdist)
                {
                    x1 = (x1 / distance * maxdist) + x2 + offsetX;
                    y1 = (y1 / distance * maxdist) + y2 + offsetY;
                    locL = new Point((int)x1, (int)y1);
                }
                this.Invalidate();
            }

        }

        private void TouchJoystickDemo_MouseUp(object sender, MouseEventArgs e)
        {
            drawL = false;
            this.Invalidate();
        }

        private void TouchJoystickDemo_Paint(object sender, PaintEventArgs e)
        {
            if (drawL == true)
            {
                Bitmap myBitmap = new Bitmap(global::Touch_Joystick_Demo.Properties.Resources.Joystick_LR2Bottom,JoyHeight,JoyHeight);

                // Draw myBitmap to the screen.
                e.Graphics.DrawImage(myBitmap, locLb.X, locLb.Y, myBitmap.Width,
                    myBitmap.Height);

                // Make the default transparent color transparent for myBitmap.
                //myBitmap.MakeTransparent();

                // Draw the transparent bitmap to the screen.
                //e.Graphics.DrawImage(myBitmap, myBitmap.Width, 0,
                //    myBitmap.Width, myBitmap.Height);

                /*Rectangle cropRect = new Rectangle(JoyHeight - 1, 0, 1, JoyHeight);                
                Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

                using(Graphics g = Graphics.FromImage(target))
                {
                   myBitmap.MakeTransparent();
                   g.DrawImage(myBitmap, new Rectangle(0, 0, target.Width, target.Height), 
                                    cropRect,                        
                                    GraphicsUnit.Pixel);
                }*/

                Bitmap myBitmap2 = new Bitmap(global::Touch_Joystick_Demo.Properties.Resources.Joystick_LR2Top, JoyHeight, JoyHeight);

                // Draw myBitmap to the screen.
                e.Graphics.DrawImage(myBitmap2, locL.X, locL.Y, myBitmap2.Width,
                    myBitmap2.Height);

                // Make the default transparent color transparent for myBitmap.
                //myBitmap2.MakeTransparent();

                // Draw the transparent bitmap to the screen.
                //e.Graphics.DrawImage(myBitmap2, myBitmap2.Width, 0,
                //    myBitmap2.Width, myBitmap2.Height);
            }

        }

    }
}
