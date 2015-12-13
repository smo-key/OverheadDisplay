// Driving Lego Robot application
//
// Copyright © Andrew Kirillov, 2008
// andrew.kirillov@gmail.com
//

namespace LegoDriver
{
    using System;

    // Interface describing methods of Lego Robot car
    public interface ILegoDriver
    {
        // Connect to Lego brick
        bool Connect( );

        // Disconnect from Lego brick
        void Disconnect( );

        // Set power of driving motors
        void SetMotorsPower( float leftMotor, float rightMotor );
    }
}
