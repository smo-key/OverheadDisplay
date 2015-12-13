using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverheadDisplay
{
    public class ConnectionInfo
    {
        public ConnectionAssembly connection { get; set; }
        public string name { get; set; }
        public Bases.BrickBase.ConnectionType type { get; set; }
        public string port { get; set; }
        public Bases.BrickBase brickreference { get; set; }
    }
}
