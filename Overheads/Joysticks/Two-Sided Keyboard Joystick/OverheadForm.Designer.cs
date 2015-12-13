namespace Controls.Joysticks
{
    partial class OverheadForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Border = new System.Windows.Forms.Panel();
            this.Left = new System.Windows.Forms.Label();
            this.Right = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.Label();
            this.Up = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.W = new System.Windows.Forms.Label();
            this.FrozenText = new System.Windows.Forms.Label();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.Error = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Events = new System.Windows.Forms.Label();
            this.Maximize = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Border.SuspendLayout();
            this.ErrorPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.Transparent;
            this.Border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Border.Controls.Add(this.ErrorPanel);
            this.Border.Controls.Add(this.TopPanel);
            this.Border.Controls.Add(this.Left);
            this.Border.Controls.Add(this.Right);
            this.Border.Controls.Add(this.Down);
            this.Border.Controls.Add(this.Up);
            this.Border.Controls.Add(this.A);
            this.Border.Controls.Add(this.D);
            this.Border.Controls.Add(this.S);
            this.Border.Controls.Add(this.W);
            this.Border.Controls.Add(this.FrozenText);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(532, 381);
            this.Border.TabIndex = 23;
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.Black;
            this.Left.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Left.ForeColor = System.Drawing.Color.White;
            this.Left.Location = new System.Drawing.Point(283, 196);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(73, 53);
            this.Left.TabIndex = 31;
            this.Left.Text = "Left";
            this.Left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.Black;
            this.Right.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Right.ForeColor = System.Drawing.Color.White;
            this.Right.Location = new System.Drawing.Point(441, 196);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(73, 53);
            this.Right.TabIndex = 30;
            this.Right.Text = "Right";
            this.Right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Down
            // 
            this.Down.BackColor = System.Drawing.Color.Black;
            this.Down.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Down.ForeColor = System.Drawing.Color.White;
            this.Down.Location = new System.Drawing.Point(362, 196);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(73, 53);
            this.Down.TabIndex = 29;
            this.Down.Text = "Down";
            this.Down.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Up
            // 
            this.Up.BackColor = System.Drawing.Color.Black;
            this.Up.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Up.ForeColor = System.Drawing.Color.White;
            this.Up.Location = new System.Drawing.Point(362, 137);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(73, 53);
            this.Up.TabIndex = 28;
            this.Up.Text = "Up";
            this.Up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.Black;
            this.A.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.A.ForeColor = System.Drawing.Color.White;
            this.A.Location = new System.Drawing.Point(21, 196);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(73, 53);
            this.A.TabIndex = 27;
            this.A.Text = "A";
            this.A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.A.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.Black;
            this.D.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.D.ForeColor = System.Drawing.Color.White;
            this.D.Location = new System.Drawing.Point(179, 196);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(73, 53);
            this.D.TabIndex = 26;
            this.D.Text = "D";
            this.D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.D.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.D.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // S
            // 
            this.S.BackColor = System.Drawing.Color.Black;
            this.S.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.S.ForeColor = System.Drawing.Color.White;
            this.S.Location = new System.Drawing.Point(100, 196);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(73, 53);
            this.S.TabIndex = 25;
            this.S.Text = "S";
            this.S.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.S.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.S.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // W
            // 
            this.W.BackColor = System.Drawing.Color.Black;
            this.W.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.W.ForeColor = System.Drawing.Color.White;
            this.W.Location = new System.Drawing.Point(100, 137);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(73, 53);
            this.W.TabIndex = 24;
            this.W.Text = "W";
            this.W.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.W.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.W.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // FrozenText
            // 
            this.FrozenText.AutoEllipsis = true;
            this.FrozenText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrozenText.Location = new System.Drawing.Point(-1, 127);
            this.FrozenText.Name = "FrozenText";
            this.FrozenText.Size = new System.Drawing.Size(534, 150);
            this.FrozenText.TabIndex = 23;
            this.FrozenText.Text = "frozen_message";
            this.FrozenText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FrozenText.Visible = false;
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ErrorPanel.Controls.Add(this.Error);
            this.ErrorPanel.Location = new System.Drawing.Point(-2, 358);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(532, 22);
            this.ErrorPanel.TabIndex = 33;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.Color.Transparent;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.ForeColor = System.Drawing.Color.White;
            this.Error.Location = new System.Drawing.Point(3, 5);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(41, 13);
            this.Error.TabIndex = 6;
            this.Error.Text = "Ready!";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TopPanel.Controls.Add(this.Events);
            this.TopPanel.Controls.Add(this.Maximize);
            this.TopPanel.Controls.Add(this.Settings);
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Location = new System.Drawing.Point(-1, -1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(532, 22);
            this.TopPanel.TabIndex = 32;
            // 
            // Events
            // 
            this.Events.AutoEllipsis = true;
            this.Events.BackColor = System.Drawing.Color.Transparent;
            this.Events.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Events.Image = global::Controls.Joysticks.Properties.Resources.Event_594_exp;
            this.Events.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Events.Location = new System.Drawing.Point(465, 3);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(20, 17);
            this.Events.TabIndex = 24;
            this.Events.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Events.Click += new System.EventHandler(this.Events_Click);
            // 
            // Maximize
            // 
            this.Maximize.AutoEllipsis = true;
            this.Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Maximize.Image = global::Controls.Joysticks.Properties.Resources.Resize;
            this.Maximize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Maximize.Location = new System.Drawing.Point(510, 3);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(20, 17);
            this.Maximize.TabIndex = 23;
            this.Maximize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Settings
            // 
            this.Settings.AutoEllipsis = true;
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Settings.Image = global::Controls.Joysticks.Properties.Resources.properties_16xLG;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(487, 3);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(20, 17);
            this.Settings.TabIndex = 22;
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Title.Location = new System.Drawing.Point(3, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(106, 13);
            this.Title.TabIndex = 6;
            this.Title.Text = "Two-Sided Keyboard";
            // 
            // OverheadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.Border);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "OverheadForm";
            this.Size = new System.Drawing.Size(532, 381);
            this.Enter += new System.EventHandler(this.Control_Enter);
            this.Leave += new System.EventHandler(this.Control_Leave);
            this.Resize += new System.EventHandler(this.Control_Resize);
            this.Border.ResumeLayout(false);
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Border;
        private new System.Windows.Forms.Label Left;
        private new System.Windows.Forms.Label Right;
        private System.Windows.Forms.Label Down;
        private System.Windows.Forms.Label Up;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label W;
        private System.Windows.Forms.Label FrozenText;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Panel TopPanel;
        private new System.Windows.Forms.Label Events;
        private System.Windows.Forms.Label Maximize;
        private System.Windows.Forms.Label Settings;
        private System.Windows.Forms.Label Title;


    }
}
