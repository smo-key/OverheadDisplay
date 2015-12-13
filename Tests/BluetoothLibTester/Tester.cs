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

namespace BluetoothLibTester
{
    public partial class Tester : Form
    {
        SerialPort Bluetooth = new SerialPort();
        public Tester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort p = new SerialPort();
            p = NXTLib.Bluetooth.Connect(Bluetooth, textBox1.Text);
            if (p == null)
            {
                Status.Text = NXTLib.Error.lastError;
            }
            else
            {
                Bluetooth = p;
                Status.Text = "Connected!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NXTLib.Commands.Misc.StartProgram(Bluetooth, "samostat") == false)
            {
                Status.Text = NXTLib.Error.lastError;
            }
            else
            {
                Status.Text = "Action completed.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NXTLib.Commands.Misc.StopProgram(Bluetooth) == false)
            {
                Status.Text = NXTLib.Error.lastError;
            }
            else
            {
                Status.Text = "Action completed.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NXTLib.Commands.Misc.PlayTone(Bluetooth, (ushort)7000, (ushort)1000) == false)
            {
                Status.Text = NXTLib.Error.lastError;
            }
            else
            {
                Status.Text = "Action completed.";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (NXTLib.Commands.Misc.PlaySoundFile(Bluetooth, false, "Hooray") == false)
            {
                Status.Text = NXTLib.Error.lastError;
            }
            else
            {
                Status.Text = "Action completed.";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SerialPort p = NXTLib.Bluetooth.Disconnect(Bluetooth);
            if (p == null)
            {
                Status.Text = NXTLib.Error.lastError;
            }
            else
            {
                Bluetooth = p;
                Status.Text = "Disconnected!";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (NXTLib.Commands.Motors.MoveMotors(Bluetooth, Commands.Motors.MotorPort.A, 50) == false)
            {
                Status.Text = NXTLib.Error.lastError;
            }
            else
            {
                Status.Text = "Action completed.";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Tacho limit = time (ms)
            //To brake motors, set state to on+brake or on+brake+reg, then set pow to 0
            if (NXTLib.Commands.Motors.MoveMotors(Bluetooth, Commands.Motors.MotorPort.ABC, 0, Commands.Motors.MotorStop.Coast) == false)
            {
                Status.Text = NXTLib.Error.lastError;
            }
            else
            {
                Status.Text = "Action completed.";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NXTLib.Commands.Motors.MotorStateOut r = NXTLib.Commands.Motors.GetMotorState(Bluetooth, Commands.Motors.MotorPortSingle.A);
            if (r == null)
            {
                Status.Text = NXTLib.Error.lastError;
            }
            else
            {
                label3.Text = "Tach: " + r.tachocount.ToString();
                label4.Text = "B. Tach: " + r.blocktachocount.ToString();
                label5.Text = "Rot: " + r.rotationcount.ToString();
                Status.Text = "Data recieved.";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (NXTLib.Commands.Sensors.SetInputMode(Bluetooth, Commands.Sensors.SensorPort.Port_1
                , Commands.Sensors.SensorType.Switch, Commands.Sensors.SensorMode.Boolean) == false)
            {
                Status.Text = NXTLib.Error.lastError;
            }
            else
            {
                Status.Text = "Action completed.";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (NXTLib.Commands.Motors.ResetMotorPosition(Bluetooth, Commands.Motors.MotorPortSingle.A, true) == false)
            {
                Status.Text = NXTLib.Error.lastError;
            }
            else
            {
                Status.Text = "Action completed.";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}