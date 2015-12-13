namespace OverheadDisplay.Controls
{
    partial class Rename
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Border.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.Controls.Add(this.NameBox);
            this.Border.Controls.Add(this.Cancel);
            this.Border.Controls.Add(this.Change);
            this.Border.Size = new System.Drawing.Size(278, 92);
            this.Border.Controls.SetChildIndex(this.TopPanel, 0);
            this.Border.Controls.SetChildIndex(this.Change, 0);
            this.Border.Controls.SetChildIndex(this.Cancel, 0);
            this.Border.Controls.SetChildIndex(this.NameBox, 0);
            this.Border.Controls.SetChildIndex(this.Resizer, 0);
            // 
            // Resizer
            // 
            this.Resizer.Location = new System.Drawing.Point(257, 71);
            this.Resizer.Visible = false;
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(278, 22);
            // 
            // View
            // 
            this.View.FlatAppearance.BorderSize = 0;
            this.View.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.View.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.Location = new System.Drawing.Point(226, -3);
            this.View.Visible = false;
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(47, 13);
            this.Title.Text = "Rename";
            // 
            // CloseForm
            // 
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.CloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.Location = new System.Drawing.Point(250, -2);
            this.CloseForm.Visible = false;
            // 
            // Cancel
            // 
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Location = new System.Drawing.Point(164, 59);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 23);
            this.Cancel.TabIndex = 30;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Change
            // 
            this.Change.Enabled = false;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Change.Location = new System.Drawing.Point(29, 59);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(129, 23);
            this.Change.TabIndex = 29;
            this.Change.Text = "Rename";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(29, 27);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(215, 27);
            this.NameBox.TabIndex = 31;
            this.NameBox.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 92);
            this.Name = "Rename";
            this.title = "Rename";
            this.Border.ResumeLayout(false);
            this.Border.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox NameBox;
    }
}
