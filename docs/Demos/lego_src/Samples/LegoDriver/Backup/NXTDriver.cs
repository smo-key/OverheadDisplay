// Driving Lego Robot application
//
// Copyright © Andrew Kirillov, 2008
// andrew.kirillov@gmail.com
//

namespace LegoDriver
{
    using System;
    using AForge.Robotics.Lego;

    // Lego RCX car driver class
    public class NXTDriver : ILegoDriver
    {
        private NXTBrick nxt = new NXTBrick( );
        private string serialPort;
        // maximum power of NXT motors
        private int maxMotorPower = 100;

        // last power for each motor (required to avoid redundant calls to NXT API)
        private int lastLeftMotorPower  = 0;
        private int lastRightMotorPower = 0;

        // Constructor
        public NXTDriver( string serialPort )
        {
            this.serialPort = serialPort;
        }

        // Connect to Lego NXT brick
        public bool Connect( )
        {
            if ( !nxt.Connect( serialPort ) )
            {
                // failed to connect
                return false;
            }

            // play something on connection
            nxt.PlayTone( 300, 300 );

            return true;

        }

        // Disconnect from Lego NXT brick
        public void Disconnect( )
        {
            nxt.PlayTone( 150, 300 );
            nxt.Disconnect( );
        }

        // Set power of A anc C motor of Lego NXT brick
        public void SetMotorsPower( float leftMotor, float rightMotor )
        {
            int leftMotorPower  = (int) ( leftMotor  * maxMotorPower );
            int rightMotorPower = (int) ( rightMotor * maxMotorPower );

            // it was found that NXT's motors do not move if power is less than 50
            // the next code will make sure that power is distributed 50 to 100
            if ( leftMotorPower != 0 )
            {
                if ( leftMotorPower > 0 )
                    leftMotorPower =  50 + (int) ( 0.5 * leftMotorPower );
                else
                    leftMotorPower = -50 + (int) ( 0.5 * leftMotorPower );
            }
            if ( rightMotorPower != 0 )
            {
                if ( rightMotorPower > 0 )
                    rightMotorPower =  50 + (int) ( 0.5 * rightMotorPower );
                else
                    rightMotorPower = -50 + (int) ( 0.5 * rightMotorPower );
            }

            // System.Diagnostics.Debug.WriteLine( "l: " + leftMotorPower + ", r: " + rightMotorPower );

            // return if there are no changes
            if ( ( leftMotorPower == lastLeftMotorPower ) && ( rightMotorPower == lastRightMotorPower ) )
                return;

            // check if we need to stop
            if ( ( leftMotorPower == 0 ) && ( rightMotorPower == 0 ) )
            {
                NXTBrick.MotorState motorsState = new NXTBrick.MotorState( );

                motorsState.Mode = NXTBrick.MotorMode.None;
                motorsState.RunState = NXTBrick.MotorRunState.Idle;

                nxt.SetMotorState( NXTBrick.Motor.All, motorsState );
            }
            else
            {
                NXTBrick.MotorState leftMotorState  = new NXTBrick.MotorState( );
                NXTBrick.MotorState rightMotorState = new NXTBrick.MotorState( );

                // left motor settings
                leftMotorState.Mode       = NXTBrick.MotorMode.On;
                leftMotorState.RunState   = NXTBrick.MotorRunState.Running;
                leftMotorState.TachoLimit = 0;
                leftMotorState.Power      = leftMotorPower;
                leftMotorState.TurnRatio  = 50;

                rightMotorState.Mode       = NXTBrick.MotorMode.On;
                rightMotorState.RunState   = NXTBrick.MotorRunState.Running;
                rightMotorState.TachoLimit = 0;
                rightMotorState.Power      = rightMotorPower;
                rightMotorState.TurnRatio  = 50;

                nxt.SetMotorState( NXTBrick.Motor.A, leftMotorState );
                nxt.SetMotorState( NXTBrick.Motor.C, rightMotorState );
            }

            // remember current motors' power to avoid setting the same next time
            lastLeftMotorPower  = leftMotorPower;
            lastRightMotorPower = rightMotorPower;
        }
    }
}
