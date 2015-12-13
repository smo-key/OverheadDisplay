using System;
using System.Reflection;

namespace OverheadDisplay
{
    public class OverheadAssembly
    {
        public OverheadAssembly(Assembly assembly, string fullfilename, string shortfilename)
        {
            this.assembly = assembly;
            this.fullfilename = fullfilename;
            this.shortfilename = shortfilename;
            Nullify();
        }
        public OverheadAssembly()
        {
            this.assembly = null;
            this.fullfilename = null;
            this.shortfilename = null;
            Nullify();
        }
        private void Nullify()
        {
            overheadform = null;
            propertiesform = null;
            eventform = null;
        }

        public string fullfilename { get; set; }
        public string shortfilename { get; set; }

        public enum Scope { Sensor, Joystick, Universal };
        public Scope[] scope { get; set; }

        public OverheadForm overheadform { get; set; }
        public PropertiesForm propertiesform { get; set; }
        public EventForm eventform { get; set; }
        public Assembly assembly { get; set; }
        public string publisher { get; set; }
        public string copyright { get; set; }
        public string name { get; set; }
        public string[] location { get; set; }
        public string id { get; set; }
        public int[] version { get; set; }
        public string versionkey { get; set; }

        public class OverheadForm
        {
            public Type type { get; set; }
        }
        public class PropertiesForm
        {
            public Type type { get; set; }
        }
        public class EventForm
        {
            public Type type { get; set; }
        }
    }
}
