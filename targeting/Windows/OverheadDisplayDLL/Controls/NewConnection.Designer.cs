namespace OverheadDisplay.Controls
{
    partial class NewConnection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.ConnName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.Online = new System.Windows.Forms.Button();
            this.Border.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.List.SuspendLayout();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.Controls.Add(this.Port);
            this.Border.Controls.Add(this.label8);
            this.Border.Controls.Add(this.Type);
            this.Border.Controls.Add(this.label7);
            this.Border.Controls.Add(this.label6);
            this.Border.Controls.Add(this.ConnName);
            this.Border.Controls.Add(this.Connect);
            this.Border.Controls.Add(this.label4);
            this.Border.Controls.Add(this.label2);
            this.Border.Controls.Add(this.List);
            this.Border.Size = new System.Drawing.Size(286, 405);
            this.Border.Controls.SetChildIndex(this.List, 0);
            this.Border.Controls.SetChildIndex(this.TopPanel, 0);
            this.Border.Controls.SetChildIndex(this.label2, 0);
            this.Border.Controls.SetChildIndex(this.label4, 0);
            this.Border.Controls.SetChildIndex(this.Connect, 0);
            this.Border.Controls.SetChildIndex(this.ConnName, 0);
            this.Border.Controls.SetChildIndex(this.label6, 0);
            this.Border.Controls.SetChildIndex(this.label7, 0);
            this.Border.Controls.SetChildIndex(this.Type, 0);
            this.Border.Controls.SetChildIndex(this.label8, 0);
            this.Border.Controls.SetChildIndex(this.Port, 0);
            this.Border.Controls.SetChildIndex(this.Resizer, 0);
            // 
            // Resizer
            // 
            this.Resizer.Location = new System.Drawing.Point(361, 390);
            this.Resizer.Visible = false;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.Online);
            this.TopPanel.Size = new System.Drawing.Size(286, 22);
            this.TopPanel.Controls.SetChildIndex(this.Title, 0);
            this.TopPanel.Controls.SetChildIndex(this.View, 0);
            this.TopPanel.Controls.SetChildIndex(this.CloseForm, 0);
            this.TopPanel.Controls.SetChildIndex(this.Online, 0);
            // 
            // View
            // 
            this.View.FlatAppearance.BorderSize = 0;
            this.View.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.View.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.Location = new System.Drawing.Point(210, -1);
            this.View.Visible = false;
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(86, 13);
            this.Title.Text = "New Connection";
            // 
            // CloseForm
            // 
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.CloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.Location = new System.Drawing.Point(258, -2);
            // 
            // List
            // 
            this.List.AutoScroll = true;
            this.List.Controls.Add(this.label1);
            this.List.Controls.Add(this.label3);
            this.List.Controls.Add(this.label5);
            this.List.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.List.Location = new System.Drawing.Point(5, 42);
            this.List.Margin = new System.Windows.Forms.Padding(0);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(274, 207);
            this.List.TabIndex = 26;
            this.List.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Image = global::OverheadDisplay.Properties.Resources.reference_16xLG;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "       NXT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Item_MouseClick);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Item_MouseDown);
            this.label1.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Item_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::OverheadDisplay.Properties.Resources.reference_16xLG;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "       Arduino";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Image = global::OverheadDisplay.Properties.Resources.reference_16xLG;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "       RCX";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Select a Device Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Device Settings";
            // 
            // Connect
            // 
            this.Connect.AutoEllipsis = true;
            this.Connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Connect.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Connect.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.Image = global::OverheadDisplay.Properties.Resources.StatusAnnotations_Complete_and_ok_32xLG_color;
            this.Connect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Connect.Location = new System.Drawing.Point(5, 355);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(274, 43);
            this.Connect.TabIndex = 30;
            this.Connect.Text = "         Connect";
            this.Connect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // ConnName
            // 
            this.ConnName.Location = new System.Drawing.Point(46, 275);
            this.ConnName.Name = "ConnName";
            this.ConnName.Size = new System.Drawing.Size(233, 20);
            this.ConnName.TabIndex = 31;
            this.ConnName.Text = "Arduino1";
            this.ConnName.TextChanged += new System.EventHandler(this.ConnName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(5, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(5, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Connect Via";
            // 
            // Type
            // 
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Bluetooth",
            "USB",
            "WiFi"});
            this.Type.Location = new System.Drawing.Point(77, 296);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(94, 21);
            this.Type.Sorted = true;
            this.Type.TabIndex = 34;
            this.Type.SelectedValueChanged += new System.EventHandler(this.Type_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(5, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Bluetooth COM Port";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(109, 320);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(62, 20);
            this.Port.TabIndex = 36;
            this.Port.TextChanged += new System.EventHandler(this.Port_TextChanged);
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
            this.Online.Location = new System.Drawing.Point(234, -2);
            this.Online.Name = "Online";
            this.Online.Size = new System.Drawing.Size(24, 24);
            this.Online.TabIndex = 28;
            this.Online.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTips.SetToolTip(this.Online, "Download Connection Drivers");
            this.Online.UseVisualStyleBackColor = false;
            this.Online.Click += new System.EventHandler(this.Online_Click);
            // 
            // NewConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 405);
            this.Name = "NewConnection";
            this.ShowInTaskbar = false;
            this.title = "New Connection";
            this.Border.ResumeLayout(false);
            this.Border.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.List.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ConnName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Online;


    }
}
