namespace OverheadDisplay.Controls
{
    partial class ErrorPopup
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
            this.Info = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.Image = new System.Windows.Forms.PictureBox();
            this.Terminate = new System.Windows.Forms.Button();
            this.Border.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.Controls.Add(this.Terminate);
            this.Border.Controls.Add(this.Info);
            this.Border.Controls.Add(this.Continue);
            this.Border.Controls.Add(this.Image);
            this.Border.Size = new System.Drawing.Size(286, 150);
            this.Border.Controls.SetChildIndex(this.TopPanel, 0);
            this.Border.Controls.SetChildIndex(this.Image, 0);
            this.Border.Controls.SetChildIndex(this.Continue, 0);
            this.Border.Controls.SetChildIndex(this.Info, 0);
            this.Border.Controls.SetChildIndex(this.Terminate, 0);
            this.Border.Controls.SetChildIndex(this.Resizer, 0);
            // 
            // Resizer
            // 
            this.Resizer.Location = new System.Drawing.Point(265, 129);
            this.Resizer.Visible = false;
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(286, 22);
            // 
            // View
            // 
            this.View.FlatAppearance.BorderSize = 0;
            this.View.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.View.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.Location = new System.Drawing.Point(234, -3);
            this.View.Visible = false;
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(29, 13);
            this.Title.Text = "Error";
            // 
            // Close
            // 
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.CloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.Location = new System.Drawing.Point(258, -2);
            this.CloseForm.Visible = false;
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(41, 27);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(216, 87);
            this.Info.TabIndex = 27;
            this.Info.Text = "Library \'OverheadDisplayDLL\' is corrupted.";
            // 
            // Continue
            // 
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Continue.Location = new System.Drawing.Point(42, 117);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(129, 23);
            this.Continue.TabIndex = 26;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Image
            // 
            this.Image.Image = global::OverheadDisplay.Properties.Resources.StatusAnnotations_Critical_32xLG_color;
            this.Image.Location = new System.Drawing.Point(5, 27);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(32, 32);
            this.Image.TabIndex = 25;
            this.Image.TabStop = false;
            // 
            // Terminate
            // 
            this.Terminate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Terminate.Location = new System.Drawing.Point(177, 117);
            this.Terminate.Name = "Terminate";
            this.Terminate.Size = new System.Drawing.Size(80, 23);
            this.Terminate.TabIndex = 28;
            this.Terminate.Text = "Terminate";
            this.Terminate.UseVisualStyleBackColor = true;
            this.Terminate.Click += new System.EventHandler(this.Terminate_Click);
            // 
            // ErrorPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 150);
            this.Name = "ErrorPopup";
            this.title = "Error";
            this.Border.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Terminate;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.PictureBox Image;
    }
}
