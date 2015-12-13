namespace OverheadDisplay.Dev
{
    partial class PopupTemplate
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
            this.Border.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.Size = new System.Drawing.Size(295, 279);
            // 
            // Resizer
            // 
            this.Resizer.Location = new System.Drawing.Point(274, 258);
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
            this.View.Location = new System.Drawing.Point(243, -3);
            // 
            // Close
            // 
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.CloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.Location = new System.Drawing.Point(267, -2);
            // 
            // ControlTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "ControlTemplate";
            this.Size = new System.Drawing.Size(295, 279);
            this.Border.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
