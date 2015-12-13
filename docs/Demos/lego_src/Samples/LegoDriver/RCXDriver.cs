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
    public class RCXDriver : ILegoDriver
    {
        private RCXBrick rcx = new RCXBrick( );
        // maximum power of RCX motors
        private int maxMotorPower = 7;

        // last power for each motor (required to avoid redundant calls to RCX API)
        private int lastLeftMotorPower  = 0;
        private int lastRightMotorPower = 0;

        // Constructor
        public RCXDriver( )
        {
        }

        // Connect to Lego RCX brick
        public bool Connect( )
        {
            if ( !rcx.Connect( ) )
            {
                // failed to connect
                return false;
            }

            // play something on connection
            rcx.PlaySound( RCXBrick.SoundType.BeepBeep );

            return true;
        }

        // Disconnect from Lego RCX brick
        public void Disconnect( )
        {
            rcx.PlaySound( RCXBrick.SoundType.Blip );
            rcx.Disconnect( );
        }

        // Set power of A anc C motor of Lego RCX brick
        public void SetMotorsPower( float leftMotor, float rightMotor )
        {
            int leftMotorPower  = (int) ( leftMotor  * maxMotorPower );
            int rightMotorPower = (int) ( rightMotor * maxMotorPower );

            // System.Diagnostics.Debug.WriteLine( "l: " + leftMotorPower + ", r: " + rightMotorPower );

            // return if there are no changes
            if ( ( leftMotorPower == lastLeftMotorPower ) && ( rightMotorPower == lastRightMotorPower ) )
                return;

            // check if we need to stop
            if ( ( leftMotorPower == 0 ) && ( rightMotorPower == 0 ) )
            {
                rcx.SetMotorOn( RCXBrick.Motor.AC, false );
            }
            else
            {
                int motorsToOn = 0;
                int motorsToOff = 0;
                int motorsToMoveForward = 0;
                int motorsToMoveBackward = 0;

                // update left motor
                if ( leftMotorPower != lastLeftMotorPower )
                {
                    if ( leftMotorPower == 0 )
                    {
                        motorsToOff |= (int) RCXBrick.Motor.A;
                    }
                    else
                    {
                        motorsToOn |= (int) RCXBrick.Motor.A;

                        // check if direction should be changed
                        if ( leftMotorPower * lastLeftMotorPower <= 0 )
                        {
                            if ( leftMotorPower > 0 )
                            {
                                motorsToMoveForward |= (int) RCXBrick.Motor.A;
                            }
                            else
                            {
                                motorsToMoveBackward |= (int) RCXBrick.Motor.A;
                            }
                        }

                        rcx.SetMotorPower( RCXBrick.Motor.A, (byte) Math.Abs( leftMotorPower ) );
                    }
                }

                // update right motor
                if ( rightMotorPower != lastRightMotorPower )
                {
                    if ( rightMotorPower == 0 )
                    {
                        motorsToOff |= (int) RCXBrick.Motor.C;
                    }
                    else
                    {
                        motorsToOn |= (int) RCXBrick.Motor.C;

                        // check if direction should be changed
                        if ( rightMotorPower * lastRightMotorPower <= 0 )
                        {
                            if ( rightMotorPower > 0 )
                            {
                                motorsToMoveForward |= (int) RCXBrick.Motor.C;
                            }
                            else
                            {
                                motorsToMoveBackward |= (int) RCXBrick.Motor.C;
                            }
                        }

                        rcx.SetMotorPower( RCXBrick.Motor.C, (byte) Math.Abs( rightMotorPower ) );
                    }
                }

                if ( motorsToMoveForward != 0 )
                {
                    rcx.SetMotorDirection( (RCXBrick.Motor) motorsToMoveForward, true );
                }
                if ( motorsToMoveBackward != 0 )
                {
                    rcx.SetMotorDirection( (RCXBrick.Motor) motorsToMoveBackward, false );
                }
                if ( motorsToOff != 0 )
                {
                    rcx.SetMotorOn( (RCXBrick.Motor) motorsToOff, false );
                }
                if ( motorsToOn != 0 )
                {
                    rcx.SetMotorOn( (RCXBrick.Motor) motorsToOn, true );
                }
            }

            // remember current motors' power to avoid setting the same next time
            lastLeftMotorPower  = leftMotorPower;
            lastRightMotorPower = rightMotorPower;
        }
    }
}
