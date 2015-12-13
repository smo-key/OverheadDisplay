namespace Touch_Joystick_Demo
{
    partial class TouchJoystickDemo
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
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.Error = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.FrozenText = new System.Windows.Forms.Label();
            this.ErrorPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ErrorPanel.Controls.Add(this.Error);
            this.ErrorPanel.Location = new System.Drawing.Point(0, 359);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(532, 22);
            this.ErrorPanel.TabIndex = 24;
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
            this.TopPanel.Controls.Add(this.Settings);
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(532, 22);
            this.TopPanel.TabIndex = 23;
            // 
            // Settings
            // 
            this.Settings.AutoEllipsis = true;
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Settings.Image = global::Touch_Joystick_Demo.Properties.Resources.properties_16xlg;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(509, 3);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(20, 17);
            this.Settings.TabIndex = 22;
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Title.Location = new System.Drawing.Point(3, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(163, 13);
            this.Title.TabIndex = 6;
            this.Title.Text = "Two-Sided Touch Jostick DEMO";
            // 
            // FrozenText
            // 
            this.FrozenText.AutoEllipsis = true;
            this.FrozenText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrozenText.Location = new System.Drawing.Point(-1, 115);
            this.FrozenText.Name = "FrozenText";
            this.FrozenText.Size = new System.Drawing.Size(534, 150);
            this.FrozenText.TabIndex = 25;
            this.FrozenText.Text = "frozen_message";
            this.FrozenText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FrozenText.Visible = false;
            // 
            // TouchJoystickDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FrozenText);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "TouchJoystickDemo";
            this.Size = new System.Drawing.Size(532, 381);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TouchJoystickDemo_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchJoystickDemo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TouchJoystickDemo_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TouchJoystickDemo_MouseUp);
            this.Resize += new System.EventHandler(this.TouchJoystickDemo_Resize);
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Settings;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label FrozenText;
    }
}
