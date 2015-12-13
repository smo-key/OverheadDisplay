using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OverheadDisplay.Bases;

namespace NXTConnection
{
    public sealed partial class Actions
    {
        public class Action_MoveMotor : BrickBase.Action
        {
            public override string name { get { return "Move Motor"; } }
            public override BrickBase.Scope scope { get { return BrickBase.Scope.Joystick; } }
            public override BrickBase.Action.Style[] acceptedoutputs { get { return new Style[] 
            { BrickBase.Action.Style.Integer }; } }
            public override BrickBase.Action.ArgumentAcceptance outputacceptance { get { return ArgumentAcceptance.RequireArgs; } }

            public override bool[] argoptional { get { return new bool[] 
                { false, true }; } }
            public override string[] argnames { get { return new string[] 
                { "Port", "Break/Coast" }; } }
            public override System.Type[] argtype { get { return new Type[] 
                {  new NXTLib.Protocol.MotorPort().GetType(), new NXTLib.Protocol.MotorStop().GetType() }; } }

            public Action_MoveMotor(Brick brick) : base(brick)
            {
                this.brick = brick;                
            }
            public Action_MoveMotor() : base()
            {
                this.brick = null;
            }
            private void PrepareArgs()
            {
                this.arguments = new object[] { NXTLib.Protocol.MotorPort.ABC }; 
            }
            private Brick brick;

            public override void SetDataInteger(float integer)
            {
                int i = Convert.ToInt32(Math.Floor(integer));
                if (arguments[1] != null)
                {
                    if (!brick.brick.ProtocolLink.MoveMotors((NXTLib.Protocol.MotorPort)arguments[0]
                        , i, (NXTLib.Protocol.MotorStop)arguments[1])) { throw new Exception(brick.brick.LastError); }
                }
                if (!brick.brick.ProtocolLink.MoveMotors((NXTLib.Protocol.MotorPort)arguments[0], i))
                { throw new Exception(brick.brick.LastError); }
            }

        }
    }
    
}
