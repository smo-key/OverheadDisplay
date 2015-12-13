using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NXTLib;
using System.IO.Ports;

namespace BluetoothLibTester2
{
    public partial class Tester : Form
    {
        NXTLib.Brick brick = new Brick(Brick.LinkType.Bluetooth, "COM3");
        public Tester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            brick = new NXTLib.Brick(Brick.LinkType.Bluetooth,this.textBox1.Text);
            if (brick.ProtocolLink.Connect() == false) { Status.Text = brick.LastError; } else { Status.Text = "Connected!"; };     
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (brick.ProtocolLink.Disconnect() == false) { Status.Text = brick.ProtocolLink.LastError; } else { Status.Text = "Disconnected!"; };
        }
                
    }
}