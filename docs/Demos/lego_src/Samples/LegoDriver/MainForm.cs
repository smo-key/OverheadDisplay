// Driving Lego Robot application
//
// Copyright © Andrew Kirillov, 2008
// andrew.kirillov@gmail.com
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using AForge.Robotics.Lego;
using AForge.Video;
using AForge.Video.DirectShow;

namespace LegoDriver
{
    public partial class MainForm : Form
    {
        private ILegoDriver legoDriver = null;
        private FilterInfoCollection videoDevices;

        // maximum motors' power for 5 sectors 
        private float[] maxPowers = new float[] { 0.1f, 0.4f, 1.0f, 1.0f, 1.0f };

        // background thread and objects used for synchronization
        private Thread thread = null;
        private AutoResetEvent needToDriveEvent = null;
        private bool needToExit = false;

        // motors' power to set
        private float leftMotorPower  = 0;
        private float rightMotorPower = 0;

        // Constructor
        public MainForm( )
        {
            InitializeComponent( );

            modelCombo.SelectedIndex = 1;
            portBox.Text = "COM8";

            // show device list
            try
            {
                // enumerate video devices
                videoDevices = new FilterInfoCollection( FilterCategory.VideoInputDevice );

                if ( videoDevices.Count == 0 )
                    throw new ApplicationException( );

                // add all devices to combo
                foreach ( FilterInfo device in videoDevices )
                {
                    devicesCombo.Items.Add( device.Name );
                }

                devicesCombo.SelectedIndex = 0;
            }
            catch ( ApplicationException )
            {
                devicesCombo.Items.Add( "No local capture devices" );
                devicesCombo.Enabled = false;
                cameraConnectButton.Enabled = false;

                videoDevices = null;
            }
        }

        // On main form closing
        private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
        {
            Disconnect( );

            videoSourcePlayer.SignalToStop( );
            videoSourcePlayer.WaitForStop( );
        }

        // Position of direction/power manipulator was changed
        private void manipulatorControl_PositionChanged( float x, float y )
        {
            lock ( this )
            {
                if ( ( x == 0 ) && ( y == 0 ) )
                {
                    // stop the car
                    leftMotorPower = rightMotorPower = 0;
                }
                else
                {
                    // radius (distance from center)
                    double r = Math.Min( Math.Sqrt( x * x + y * y ), 1.0 );
                    // theta
                    double t = 0;

                    // calculate theta
                    if ( x != 0 )
                    {
                        t = Math.Atan( y / x );
                        t = t / Math.PI * 180;

                        if ( t < 0 )
                        {
                            t = 180.0 + t;
                        }
                    }
                    else
                    {
                        t = 90;
                    }

                    // index of maximum power
                    int maxPowerIndex = (int) ( t / 36 );

                    // check direction to move
                    if ( y > 0 )
                    {
                        // forward direction
                        leftMotorPower  = (float) ( r * maxPowers[4 - maxPowerIndex] );
                        rightMotorPower = (float) ( r * maxPowers[maxPowerIndex] );
                    }
                    else
                    {
                        // backward direction
                        leftMotorPower  = (float) ( -r * maxPowers[maxPowerIndex] );
                        rightMotorPower = (float) ( -r * maxPowers[4 - maxPowerIndex] );
                    }
                }
            }

            // signal background thread to set new motors' power
            needToDriveEvent.Set( );
        }

        // Position of turning manipulator was changed
        private void turnControl_PositionChanged( float x )
        {
            lock ( this )
            {
                leftMotorPower  =  x;
                rightMotorPower = -x;
            }
            needToDriveEvent.Set( );
        }

        // Enable/disable controls
        private void EnableControls( bool enable )
        {
            manipulatorControl.Enabled = enable;
            turnControl.Enabled = enable;
            disconnectButton.Enabled = enable;

            connectButton.Enabled = !enable;
            modelCombo.Enabled = !enable;
            portBox.Enabled = ( !enable && modelCombo.SelectedIndex == 1 );
        }

        // On Connect button clicked
        private void connectButton_Click( object sender, EventArgs e )
        {
            if ( modelCombo.SelectedIndex == 0 )
            {
                legoDriver = new RCXDriver( );
            }
            else
            {
                legoDriver = new NXTDriver( portBox.Text );
            }

            if ( !legoDriver.Connect( ) )
            {
                MessageBox.Show( "Failed connecting to Lego brick", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                legoDriver = null;
            }
            else
            {
                // create event used to signal thread about updates to power state
                needToDriveEvent = new AutoResetEvent( false );
                needToExit = false;

                // create background thread wich drives Lego
                thread = new Thread( new ThreadStart( WorkerThread ) );
                thread.Start( );

                EnableControls( true );
            }
        }

        // On Disconnect button clicked
        private void disconnectButton_Click( object sender, EventArgs e )
        {
            EnableControls( false );
            Disconnect( );
        }

        // Disconnect from Lego device
        private void Disconnect( )
        {
            if ( thread != null )
            {
                // stop background thread
                needToExit = true;
                needToDriveEvent.Set( );
                thread.Join( );

                needToDriveEvent.Close( );
                needToDriveEvent = null;
                thread = null;

                legoDriver.Disconnect( );
                legoDriver = null;
            }
        }

        // Worker thread which is used to set motors' power
        private void WorkerThread( )
        {
            float newLeftMotorPower  = 0;
            float newRightMotorPower = 0;

            while ( true )
            {
                // wait for events
                needToDriveEvent.WaitOne( );

                // does thread should exit?
                if ( needToExit )
                    break;

                lock ( this )
                {
                    newLeftMotorPower  = leftMotorPower;
                    newRightMotorPower = rightMotorPower;
                }

                legoDriver.SetMotorsPower( newLeftMotorPower, newRightMotorPower );
            }
        }

        // Selection changed in Model combo
        private void modelCombo_SelectedIndexChanged( object sender, EventArgs e )
        {
            portBox.Enabled = ( modelCombo.SelectedIndex == 1 );
        }

        // On Camera Connect button clieck
        private void cameraConnectButton_Click( object sender, EventArgs e )
        {
            VideoCaptureDevice videoSouce = new VideoCaptureDevice( videoDevices[devicesCombo.SelectedIndex].MonikerString );
            videoSouce.DesiredFrameSize = new Size( 360, 288 );

            videoSourcePlayer.VideoSource = videoSouce;
            videoSourcePlayer.Start( );

            cameraConnectButton.Enabled = false;
            cameraDisconnectButton.Enabled = true;
        }

        // On Camera Disconnect button clieck
        private void cameraDisconnectButton_Click( object sender, EventArgs e )
        {
            videoSourcePlayer.SignalToStop( );
            videoSourcePlayer.WaitForStop( );

            cameraConnectButton.Enabled = true;
            cameraDisconnectButton.Enabled = false;
        }
    }
}
