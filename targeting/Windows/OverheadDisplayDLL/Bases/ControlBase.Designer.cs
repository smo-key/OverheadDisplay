namespace OverheadDisplay.Bases
{
    partial class ControlBase
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
            this.components = new System.ComponentModel.Container();
            this.Border = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseForm = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Resizer = new OverheadDisplay.Controls.Resizer();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.Border.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Border.Controls.Add(this.TopPanel);
            this.Border.Controls.Add(this.Resizer);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(294, 276);
            this.Border.TabIndex = 25;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TopPanel.Controls.Add(this.CloseForm);
            this.TopPanel.Controls.Add(this.View);
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Location = new System.Drawing.Point(-1, -1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(294, 22);
            this.TopPanel.TabIndex = 23;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // CloseForm
            // 
            this.CloseForm.AutoEllipsis = true;
            this.CloseForm.BackColor = System.Drawing.Color.Transparent;
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.CloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseForm.Image = global::OverheadDisplay.Properties.Resources.Symbols_Critical_16xLG;
            this.CloseForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseForm.Location = new System.Drawing.Point(266, -2);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(24, 24);
            this.CloseForm.TabIndex = 23;
            this.CloseForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseForm.UseVisualStyleBackColor = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // View
            // 
            this.View.AutoEllipsis = true;
            this.View.BackColor = System.Drawing.Color.Transparent;
            this.View.Enabled = false;
            this.View.FlatAppearance.BorderSize = 0;
            this.View.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.View.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.View.Image = global::OverheadDisplay.Properties.Resources.Intellitrace_stepover;
            this.View.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.View.Location = new System.Drawing.Point(245, -3);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(24, 24);
            this.View.TabIndex = 22;
            this.View.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.View.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Title.Location = new System.Drawing.Point(3, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 6;
            this.Title.Text = "Title";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // Resizer
            // 
            this.Resizer.BackColor = System.Drawing.Color.Transparent;
            this.Resizer.distance = new System.Drawing.Point(21, 21);
            this.Resizer.IsPopup = false;
            this.Resizer.Location = new System.Drawing.Point(273, 255);
            this.Resizer.MaximumSize = new System.Drawing.Size(17, 17);
            this.Resizer.MinimumSize = new System.Drawing.Size(17, 17);
            this.Resizer.Name = "Resizer";
            this.Resizer.parent = this;
            this.Resizer.Size = new System.Drawing.Size(17, 17);
            this.Resizer.TabIndex = 24;
            // 
            // ControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Border);
            this.Name = "ControlBase";
            this.Size = new System.Drawing.Size(294, 276);
            this.Resize += new System.EventHandler(this.Control_Resize);
            this.Border.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel Border;
        protected Controls.Resizer Resizer;
        protected System.Windows.Forms.Panel TopPanel;
        protected System.Windows.Forms.Button View;
        protected System.Windows.Forms.Label Title;
        protected System.Windows.Forms.Button CloseForm;
        protected System.Windows.Forms.ToolTip ToolTips;


    }
}
