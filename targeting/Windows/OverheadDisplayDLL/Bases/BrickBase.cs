using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OverheadDisplay.Bases
{
    public abstract partial class BrickBase
    {
        public BrickBase(ConnectionType type, string port)
        {
            this.type = type;
            this.port = port;
            if (!supportedtypes.Contains(type))
            {
                throw new Exception("Connection type not supported for this library!");
            }
            return;
        }
        public BrickBase()
        {
            this.port = null;            
        }

        public enum ConnectionType { Bluetooth, USB, WiFi }
        public ConnectionType type { get; set; }
        public string port { get; set; }
        public enum Scope { Sensor, Joystick, Universal };
        public enum ControlType { Motor, Sensor };

        public virtual string publisher { get { return null; } }
        public virtual string copyright { get { return null; } }
        public virtual string name { get { return null; } }
        public virtual string id { get { return null; } }
        public virtual int[] version { get { return null; } }
        public virtual string versionkey { get { return null; } }
        public virtual string staticname { get { return null; } }
        //if the name cannot be changed and is retrieved by the brick, then set static name !null

        public virtual ConnectionType[] supportedtypes { get { return null; } }
        public List<Port> ports { get; set; }
        
        public virtual void Connect() { }
        public virtual void Disconnect() { }
        public virtual bool IsConnected { get; internal set; }

        public abstract class Action
        {
            public virtual string name { get { return "Action"; } }
            public virtual BrickBase.Scope scope { get { return BrickBase.Scope.Universal; } }
            public enum Style
            {
                Boolean,
                //On, Off; such as a button
                Integer,
                //Integer; such as a value slider (1-dimensional)
                Point
                //Direction and distance; such as a joystick (2-dimensional)
            };

            public Action()
            {
                this.brick = null;
            }
            public Action(BrickBase brick)
            {
                this.brick = brick;
            }
            private BrickBase brick;

            //port value comes from the port and port names data slot
            public enum ArgumentAcceptance { NoArgs, AllowArgs, RequireArgs };

            public virtual string[] argnames { get { return new string[] { }; } }
            public virtual System.Type[] argtype { get { return new System.Type[] { }; } }
            public virtual bool[] argoptional { get { return new bool[] { }; } }
            public object[] arguments { get; set; }

            //Joystick Only        
            public virtual Style[] acceptedinputs { get { return null; } }
            public virtual ArgumentAcceptance inputacceptance { get { return ArgumentAcceptance.AllowArgs; } }
            public virtual void SetDataBoolean(bool boolean)
            { }
            public virtual void SetDataInteger(float integer)
            { }
            public virtual void SetDataPoint(PointF point)
            { }

            //Sensor Only        
            public virtual Style[] acceptedoutputs { get { return null; } }
            public virtual ArgumentAcceptance outputacceptance { get { return ArgumentAcceptance.AllowArgs; } }
            public virtual bool? GetDataBoolean()
            { return null; }
            public virtual float? GetDataInteger()
            { return null; }
            public virtual PointF? GetDataPoint()
            { return null; }


        }
    }

    public abstract class Port
    {
        public Port()
        {

        }
        public Port(string name, BrickBase.ControlType type)
        {
            this.name = name;
            this.type = type;
            GetStatus();
        }
        public Port(string name, BrickBase.ControlType type, string default_status, bool default_ready)
        {
            status = default_status;
            status_ready = default_ready;
            this.name = name;
            this.type = type;
            GetStatus();
        }
        public string name { get; set; }
        public BrickBase.ControlType type { get; set; }
        public string status { get; set; }
        public bool status_ready { get; set; }
        public virtual void GetStatus()
        {
            return;
        }
    }
    

}
