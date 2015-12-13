using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverheadDisplay
{
    public partial class Design : Bases.DesignBase
    {
        private List<OverheadAssembly> assemblies;
        private List<ConnectionAssembly> connections;
        private List<ConnectionInfo> createdconnections;
        public Design(List<OverheadAssembly> assemblies, List<ConnectionAssembly> connections)
        {
            this.assemblies = assemblies;
            this.connections = connections;
            this.createdconnections = new List<ConnectionInfo>();
            InitializeComponent();
            Resizer.brush = Brushes.White;

            Bases.OverheadBase ov = new Bases.OverheadBase();
            this.Controls.Add(ov);
            ov.Location = new Point(200, 200);

            Controls.OverheadList list = new Controls.OverheadList(assemblies);
            this.Controls.Add(list);
            list.Location = new Point(200, 200);
            Controls.Connections connection = new Controls.Connections(connections, createdconnections);
            this.Controls.Add(connection);
            connection.Location = new Point(500, 200);
            list.ActivateForm();
        }

        #region Reference Overrides
        public override Panel ref_TopPanel
        {
            get { return TopPanel; } set { TopPanel = value; }
        }
        public override Panel ref_BottomPanel
        {
            get { return BottomPanel; } set { BottomPanel = value; }
        }
        public override Controls.Resizer ref_Resizer
        {
            get { return Resizer; }
            set { Resizer = value; }
        }
        #endregion



    }
}
