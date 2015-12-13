namespace OverheadDisplay.Controls
{
    partial class OnlineOverheads
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Border.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.Controls.Add(this.label2);
            this.Border.Controls.Add(this.label1);
            this.Border.Size = new System.Drawing.Size(281, 200);
            this.Border.Controls.SetChildIndex(this.TopPanel, 0);
            this.Border.Controls.SetChildIndex(this.label1, 0);
            this.Border.Controls.SetChildIndex(this.label2, 0);
            this.Border.Controls.SetChildIndex(this.Resizer, 0);
            // 
            // Resizer
            // 
            this.Resizer.Location = new System.Drawing.Point(260, 179);
            this.Resizer.Visible = false;
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(281, 22);
            // 
            // View
            // 
            this.View.FlatAppearance.BorderSize = 0;
            this.View.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.View.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.Location = new System.Drawing.Point(229, -3);
            this.View.Visible = false;
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(92, 13);
            this.Title.Text = "Overheads Online";
            // 
            // Close
            // 
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.CloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.Location = new System.Drawing.Point(253, -2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 45);
            this.label1.TabIndex = 25;
            this.label1.Text = ":(";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Sorry, but Online Overheads are not available in this version of Overhead Display" +
    ".";
            // 
            // OnlineOverheads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "OnlineOverheads";
            this.Size = new System.Drawing.Size(281, 200);
            this.title = "Overheads Online";
            this.Border.ResumeLayout(false);
            this.Border.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
