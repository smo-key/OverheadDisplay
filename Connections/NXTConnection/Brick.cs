using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NXTLib;

namespace NXTConnection
{
    public sealed partial class Brick : OverheadDisplay.Bases.BrickBase
    {
        public Brick(ConnectionType type, string port)
            : base(type, port)
        {
            switch (type)
            {
                case ConnectionType.Bluetooth:
                    brick = new NXTLib.Brick(NXTLib.Brick.LinkType.Bluetooth, port);
                    break;
                default:
                    break;
            }
            Init();
        }
        public Brick()
            : base()
        {
            Init();
        }

        private void Init()
        {            
            ports = new List<OverheadDisplay.Bases.Port>();
            ports.Clear();
            ports.AddRange(new Port[] { new Port("Motor A", ControlType.Motor), new Port("Motor B", ControlType.Motor),
            new Port("Motor C", ControlType.Motor), new Port("Sensor 1", ControlType.Sensor), new Port("Sensor 2", ControlType.Sensor),
            new Port("Sensor 3", ControlType.Sensor), new Port("Sensor 4", ControlType.Sensor)});
            int n = 0;
            foreach (Port item in ports)
            {
                item.brick = this.brick;
                item.location = n;
                n++;
            }            
        }

        public class Port : OverheadDisplay.Bases.Port
        {
            public Port() : base()
            {
                
            }
            public Port(string name, OverheadDisplay.Bases.BrickBase.ControlType type) : base(name, type)
            {
                GetStatus();
            }
            public Port(string name, OverheadDisplay.Bases.BrickBase.ControlType type, string default_status, bool default_ready)
                :base(name, type, default_status, default_ready)
            {
                status = default_status;
                status_ready = default_ready;
                GetStatus();
            }
            internal NXTLib.Brick brick;
            internal int location;
            public override void GetStatus()
            {
                if (location < 3)
                {
                    //motor
                    status_ready = true;
                    status = "NXT Motor";
                    return;
                }
                else
                {
                    //sensor
                    status_ready = true;
                    status = "NXT Sensor";
                    return;
                }
            }

        }

        #region Overrides

        internal NXTLib.Brick brick { get; set; }
        public override string publisher { get { return "Arthur Pachachura"; } }
        public override string copyright { get { return "Copyright (C) Arthur Pachachura 2013"; } }
        public override string name { get { return "NXT"; } }
        public override string id { get { return "F0D9C35607A1"; } }
        public override int[] version { get { return new int[] { 1, 0 }; } }
        public override string versionkey { get { return "7BEFF4B5-6C9C-43C4-8A89-0AC589162F95"; } }
        public override ConnectionType[] supportedtypes { get { return new ConnectionType[] { ConnectionType.Bluetooth }; } }
        public override string staticname
        { 
            get 
            {
                try
                {
                    _staticname = brick.Name;
                    return brick.Name;
                }
                catch
                {
                    return _staticname;
                }
            }         
        }
        private string _staticname = null;
        //if the name cannot be changed and is retrieved by the brick, then set static name !null

        public override bool IsConnected
        {
            get { return brick.IsConnected; }
        }
        public override void Connect()
        {
            if (!brick.Connect())
            {
                throw new Exception(brick.LastError);
            }
            
        }
        public override void Disconnect()
        {
            if (!brick.Disconnect())
            {
                throw new Exception(brick.LastError);
            }
        }

        
        #endregion

    }
}
