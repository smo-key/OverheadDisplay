namespace Win8_TouchJoystick
{
    partial class Win8TouchJoystick
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ErrorPanel.Controls.Add(this.Error);
            this.ErrorPanel.Location = new System.Drawing.Point(-1, 359);
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
            this.TopPanel.Controls.Add(this.Settings);
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(532, 22);
            this.TopPanel.TabIndex = 32;
            // 
            // Settings
            // 
            this.Settings.AutoEllipsis = true;
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.Title.Size = new System.Drawing.Size(189, 13);
            this.Title.TabIndex = 6;
            this.Title.Text = "Two-Sided Windows 8 Touch Joystick";
            // 
            // FrozenText
            // 
            this.FrozenText.AutoEllipsis = true;
            this.FrozenText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrozenText.Location = new System.Drawing.Point(1, 128);
            this.FrozenText.Name = "FrozenText";
            this.FrozenText.Size = new System.Drawing.Size(534, 150);
            this.FrozenText.TabIndex = 23;
            this.FrozenText.Text = "frozen_message";
            this.FrozenText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FrozenText.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "label2";
            // 
            // Win8TouchJoystick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.FrozenText);
            this.Name = "Win8TouchJoystick";
            this.Size = new System.Drawing.Size(532, 418);
            this.Load += new System.EventHandler(this.Win8TouchJoystick_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win8TouchJoystick_MouseMove);
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Settings;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label FrozenText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
