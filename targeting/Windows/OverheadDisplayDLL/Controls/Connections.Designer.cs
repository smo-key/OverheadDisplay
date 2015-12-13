namespace OverheadDisplay.Controls
{
    partial class Connections
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
            this.Selected = new System.Windows.Forms.Button();
            this.Other = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Rename = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Border.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.List.SuspendLayout();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.Controls.Add(this.List);
            this.Border.Controls.Add(this.Refresh);
            this.Border.Controls.Add(this.Disconnect);
            this.Border.Controls.Add(this.Rename);
            this.Border.Controls.Add(this.Info);
            this.Border.Controls.Add(this.Other);
            this.Border.Controls.Add(this.Selected);
            this.Border.Size = new System.Drawing.Size(300, 269);
            this.Border.Controls.SetChildIndex(this.Selected, 0);
            this.Border.Controls.SetChildIndex(this.Other, 0);
            this.Border.Controls.SetChildIndex(this.Info, 0);
            this.Border.Controls.SetChildIndex(this.TopPanel, 0);
            this.Border.Controls.SetChildIndex(this.Rename, 0);
            this.Border.Controls.SetChildIndex(this.Disconnect, 0);
            this.Border.Controls.SetChildIndex(this.Refresh, 0);
            this.Border.Controls.SetChildIndex(this.List, 0);
            this.Border.Controls.SetChildIndex(this.Resizer, 0);
            // 
            // Resizer
            // 
            this.Resizer.Location = new System.Drawing.Point(279, 248);
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(300, 22);
            // 
            // View
            // 
            this.View.FlatAppearance.BorderSize = 0;
            this.View.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.View.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.Location = new System.Drawing.Point(248, -3);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(66, 13);
            this.Title.Text = "Connections";
            // 
            // CloseForm
            // 
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.CloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.Location = new System.Drawing.Point(272, -2);
            // 
            // Selected
            // 
            this.Selected.AutoEllipsis = true;
            this.Selected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Selected.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Selected.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Selected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selected.Image = global::OverheadDisplay.Properties.Resources.StatusAnnotations_Complete_and_ok_32xLG_color;
            this.Selected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Selected.Location = new System.Drawing.Point(5, 27);
            this.Selected.Name = "Selected";
            this.Selected.Size = new System.Drawing.Size(288, 43);
            this.Selected.TabIndex = 29;
            this.Selected.Text = "         NXT1";
            this.Selected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Selected.UseVisualStyleBackColor = true;
            this.Selected.Click += new System.EventHandler(this.Selected_Click);
            // 
            // Other
            // 
            this.Other.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Other.FlatAppearance.BorderSize = 0;
            this.Other.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Other.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Other.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Other.Image = global::OverheadDisplay.Properties.Resources.Intellitrace_stepover;
            this.Other.Location = new System.Drawing.Point(270, 29);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(21, 39);
            this.Other.TabIndex = 30;
            this.Other.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Other.UseVisualStyleBackColor = true;
            this.Other.Click += new System.EventHandler(this.Other_Click);
            // 
            // Info
            // 
            this.Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Info.Location = new System.Drawing.Point(3, 77);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(206, 43);
            this.Info.TabIndex = 32;
            this.Info.Text = "Device: NXT\r\nStatus: Connected\r\nPort: Bluetooth COM3\r\n";
            // 
            // List
            // 
            this.List.AutoScroll = true;
            this.List.Controls.Add(this.label4);
            this.List.Controls.Add(this.label2);
            this.List.Controls.Add(this.label3);
            this.List.Controls.Add(this.label5);
            this.List.Controls.Add(this.label6);
            this.List.Controls.Add(this.label7);
            this.List.Controls.Add(this.label8);
            this.List.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.List.Location = new System.Drawing.Point(5, 123);
            this.List.Margin = new System.Windows.Forms.Padding(0);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(286, 128);
            this.List.TabIndex = 33;
            this.List.WrapContents = false;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Image = global::OverheadDisplay.Properties.Resources.gear_16xLG;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "       Motor A <Nothing>";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Image = global::OverheadDisplay.Properties.Resources.gear_16xLG;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "       Motor B <Nothing>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Image = global::OverheadDisplay.Properties.Resources.gear_16xLG;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "       Motor C <Nothing>";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Image = global::OverheadDisplay.Properties.Resources.ASCube_16xLG;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "       Sensor 1 <No Sensor>";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Image = global::OverheadDisplay.Properties.Resources.ASCube_16xLG;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "       Sensor 2 <No Sensor>";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.Image = global::OverheadDisplay.Properties.Resources.ASCube_16xLG;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(3, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "       Sensor 3 <No Sensor>";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.Image = global::OverheadDisplay.Properties.Resources.ASCube_16xLG;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(3, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "       Sensor 4 <No Sensor>";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Disconnect
            // 
            this.Disconnect.AutoEllipsis = true;
            this.Disconnect.BackColor = System.Drawing.Color.Transparent;
            this.Disconnect.FlatAppearance.BorderSize = 0;
            this.Disconnect.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Disconnect.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Disconnect.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Disconnect.Image = global::OverheadDisplay.Properties.Resources.Symbols_Critical_16xLG;
            this.Disconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Disconnect.Location = new System.Drawing.Point(269, 76);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(24, 24);
            this.Disconnect.TabIndex = 34;
            this.Disconnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTips.SetToolTip(this.Disconnect, "Disconnect");
            this.Disconnect.UseVisualStyleBackColor = false;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Rename
            // 
            this.Rename.AutoEllipsis = true;
            this.Rename.BackColor = System.Drawing.Color.Transparent;
            this.Rename.FlatAppearance.BorderSize = 0;
            this.Rename.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rename.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Rename.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rename.ForeColor = System.Drawing.Color.Transparent;
            this.Rename.Image = global::OverheadDisplay.Properties.Resources.PendingRenameOrMove_13300;
            this.Rename.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Rename.Location = new System.Drawing.Point(215, 76);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(24, 24);
            this.Rename.TabIndex = 35;
            this.Rename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTips.SetToolTip(this.Rename, "Rename");
            this.Rename.UseVisualStyleBackColor = false;
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
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
            this.Refresh.Location = new System.Drawing.Point(242, 76);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(24, 24);
            this.Refresh.TabIndex = 36;
            this.Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTips.SetToolTip(this.Refresh, "Refresh");
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Connections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "Connections";
            this.Size = new System.Drawing.Size(300, 269);
            this.title = "Connections";
            this.Border.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.List.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Selected;
        private System.Windows.Forms.Button Other;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.FlowLayoutPanel List;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Rename;
        private new System.Windows.Forms.Button Refresh;

    }
}
