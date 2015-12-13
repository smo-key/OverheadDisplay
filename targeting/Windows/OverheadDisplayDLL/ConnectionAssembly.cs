using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OverheadDisplay
{
    public class ConnectionAssembly
    {
        public ConnectionAssembly(Assembly assembly, string fullfilename, string shortfilename)
        {
            this.assembly = assembly;
            this.fullfilename = fullfilename;
            this.shortfilename = shortfilename;
        }
        public ConnectionAssembly()
        {
            this.assembly = null;
            this.fullfilename = null;
            this.shortfilename = null;
        }

        public string fullfilename { get; set; }
        public string shortfilename { get; set; }
        public string publisher { get; set; }
        public string copyright { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public int[] version { get; set; }
        public string versionkey { get; set; }
        
        public enum Scope { Sensor, Joystick, Universal };
        public Assembly assembly { get; set; }

        public Brick brick { get; set; }
        public Actions actions { get; set; }

        public class Actions
        {
            public List<Action> actions { get; set; }
        }

        public class Action
        {
            public Bases.BrickBase.Action reference { get; set; }

            public Type type { get; set; }
            public string name { get; set; }
            public string[] argnames { get; set; }
            public Type[] argtype { get; set; }
            public bool[] argoptional { get; set; }
        }

        public class Brick
        {
            public Bases.BrickBase reference { get; set; }

            public System.Type type { get; set; }
            public Bases.BrickBase.ConnectionType[] supportedtypes { get; set; }
            public List<Bases.Port> ports { get; set; }
        }

    }
}
