using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverheadDisplay.Controls
{
    public enum ErrorCriticality { Critical, Error, Warning, Info, Question, OK }
    public sealed partial class ErrorPopup : Bases.PopupBase
    {
        public ErrorPopup(Bases.DesignBase reference, ErrorCriticality criticality, string message)
            : base(reference)
        {
            if (Utils.Referenced)
            {
                InitializeComponent();
                this.DoubleBuffered = true;
                EnableActivation();
            }
            else { this.Dispose(); }

            Info.Text = message;
            switch (criticality)
            {
                case ErrorCriticality.Critical:
                    Continue.Visible = false;
                    Image.Image = global::OverheadDisplay.Properties.Resources.StatusAnnotations_Critical_32xLG_color;
                    title = "Critical Error";
                    break;
                case ErrorCriticality.Error:
                    Image.Image = global::OverheadDisplay.Properties.Resources.StatusAnnotations_Critical_32xLG_color;
                    title = "Error";
                    break;
                case ErrorCriticality.Warning:
                    Terminate.Visible = false;
                    Image.Image = global::OverheadDisplay.Properties.Resources.Warning_yellow_7231_31x32;
                    title = "Warning";
                    break;
                case ErrorCriticality.Info:
                    Terminate.Visible = false;
                    Image.Image = global::OverheadDisplay.Properties.Resources.Information_6227_32x;
                    title = "Info";
                    break;
                case ErrorCriticality.Question:
                    Continue.Text = "Yes";
                    Terminate.Text = "No";
                    Image.Image = global::OverheadDisplay.Properties.Resources.StatusAnnotations_Help_and_inconclusive_32xLG_color;
                    title = "Overhead Display";
                    break;
                case ErrorCriticality.OK:
                    Terminate.Visible = false;
                    Image.Image = global::OverheadDisplay.Properties.Resources.StatusAnnotations_Complete_and_ok_32xLG_color;
                    title = "Overhead Display";
                    break;
                default:
                    throw new Exception("The error management scheme ran into a critical problem.");
            }
        }

        public bool status { get; private set; }

        internal override void Control_Resize(object sender, EventArgs e)
        {
            base.Control_Resize(sender, e);
        }

        internal override void CloseForm_Click(object sender, EventArgs e)
        {
            base.CloseForm_Click(sender, e);
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            if (Continue.Text == "Continue")
            {
                this.Close();
            }
            else
            {
                status = true;
                this.Close(); 
            }
        }

        private void Terminate_Click(object sender, EventArgs e)
        {
            if (Terminate.Text == "Terminate")
            {
                Application.Exit();
            }
            else
            {
                status = false;
                this.Close();                
            }
        }

    }
}
