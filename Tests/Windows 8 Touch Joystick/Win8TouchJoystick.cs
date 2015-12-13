using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Win8_TouchJoystick
{
    public partial class Win8TouchJoystick : UserControl
    {
        
        public Win8TouchJoystick()
        {
            InitializeComponent();
            
            
        }

        private void Win8TouchJoystick_Load(object sender, EventArgs e)
        {

        }

        private void Win8TouchJoystick_MouseMove(object sender, MouseEventArgs e)
        {
            Windows.Devices.Input.MouseDelta d = new Windows.Devices.Input.MouseDelta();
            label1.Text = d.X.ToString();
            label2.Text = d.Y.ToString();
        }
    }
}
