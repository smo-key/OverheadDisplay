namespace OverheadDisplay.Bases
{
    partial class OverheadSettingsBase
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.PropTab = new System.Windows.Forms.TabPage();
            this.ActionTab = new System.Windows.Forms.TabPage();
            this.Properties = new System.Windows.Forms.Button();
            this.Actions = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Version = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.Publisher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Numpad = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Border.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.PropTab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.Controls.Add(this.panel1);
            this.Border.Controls.Add(this.Actions);
            this.Border.Controls.Add(this.Tabs);
            this.Border.Controls.Add(this.Properties);
            this.Border.Size = new System.Drawing.Size(555, 394);
            this.Border.Controls.SetChildIndex(this.Properties, 0);
            this.Border.Controls.SetChildIndex(this.Tabs, 0);
            this.Border.Controls.SetChildIndex(this.Actions, 0);
            this.Border.Controls.SetChildIndex(this.TopPanel, 0);
            this.Border.Controls.SetChildIndex(this.Resizer, 0);
            this.Border.Controls.SetChildIndex(this.panel1, 0);
            // 
            // Resizer
            // 
            this.Resizer.Location = new System.Drawing.Point(534, 373);
            this.Resizer.Visible = false;
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(555, 22);
            // 
            // View
            // 
            this.View.FlatAppearance.BorderSize = 0;
            this.View.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.View.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.Location = new System.Drawing.Point(503, -3);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(104, 13);
            this.Title.Text = "Overhead Properties";
            // 
            // CloseForm
            // 
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.CloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.Location = new System.Drawing.Point(527, -2);
            // 
            // Tabs
            // 
            this.Tabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Tabs.Controls.Add(this.PropTab);
            this.Tabs.Controls.Add(this.ActionTab);
            this.Tabs.Location = new System.Drawing.Point(-8, 45);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(573, 349);
            this.Tabs.TabIndex = 25;
            // 
            // PropTab
            // 
            this.PropTab.BackColor = System.Drawing.SystemColors.Control;
            this.PropTab.Controls.Add(this.flowLayoutPanel1);
            this.PropTab.Location = new System.Drawing.Point(4, 4);
            this.PropTab.Name = "PropTab";
            this.PropTab.Padding = new System.Windows.Forms.Padding(3);
            this.PropTab.Size = new System.Drawing.Size(565, 323);
            this.PropTab.TabIndex = 0;
            this.PropTab.Text = "Properties";
            // 
            // ActionTab
            // 
            this.ActionTab.BackColor = System.Drawing.SystemColors.Control;
            this.ActionTab.Location = new System.Drawing.Point(4, 4);
            this.ActionTab.Name = "ActionTab";
            this.ActionTab.Padding = new System.Windows.Forms.Padding(3);
            this.ActionTab.Size = new System.Drawing.Size(547, 320);
            this.ActionTab.TabIndex = 1;
            this.ActionTab.Text = "Actions";
            // 
            // Properties
            // 
            this.Properties.AutoEllipsis = true;
            this.Properties.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Properties.FlatAppearance.BorderSize = 0;
            this.Properties.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Properties.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Properties.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Properties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Properties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Properties.ForeColor = System.Drawing.Color.White;
            this.Properties.Image = global::OverheadDisplay.Properties.Resources.properties_16xLG;
            this.Properties.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Properties.Location = new System.Drawing.Point(0, 22);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(83, 24);
            this.Properties.TabIndex = 26;
            this.Properties.Text = "       Properties";
            this.Properties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Properties.UseVisualStyleBackColor = false;
            // 
            // Actions
            // 
            this.Actions.AutoEllipsis = true;
            this.Actions.BackColor = System.Drawing.SystemColors.Control;
            this.Actions.FlatAppearance.BorderSize = 0;
            this.Actions.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Actions.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.Actions.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Actions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Actions.Image = global::OverheadDisplay.Properties.Resources.Event_594_exp;
            this.Actions.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Actions.Location = new System.Drawing.Point(83, 21);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(83, 24);
            this.Actions.TabIndex = 27;
            this.Actions.Text = "       Actions";
            this.Actions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Actions.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 2);
            this.panel1.TabIndex = 28;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(526, 375);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Version);
            this.panel2.Controls.Add(this.Copyright);
            this.panel2.Controls.Add(this.Publisher);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 71);
            this.panel2.TabIndex = 24;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.ForeColor = System.Drawing.Color.Black;
            this.Version.Location = new System.Drawing.Point(2, 53);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(42, 13);
            this.Version.TabIndex = 27;
            this.Version.Text = "Version";
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.BackColor = System.Drawing.Color.Transparent;
            this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyright.ForeColor = System.Drawing.Color.Black;
            this.Copyright.Location = new System.Drawing.Point(2, 40);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(51, 13);
            this.Copyright.TabIndex = 26;
            this.Copyright.Text = "Copyright";
            // 
            // Publisher
            // 
            this.Publisher.AutoSize = true;
            this.Publisher.BackColor = System.Drawing.Color.Transparent;
            this.Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher.ForeColor = System.Drawing.Color.Black;
            this.Publisher.Location = new System.Drawing.Point(2, 27);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(50, 13);
            this.Publisher.TabIndex = 25;
            this.Publisher.Text = "Publisher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Information";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 84);
            this.panel4.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(2, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Connection";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Numpad);
            this.panel3.Location = new System.Drawing.Point(3, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 50);
            this.panel3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Controls";
            // 
            // Numpad
            // 
            this.Numpad.AutoSize = true;
            this.Numpad.Location = new System.Drawing.Point(5, 29);
            this.Numpad.Name = "Numpad";
            this.Numpad.Size = new System.Drawing.Size(141, 17);
            this.Numpad.TabIndex = 23;
            this.Numpad.Text = "Use Numberpad Instead";
            this.Numpad.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = global::OverheadDisplay.Properties.Resources.StatusAnnotations_Complete_and_ok_16xLG_color;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(0, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "       myNXT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Image = global::OverheadDisplay.Properties.Resources.refresh_16xLG;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(0, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "       Change Connection...";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Image = global::OverheadDisplay.Properties.Resources.Symbols_Critical_16xLG;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(0, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "       Disconnect this Overhead";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OverheadSettingsBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 394);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "OverheadSettingsBase";
            this.title = "Overhead Properties";
            this.Border.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.PropTab.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage PropTab;
        private System.Windows.Forms.TabPage ActionTab;
        protected System.Windows.Forms.Button Properties;
        protected System.Windows.Forms.Button Actions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Numpad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
