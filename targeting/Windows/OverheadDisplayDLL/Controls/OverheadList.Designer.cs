namespace OverheadDisplay.Controls
{
    partial class OverheadList
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
            this.List = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.Online = new System.Windows.Forms.Button();
            this.Border.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.List.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.Controls.Add(this.Refresh);
            this.Border.Controls.Add(this.List);
            this.Border.Controls.Add(this.Online);
            this.Border.Size = new System.Drawing.Size(295, 397);
            this.Border.Controls.SetChildIndex(this.Online, 0);
            this.Border.Controls.SetChildIndex(this.List, 0);
            this.Border.Controls.SetChildIndex(this.Refresh, 0);
            this.Border.Controls.SetChildIndex(this.TopPanel, 0);
            this.Border.Controls.SetChildIndex(this.Resizer, 0);
            // 
            // Resizer
            // 
            this.Resizer.Location = new System.Drawing.Point(274, 376);
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(295, 22);
            // 
            // View
            // 
            this.View.FlatAppearance.BorderSize = 0;
            this.View.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.View.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.Location = new System.Drawing.Point(243, -2);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(59, 13);
            this.Title.Text = "Overheads";
            // 
            // Close
            // 
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.CloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.Location = new System.Drawing.Point(267, -2);
            this.ToolTips.SetToolTip(this.CloseForm, "Close");
            // 
            // List
            // 
            this.List.AutoScroll = true;
            this.List.Controls.Add(this.panel1);
            this.List.Controls.Add(this.panel2);
            this.List.Controls.Add(this.panel4);
            this.List.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.List.Location = new System.Drawing.Point(5, 54);
            this.List.Margin = new System.Windows.Forms.Padding(0);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(286, 326);
            this.List.TabIndex = 25;
            this.List.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 18);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Image = global::OverheadDisplay.Properties.Resources.folder_Open_16xLG;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "       Joysticks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 18);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Image = global::OverheadDisplay.Properties.Resources.ASCube_16xLG;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(16, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "       Two-Sided Keyboard Joystick";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 36);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 18);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Image = global::OverheadDisplay.Properties.Resources.folder_Closed_16xLG;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "       NXT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Refresh
            // 
            this.Refresh.AutoEllipsis = true;
            this.Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Refresh.FlatAppearance.BorderSize = 0;
            this.Refresh.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Refresh.Image = global::OverheadDisplay.Properties.Resources.refresh_16xLG;
            this.Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Refresh.Location = new System.Drawing.Point(31, 25);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(24, 24);
            this.Refresh.TabIndex = 26;
            this.Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTips.SetToolTip(this.Refresh, "Refresh");
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Online
            // 
            this.Online.AutoEllipsis = true;
            this.Online.BackColor = System.Drawing.Color.Transparent;
            this.Online.FlatAppearance.BorderSize = 0;
            this.Online.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Online.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Online.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Online.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Online.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Online.ForeColor = System.Drawing.Color.Transparent;
            this.Online.Image = global::OverheadDisplay.Properties.Resources.WebFormTemplate_11274_16x_color;
            this.Online.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Online.Location = new System.Drawing.Point(4, 25);
            this.Online.Name = "Online";
            this.Online.Size = new System.Drawing.Size(24, 24);
            this.Online.TabIndex = 27;
            this.Online.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTips.SetToolTip(this.Online, "Overheads Online");
            this.Online.UseVisualStyleBackColor = false;
            this.Online.Click += new System.EventHandler(this.Online_Click);
            // 
            // OverheadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "OverheadList";
            this.Size = new System.Drawing.Size(295, 397);
            this.title = "Overheads";
            this.Border.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.List.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private new System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Online;
    }
}
